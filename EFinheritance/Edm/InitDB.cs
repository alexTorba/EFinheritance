using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace EFinheritance.Edm
{
    class InitDB : DropCreateDatabaseAlways<ShopDBModel>
    {
        protected override void Seed(ShopDBModel context)
        {
            Phone phone1 = new Phone
            {
                Name = "Nokia 3310",
                Price = 123
            };

            Phone phone2 = new Phone
            {
                Name = "Nokia 1111",
                Price = 150000
            };

            SmartPhone p1 = new SmartPhone
            {
                Name = "IPhone10s",
                OS = "Android J=Kit-Kat",
                Price = 40000
            };

            SmartPhone p2 = new SmartPhone
            {
                Name = "Samsung galaxy 10",
                OS = "Android J=Kit-Kat",
                Price = 34000
            };

            context.Phones.AddRange(new List<Phone> { phone1, phone2 });
            context.Smarts.AddRange(new List<SmartPhone> { p1, p2 });

            context.SaveChanges();


            //base.Seed(context);
        }

    }
}
