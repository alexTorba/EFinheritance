namespace EFinheritance
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ShopDBModel : DbContext
    {
       
        static ShopDBModel()
        {
            Database.SetInitializer(new EFinheritance.Edm.InitDB());
        }

        public ShopDBModel()
            : base("name=ShopDBModel")
        {
        }



        public virtual DbSet<Phone> Phones { get; set; }
        public virtual DbSet<SmartPhone> Smarts { get; set; }

    }

   
}