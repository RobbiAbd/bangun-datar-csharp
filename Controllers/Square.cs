using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatar.Controllers
{
    internal class Square : Shape
    {
        public int p { get; set; }
        public int l { get; set; }

        public override double Width()
        {
            return p * l;
        }
    }
}
// Robbi Abdul Rohman -- 40622200023