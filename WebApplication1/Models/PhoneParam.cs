namespace WebApplication1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhoneParam")]
    public partial class PhoneParam
    {
        public Guid Id { get; set; }

        public Guid MobilePhoneId { get; set; }

        public int Param { get; set; }
    }
}
