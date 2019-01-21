using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
  public class Mobiles
  {
    public Guid Id { get; set; }
    public string ProductOwner { get; set; }
    public string Name { get; set; }
    public List<int> Params { get; set; }
  }
}