using System;
using System.Collections.Generic;
using greglistcliwebapi.Services;
using Microsoft.AspNetCore.Mvc;
using greglistcliwebapi.Models;

namespace greglistcliwebapi.Controllers
{
  [ApiController]
  [Route("/api/[controller]")]
  public class JobController : ControllerBase
  {
    private readonly JobsService _jobsService;
    public JobController(JobsService jobsService)
    {
      _jobsService = jobsService;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Job>> Get()
    {
      try
      {
        IEnumerable<Job> jobs = _jobsService.Get();
        return Ok(jobs);
      }
      catch (Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    [HttpGet("{id}")]
    public ActionResult<Job> Get(string id)
    {
      try
      {
        Job found = _jobsService.Get(id);
        return Ok(found);
      }
      catch (Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    [HttpPost]
    public ActionResult<Job> Create([FromBody] Job newJob)
    {
      try
      {
        Job job = _jobsService.Create(newJob);
        return Ok(job);
      }
      catch (Exception err)
      {
        return BadRequest(err.Message);
      }
    }
  }
}