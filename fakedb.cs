using System.Collections.Generic;
using greglistcliwebapi.Models;

namespace greglistcliwebapi
{
  static public class fakedb
  {
    static public List<Job> Jobs { get; set; } = new List<Job>() { new Job("Construction", "Plumber") };
  }
}