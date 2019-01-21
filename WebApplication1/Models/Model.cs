namespace WebApplication1
{
  using System;
  using System.Data.Entity;
  using System.ComponentModel.DataAnnotations.Schema;
  using System.Linq;

  public partial class Model : DbContext
  {
    public Model()
        : base("name=Model1")
    {
    }

    public virtual DbSet<MobilePhone> MobilePhone { get; set; }
    public virtual DbSet<PhoneParam> PhoneParam { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      modelBuilder.Entity<MobilePhone>()
          .Property(e => e.ProductOwner)
          .IsUnicode(false);

      modelBuilder.Entity<MobilePhone>()
          .Property(e => e.Name)
          .IsUnicode(false);
    }
  }
}
