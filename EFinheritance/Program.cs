using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFinheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ShopDBModel db = new ShopDBModel())
            {
                foreach (Phone phone in db.Phones.AsNoTracking())
                {
                    Console.WriteLine($"{phone.Id} {phone.Name} {phone.Price}");
                }

                Console.WriteLine(Environment.NewLine + new string('-',35) + Environment.NewLine);

                foreach (SmartPhone smart in db.Smarts.AsNoTracking())
                {
                    Console.WriteLine($"{smart.Id} {smart.Name} {smart.Price} {smart.OS}");
                }

            }

            Console.ReadKey();
        }
    }
}
