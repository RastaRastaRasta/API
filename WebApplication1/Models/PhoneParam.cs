namespace WebApplication1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
  using WebApplication1.Models;

  [Table("PhoneParam")]
    public partial class PhoneParam
    {
        public Guid Id { get; set; }

        public Guid? MobilePhoneId { get; set; }

        public MobilePhone MobilePhone { get; set; }

        [ForeignKey("Param")]
        public int ParamId { get; set; }

        public Param Param { get; set; }
    }
}
