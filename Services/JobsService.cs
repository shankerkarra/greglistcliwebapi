using System;
using System.Collections.Generic;
using greglistcliwebapi.Models;

namespace greglistcliwebapi.Services
{
  public class JobsService
  {
    internal IEnumerable<Job> Get()
    {
      return fakedb.Jobs;
    }
    internal Job Get(string id)
    {
      Job found = fakedb.Jobs.Find(j => j.Id == id);
      if (found == null)
      {
        throw new Exception("Invalid Id");
      }
      return found;
    }
    internal Job Create(Job newJob)
    {
      fakedb.Jobs.Add(newJob);
      return newJob;
    }
    internal void Delete(string id)
    {
      int deletedJob = fakedb.Jobs.RemoveAll(j => j.Id == id);
      if (deletedJob == 0)
      {
        throw new Exception("Invalid Id");
      }
    }
  }
}