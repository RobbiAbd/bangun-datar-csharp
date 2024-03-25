using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatar.Controllers
{
    internal class Triangle : Shape
    {
        public int a {  get; set; }
        public int t { get; set; }

        public override double Width()
        {
            return 0.5 * a * t;
        }
    }
}
// Robbi Abdul Rohman -- 40622200023