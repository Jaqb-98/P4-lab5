using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            //var tph = new TPHContext();
            //tph.Computers.Add(new Laptop() { Price = 1000, Description = "Standard Laptop", Weight = 3 });
            //tph.SaveChanges();


            //var tpt = new TPTContext();
            //tpt.Computers.Add(new Laptop() { Price = 1000, Description = "Lightweight Laptop", Weight = 1 });
            //tpt.SaveChanges();

            var tpc = new TPCContext();
            tpc.Computers.Add(new Laptop() { Price = 1000, Description = "Lightweight Laptop", Weight = 1 });
            tpc.SaveChanges();


            Console.WriteLine("Ready");
            Console.ReadKey();
        }
    }
}
