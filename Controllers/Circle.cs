using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatar.Controllers
{
    internal class Circle : Shape
    {
        int r {  get; set; }

        public override double Width()
        {
            return Math.PI * r * r;
        }
    }
}
// Robbi Abdul Rohman -- 40622200023