using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Server
    {
        public int Id { get; set; }
        public int ComputerId { get; set; }
        public int Bandwidth { get; set; }
        public virtual TSComputer Computer { get; set; }
    }
}
