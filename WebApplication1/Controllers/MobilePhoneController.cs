using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class MobilePhoneController : ApiController
    {
        List<MobilePhone> mobiles = new List<MobilePhone>();
    
        // GET: api/MobilePhone
        public IEnumerable<MobilePhone> Get()
        {
            return new MobilePhone[] 
            {
                new MobilePhone() { Name = "3310", Price = 499.90,ProductOwner = "Nokia"},
                new MobilePhone() { Name = "A50", Price = 199.90,ProductOwner = "Samsung"}
            };
        }

        // GET: api/MobilePhone/5
        public string Get(Guid id)
        {
            return "value";
        }

        // POST: api/MobilePhone
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/MobilePhone/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/MobilePhone/5
        public void Delete(int id)
        {
        }
    }
}
