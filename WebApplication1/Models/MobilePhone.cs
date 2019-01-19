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
        public double Price { get; set; }
        public string ProductOwner { get; set; }
    }
}