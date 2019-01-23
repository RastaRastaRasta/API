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
    Model db = new Model(); //переменная для Моделей   

    // GET api/values/5
    public Mobiles Get(Guid id) //метод на получение данных
    {
      if (id == null)
        return null; //проверка id телефона на нулевое значение

      var db = new Model();
      var mobilePhone = db.MobilePhone.FirstOrDefault(x => x.Id == id); //запрос на получение телефонов по id
      if (mobilePhone != null)
      {

        var phoneParams = db.PhoneParam.Where(x => x.MobilePhoneId == id).Select(y => y.Param).ToList();//запрос на получение параметов
        
        return new Mobiles //получение телефонов из базы
        {
          Id = mobilePhone.Id,
          ProductOwner = mobilePhone.ProductOwner,
          Name = mobilePhone.Name,
          Params = phoneParams
        };
      }
      else
      {
        return null; //если нет,возвращение нулевого значения
      }
    }

    // POST api/values
    public IHttpActionResult Post([FromBody]PhoneModel mobilePhone) //метода на добавление данных
    {
      if (mobilePhone == null)
        return this.BadRequest(); //проверка класса телефонов на нулевое значение

      db.MobilePhone.Add( new MobilePhone
      {
        Id = mobilePhone.Id,
        Name = mobilePhone.Name,
        ProductOwner = mobilePhone.ProductOwner
      }); //добавление данных телефона
      db.PhoneParam.AddRange(mobilePhone.PhoneParams.Select(x => new PhoneParam
      {
        Id = Guid.NewGuid(),
        MobilePhoneId = mobilePhone.Id,
        ParamId = x
      })); //добавление параметров телефона

      db.SaveChanges(); //сохранение изменений     
      return this.Ok(); 
    }

    // PUT api/values/5
    public IHttpActionResult Put([FromBody] PhoneModel mobilePhone)
    {
      if (mobilePhone.Id == Guid.Empty)
      {
        return this.BadRequest();
      } //проверка на качество запроса
      var currentMobile = db.MobilePhone.Find(mobilePhone.Id);
      if (currentMobile == null)
        return this.NotFound(); //проверка на нулевое значение
      currentMobile.Name = mobilePhone.Name;
      currentMobile.ProductOwner = mobilePhone.ProductOwner;

      var param = db.PhoneParam.Where(x => x.MobilePhoneId == mobilePhone.Id);
      db.PhoneParam.RemoveRange(param);

      db.PhoneParam.AddRange(mobilePhone.PhoneParams.Select(x=> new PhoneParam
      {
        Id = Guid.NewGuid(),
        MobilePhoneId = mobilePhone.Id,
        ParamId = x
      }));      
      db.SaveChanges();//сохранение изменений 
      return this.Ok();
    }

    // DELETE api/values/5
    public IHttpActionResult Delete(Guid id)
    {

      if (id == null)
        return this.BadRequest(); //проверка id телефона на нулевое значение

      var mobilePhone = db.MobilePhone.Find(id); //обнаружение первичного ключа по id

      var param = db.PhoneParam.Where(x => x.MobilePhoneId == mobilePhone.Id); //запрос параметров по id телефона
      db.PhoneParam.RemoveRange(param); //удаление значений параметров из таблицы

      if (mobilePhone == null)
        return this.NotFound(); //проверка на нулевое значение
      db.MobilePhone.Remove(mobilePhone); //удаление телефона из таблицы
      db.SaveChanges(); //сохранение изменений
      return this.Ok();
    }
  }
}


