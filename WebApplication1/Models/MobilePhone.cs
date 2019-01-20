using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class MobilePhone
    {
        public MobilePhone()
        {
            this.Id = Guid.NewGuid();
        }
        public Guid Id { get; }
        public string Name { get; set; }
        public List<PhoneParams> Params { get; set; }
        public string ProductOwner { get; set; }
    }
    public enum PhoneParams
    {
        doubleCam,
        doubleSim,
        WaterProtected,
        NoBreak,
        NFC
    }
}