using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3__geometriska_figurer
{
    public class Ellipse : Shape
    {
        public override double Area // override systemet för att inte använda area från Shape classen uten använda den här..
      {
          get { return Math.PI * (Length/ 2 ) * (Width / 2);}  // beräkna area 
          }
        public override double perimeter  {
            get { return Math.PI * Math.Sqrt(2 * (Length / 2) * (Length / 2) + 2 * (Width / 2)); }// omkrets beräkning 
            }

        public Ellipse(double length, double width) : base(length, width) { }
    }
}
