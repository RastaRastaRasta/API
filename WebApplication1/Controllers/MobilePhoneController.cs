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
            new MobilePhone() { ProductOwner = "Apple", Name = "IPhone 7", Params = new List<PhoneParams>() { PhoneParams.WaterProtected, PhoneParams.NFC }},
            new MobilePhone() { ProductOwner = "Apple", Name = "IPhone 8", Params = new List<PhoneParams>() { PhoneParams.NFC, PhoneParams.NoBreak }},
            new MobilePhone() { ProductOwner = "Apple", Name = "IPhone X", Params = new List<PhoneParams>() { PhoneParams.NFC, PhoneParams.doubleSim, PhoneParams.doubleCam, PhoneParams.NoBreak }},
            new MobilePhone() { ProductOwner = "Samsung", Name = "A5", Params = new List<PhoneParams>() { PhoneParams.WaterProtected, PhoneParams.doubleSim, PhoneParams.doubleCam, PhoneParams.NoBreak }},
            new MobilePhone() { ProductOwner = "Samsung", Name = "S9", Params = new List<PhoneParams>() { PhoneParams.doubleSim, PhoneParams.doubleCam, PhoneParams.WaterProtected }},
            new MobilePhone() { ProductOwner = "Samsung", Name = "C8", Params = new List<PhoneParams>() { PhoneParams.doubleSim }},
            new MobilePhone() { ProductOwner = "Huawei", Name = "Mate 20 lite", Params = new List<PhoneParams>() { PhoneParams.doubleSim, PhoneParams.doubleCam }},
            new MobilePhone() { ProductOwner = "Huawei", Name = "nova 3", Params = new List<PhoneParams>() { PhoneParams.doubleSim, PhoneParams.NoBreak }},
            new MobilePhone() { ProductOwner = "Huawei", Name = "Y6 Prime", Params = new List<PhoneParams>() { PhoneParams.doubleSim, PhoneParams.NFC, PhoneParams.NoBreak }},
            new MobilePhone() { ProductOwner = "Xiaomi", Name = "Mi 8 Lite", Params = new List<PhoneParams>() { PhoneParams.doubleSim, PhoneParams.doubleCam, PhoneParams.WaterProtected }},
            new MobilePhone() { ProductOwner = "Xiaomi", Name = "Redmi Note 6 Pro", Params = new List<PhoneParams>() { PhoneParams.doubleSim, PhoneParams.NFC, PhoneParams.doubleCam } },
            new MobilePhone() { ProductOwner = "Xiaomi", Name = "Redmi 5", Params = new List<PhoneParams>() { PhoneParams.doubleSim, PhoneParams.NFC } },
            new MobilePhone() { ProductOwner = "Asus", Name = "ZenFone 5Z", Params = new List<PhoneParams>() { PhoneParams.doubleSim, PhoneParams.WaterProtected } },
            new MobilePhone() { ProductOwner = "Asus", Name = "ZenFone 4 Selfie Pro", Params = new List<PhoneParams>() { PhoneParams.doubleSim, PhoneParams.NoBreak, PhoneParams.WaterProtected } },
            new MobilePhone() { ProductOwner = "Asus", Name = "ZenFone Max Pro", Params = new List<PhoneParams>() { PhoneParams.doubleSim, PhoneParams.NoBreak } },
            new MobilePhone() { ProductOwner = "Meizu", Name = "M5C", Params = new List<PhoneParams>() { PhoneParams.doubleSim } },
            new MobilePhone() { ProductOwner = "Meizu", Name = "M8 LITE", Params = new List<PhoneParams>() { PhoneParams.doubleSim, PhoneParams.doubleCam } },
            new MobilePhone() { ProductOwner = "Meizu", Name = "NOTE 8", Params = new List<PhoneParams>() { PhoneParams.doubleCam, PhoneParams.NFC } },
            new MobilePhone() { ProductOwner = "ZTE", Name = "Axon 9 PRO", Params = new List<PhoneParams>() { PhoneParams.doubleSim, PhoneParams.NFC, PhoneParams.NoBreak, PhoneParams.WaterProtected, PhoneParams.doubleCam } },
            new MobilePhone() { ProductOwner = "ZTE", Name = "Blade V9 Vita", Params = new List<PhoneParams>() { PhoneParams.doubleSim, PhoneParams.doubleCam } },
            new MobilePhone() { ProductOwner = "ZTE", Name = "Blade A6 max", Params = new List<PhoneParams>() { PhoneParams.doubleSim } },
            new MobilePhone() { ProductOwner = "LG", Name = "Q6", Params = new List<PhoneParams>() { PhoneParams.doubleSim, PhoneParams.doubleCam } },
            new MobilePhone() { ProductOwner = "LG", Name = "G7 ThinQ", Params = new List<PhoneParams>() { PhoneParams.doubleCam } },
            new MobilePhone() { ProductOwner = "LG", Name = "X venture", Params = new List<PhoneParams>() { PhoneParams.NoBreak, PhoneParams.WaterProtected } },
            new MobilePhone() { ProductOwner = "Nokia", Name = "8.1", Params = new List<PhoneParams>() { PhoneParams.doubleSim, PhoneParams.WaterProtected } },
            new MobilePhone() { ProductOwner = "Nokia", Name = "6.1", Params = new List<PhoneParams>() { PhoneParams.doubleSim, PhoneParams.NFC, PhoneParams.NoBreak } },
            new MobilePhone() { ProductOwner = "Nokia", Name = "5.1", Params = new List<PhoneParams>() { PhoneParams.doubleCam, PhoneParams.NFC, PhoneParams.WaterProtected } }

            //new MobilePhone() { Name = "A50", Price = 199.90,ProductOwner = "Samsung"}
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
