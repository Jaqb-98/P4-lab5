using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var es = new ESContext();
            //es.Computers.Add(new Computer() { Description = "Test Laptop", CoolingTyoe = "Air", Weight = 2, Price = 1500 });
            //es.SaveChanges();

            var ts = new TSContext();
            ts.Computers.Add(new TSComputer()
            {
                Description = "Test Laptop2",
                CoolingTyoe = "Air",
                Weight = 2,
                Price = 1500,
                Server = new Server()
                {
                    Bandwidth = 1000
                }
            });
            ts.SaveChanges();

            Console.WriteLine("Ready");
            Console.ReadKey();
        }
    }
}
