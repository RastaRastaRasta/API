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
    Model db = new Model();

    //// GET api/values
    //public List<MobilePhone> Get()
    //{
    //  mobiles.AddRange(new List<MobilePhone>
    //  {
    //        new MobilePhone() { ProductOwner = "Apple", Name = "IPhone 7", Params = new List<PhoneParams>() { PhoneParams.WaterProtected, PhoneParams.NFC }},
    //        new MobilePhone() { ProductOwner = "Apple", Name = "IPhone 8", Params = new List<PhoneParams>() { PhoneParams.NFC, PhoneParams.NoBreak }},
    //        new MobilePhone() { ProductOwner = "Apple", Name = "IPhone X", Params = new List<PhoneParams>() { PhoneParams.NFC, PhoneParams.doubleSim, PhoneParams.doubleCam, PhoneParams.NoBreak }},
    //        new MobilePhone() { ProductOwner = "Samsung", Name = "A5", Params = new List<PhoneParams>() { PhoneParams.WaterProtected, PhoneParams.doubleSim, PhoneParams.doubleCam, PhoneParams.NoBreak }},
    //        new MobilePhone() { ProductOwner = "Samsung", Name = "S9", Params = new List<PhoneParams>() { PhoneParams.doubleSim, PhoneParams.doubleCam, PhoneParams.WaterProtected }},
    //        new MobilePhone() { ProductOwner = "Samsung", Name = "C8", Params = new List<PhoneParams>() { PhoneParams.doubleSim }},
    //        new MobilePhone() { ProductOwner = "Huawei", Name = "Mate 20 lite", Params = new List<PhoneParams>() { PhoneParams.doubleSim, PhoneParams.doubleCam }},
    //        new MobilePhone() { ProductOwner = "Huawei", Name = "nova 3", Params = new List<PhoneParams>() { PhoneParams.doubleSim, PhoneParams.NoBreak }},
    //        new MobilePhone() { ProductOwner = "Huawei", Name = "Y6 Prime", Params = new List<PhoneParams>() { PhoneParams.doubleSim, PhoneParams.NFC, PhoneParams.NoBreak }},
    //        new MobilePhone() { ProductOwner = "Xiaomi", Name = "Mi 8 Lite", Params = new List<PhoneParams>() { PhoneParams.doubleSim, PhoneParams.doubleCam, PhoneParams.WaterProtected }},
    //        new MobilePhone() { ProductOwner = "Xiaomi", Name = "Redmi Note 6 Pro", Params = new List<PhoneParams>() { PhoneParams.doubleSim, PhoneParams.NFC, PhoneParams.doubleCam } },
    //        new MobilePhone() { ProductOwner = "Xiaomi", Name = "Redmi 5", Params = new List<PhoneParams>() { PhoneParams.doubleSim, PhoneParams.NFC } },
    //        new MobilePhone() { ProductOwner = "Asus", Name = "ZenFone 5Z", Params = new List<PhoneParams>() { PhoneParams.doubleSim, PhoneParams.WaterProtected } },
    //        new MobilePhone() { ProductOwner = "Asus", Name = "ZenFone 4 Selfie Pro", Params = new List<PhoneParams>() { PhoneParams.doubleSim, PhoneParams.NoBreak, PhoneParams.WaterProtected } },
    //        new MobilePhone() { ProductOwner = "Asus", Name = "ZenFone Max Pro", Params = new List<PhoneParams>() { PhoneParams.doubleSim, PhoneParams.NoBreak } },
    //        new MobilePhone() { ProductOwner = "Meizu", Name = "M5C", Params = new List<PhoneParams>() { PhoneParams.doubleSim } },
    //        new MobilePhone() { ProductOwner = "Meizu", Name = "M8 LITE", Params = new List<PhoneParams>() { PhoneParams.doubleSim, PhoneParams.doubleCam } },
    //        new MobilePhone() { ProductOwner = "Meizu", Name = "NOTE 8", Params = new List<PhoneParams>() { PhoneParams.doubleCam, PhoneParams.NFC } },
    //        new MobilePhone() { ProductOwner = "ZTE", Name = "Axon 9 PRO", Params = new List<PhoneParams>() { PhoneParams.doubleSim, PhoneParams.NFC, PhoneParams.NoBreak, PhoneParams.WaterProtected, PhoneParams.doubleCam } },
    //        new MobilePhone() { ProductOwner = "ZTE", Name = "Blade V9 Vita", Params = new List<PhoneParams>() { PhoneParams.doubleSim, PhoneParams.doubleCam } },
    //        new MobilePhone() { ProductOwner = "ZTE", Name = "Blade A6 max", Params = new List<PhoneParams>() { PhoneParams.doubleSim } },
    //        new MobilePhone() { ProductOwner = "LG", Name = "Q6", Params = new List<PhoneParams>() { PhoneParams.doubleSim, PhoneParams.doubleCam } },
    //        new MobilePhone() { ProductOwner = "LG", Name = "G7 ThinQ", Params = new List<PhoneParams>() { PhoneParams.doubleCam } },
    //        new MobilePhone() { ProductOwner = "LG", Name = "X venture", Params = new List<PhoneParams>() { PhoneParams.NoBreak, PhoneParams.WaterProtected } },
    //        new MobilePhone() { ProductOwner = "Nokia", Name = "8.1", Params = new List<PhoneParams>() { PhoneParams.doubleSim, PhoneParams.WaterProtected } },
    //        new MobilePhone() { ProductOwner = "Nokia", Name = "6.1", Params = new List<PhoneParams>() { PhoneParams.doubleSim, PhoneParams.NFC, PhoneParams.NoBreak } },
    //        new MobilePhone() { ProductOwner = "Nokia", Name = "5.1", Params = new List<PhoneParams>() { PhoneParams.doubleCam, PhoneParams.NFC, PhoneParams.WaterProtected } }
    //  });
    //  return mobiles;
    //}

    // GET api/values/5
    public Mobiles Get(Guid id)
    {
      if (id == null)
        return null;

      var db = new Model();
      var mobilePhone = db.MobilePhone.FirstOrDefault(x => x.Id == id);
      if (mobilePhone != null)
      {

        var phoneParams = db.PhoneParam.Where(x => x.MobilePhoneId == id).Select(y => y.Param).ToList();
        
        return new Mobiles
        {
          Id = mobilePhone.Id,
          ProductOwner = mobilePhone.ProductOwner,
          Name = mobilePhone.Name,
          Params = phoneParams
        };
      }
      else
      {
        return null;
      }
    }

    // POST api/values
    public IHttpActionResult Post([FromBody]MobilePhone mobilePhone)
    {
      if (mobilePhone == null)
        return this.BadRequest();

      db.MobilePhone.Add(mobilePhone);
      db.SaveChanges();

      //item.ProductOwner = mobilePhone.ProductOwner;
      //item.Name = mobilePhone.Name;

      //var listRemove = db.PhoneParam.Where(x => x.MobilePhoneId == mobilePhone.Id).ToList();
      //db.PhoneParam.RemoveRange(listRemove);

      //foreach(var param in mobilePhone.Params)
      //{
      //  db.PhoneParam.Add(new PhoneParam
      //  {
      //    Id = Guid.NewGuid(),
      //    MobilePhoneId = mobilePhone.Id,
      //    Param = param
      //  }
      //    );
      //}
      //db.SaveChanges();
      return this.Ok();
    }

    // PUT api/values/5
    public IHttpActionResult Put(Guid id, [FromBody] MobilePhone mobilePhone)
    {
      if (id == null)
      {
        return this.BadRequest();
      }
      var currentMobile = db.MobilePhone.Find(id);
      if (currentMobile == null)
        return this.NotFound();
      currentMobile.Name = mobilePhone.Name;
      currentMobile.ProductOwner = mobilePhone.ProductOwner;
      //currentMobile.Param = mobilePhone.Param;


      //var item = new MobilePhone
      //{
      //  Id = mobilePhone.Id,
      //  ProductOwner = mobilePhone.ProductOwner,
      //  Name = mobilePhone.Name
      //};

      //db.MobilePhone.Add(item);

      //foreach (var param in mobilePhone.Params)
      //{
      //  db.PhoneParam.Add(new PhoneParam
      //  {
      //    Id = Guid.NewGuid(),
      //    MobilePhoneId = mobilePhone.Id,
      //    Param = param
      //  }
      //    );
      //}

      db.SaveChanges();
      return this.Ok();
    }

    // DELETE api/values/5
    public IHttpActionResult Delete(Guid id)
    {

      if (id == null)
        return this.BadRequest();

      var mobilePhone = db.MobilePhone.Find(id);
      if (mobilePhone == null)
        return this.NotFound();
      db.MobilePhone.Remove(mobilePhone);
      db.SaveChanges();
      //{
      //  var mobilePhone = db.MobilePhone.FirstOrDefault(x => x.Id == id);
      //  if (mobilePhone != null)
      //  {
      //    db.MobilePhone.Remove(mobilePhone);
      //    db.SaveChanges();
      //    return true;
      //  }
      //  else
      //  {
      //    return false;
      return this.Ok();
    }
  }
}


