using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
  [Table("Params")]
  public class Param
  {
    // [Column(name: "Id")]
    public int ParamId { get; set; }
    [Column(name: "Params")]
    public string Name { get; set; }
  }
}