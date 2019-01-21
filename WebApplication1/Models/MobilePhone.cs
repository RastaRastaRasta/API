namespace WebApplication1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

  [Table("MobilePhone")]
  public partial class MobilePhone
  {
    public Guid Id { get; set; }

    [Column(TypeName = "text")]
    [Required]
    public string ProductOwner { get; set; }

    [Column(TypeName = "text")]
    [Required]
    public string Name { get; set; }

    public ICollection<PhoneParam> PhoneParams { get; set; }
    public MobilePhone()
    {
      PhoneParams = new List<PhoneParam>();
    }
  }
}