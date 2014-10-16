using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3__geometriska_figurer
{
   
     public abstract class Shape 
    {
     
        private double _length;
        private double _width;
        const int MyNumber = 1;
        

         // egenskaper 

        public abstract  double Area // här har vi en abstract Area vilket menas att vi måste använda override i andra classer 
        { 
            get; 
        }
        public double Length // figurens längd 
        {
            get{ return _length; }
            set {

                if (value < MyNumber)  // om man mata in värde som är mindre än MyNumber alltså (1) så kastas värdet ut   
                {
                    throw new ArgumentException();
                }

                _length = value; }
            }


        public abstract double perimeter
        {
            get;
        }

        public double Width 
        {
            get { return _width; }
            set 
            {
                if (value < MyNumber) 
                {
                    throw new ArgumentException();
                }
                _width = value;
            }
        }
         // metoder

        protected Shape(double length, double width) 
        {
            Length = length; 
            Width = width;
        }

        public override string ToString()
{
 	  return string.Format ("Length    : {0, 15:f2}\nWidth     :  {1, 15:f2}\nPerimeter   :  {2, 15:f2}\nArea      :  {3, 15:f2}", Length, Width, perimeter, Area);
}
         
    }
}
