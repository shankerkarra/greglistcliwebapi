using System;
using System.ComponentModel.DataAnnotations;

namespace greglistcliwebapi.Models
{
  public class Job
  {
    public string Id { get; set; }
    [Required]
    [MinLength(3)]
    [MaxLength(20)]
    public string Category { get; set; }

    [Required]
    [MinLength(3)]
    [MaxLength(20)]
    public string JobType { get; set; }
    public Job(string category, string jobtype)
    {
      Category = category;
      JobType = jobtype;
      Id = Guid.NewGuid().ToString();
    }
  }
}