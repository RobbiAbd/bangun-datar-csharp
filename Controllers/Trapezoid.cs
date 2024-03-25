using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatar.Controllers
{
    internal class Trapezoid : Shape
    {   
        public int a {  get; set; }
        public int b { get; set; }
        public int t { get; set; }
       
        public override double Width()
        {
            return 0.5 * t * (a + b);
        }
    }
}
// Robbi Abdul Rohman -- 40622200023