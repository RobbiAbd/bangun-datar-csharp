using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatar.Controllers
{
    internal class Circle : Shape
    {
        public int r {  get; set; }

        public override double Width()
        {
            return Math.Round(Math.PI * r * r, 2);
        }
    }
}
// Robbi Abdul Rohman -- 40622200023