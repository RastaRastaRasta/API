using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
  public class PhoneModel
  {
    public Guid Id { get; set; }

    public string ProductOwner { get; set; }

    public string Name { get; set; }

    public int[] PhoneParams { get; set; }

    }
  
}