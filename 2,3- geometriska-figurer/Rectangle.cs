using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3__geometriska_figurer
{
    public class  Rectangle : Shape
    {
        public override double Area // override systemet för att inte använda area från Shape classen uten använda den här..
        {
            get { return Length * Width; } // beräknar rektangels area 
        }
        public override double perimeter  // samma som Area har vi override system
        {
            get { return 2 * Length + 2 * Width; } // beräknar omkrets 
        }
        public Rectangle(double length, double width) : base(length, width) { } // vi ska  kalla på dem  i andra classer
    }
}
