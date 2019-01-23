namespace WebApplication1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

  [Table("MobilePhone")] //модель для таблицы MobilePhone
  public partial class MobilePhone //класс для данных телефона
  {
    public Guid Id { get; set; } //id

    [Column(TypeName = "text")] //тип столбца
    [Required] //обязательно для заполнения
    public string ProductOwner { get; set; } //производитель

    [Column(TypeName = "text")] //тип столбца
    [Required] //обязательно для заполнения
    public string Name { get; set; } //имя модели телефона

    public ICollection<PhoneParam> PhoneParams { get; set; } //коллекция параметров
    public MobilePhone()
    {
      PhoneParams = new List<PhoneParam>();
    }
  }
}