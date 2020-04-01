using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TSComputer
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string CoolingTyoe { get; set; }
        public int Weight { get; set; }
        public virtual Server Server { get; set; }
    }
}
