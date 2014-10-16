using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_3__geometriska_figurer
{
    class program
    {
       
 
            
         public enum ShapeType { none, Rectangle, Ellipse }; // metoden som läser figurens bredd och längd
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                ViewMenu();       // här är det menu som visar vilken nummer du ska trycka för att välja figur
                int MyInput;
                
                if (int.TryParse(Console.ReadLine(), out MyInput) && MyInput >= 0 && MyInput <= 2) // får bara skriva in 0-2
                    {
                        switch (MyInput)
                        {
                            case 0:
                                Console.WriteLine();
                                return;
                            case 1:
                                ViewShapeDetail(CreateShape(ShapeType.Ellipse));
                                break;
                            case 2:
                                ViewShapeDetail(CreateShape(ShapeType.Rectangle));
                                break;
                        }
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(" Fel!! Ange nummer mellan 0 och 2. "); // om man skriver något annat får man fel meddelande
                        Console.ResetColor();
                    }
               

            }
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

        private static Shape CreateShape(ShapeType shapeType)
        {
        
            double length;
            double width;
            Shape shape;

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("===================================================");
            Console.WriteLine("=              Ellips                             ="); 
            Console.WriteLine("===================================================");
            Console.ResetColor();

            length = ReadDoubleGreaterThanZero("Ange längden: "); 
            width = ReadDoubleGreaterThanZero("Ange breden: ");


          
            if (shapeType == ShapeType.Ellipse)
            {                                          // returnera bredd och länden från classerna
                return shape = new Ellipse(length, width); // från Classen Ellipse 
            }
                return shape = new Rectangle(length, width);// från classen Rectangle             
        }

        private static double ReadDoubleGreaterThanZero(string prompt)
        {
            string input;
            double number;

            while (true)
            {
                Console.Write(prompt);
                input = Console.ReadLine();
                
                try
                {
                    number = double.Parse(input);
                    if (number < 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("FEL!!! {0} Är mindre än noll.", input);
                        Console.ResetColor();
                    }
                    return number;
                }
                catch 
                    {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("FEL!! felformat");
                    Console.ResetColor();
                    }
              }
        }

        private static void ViewMenu()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("==================================================");
            Console.WriteLine("=                                                =");
            Console.WriteLine("=         Geometriska figurer                    =");
            Console.WriteLine("=                                                =");
            Console.WriteLine("==================================================");
            Console.ResetColor();
            Console.WriteLine(" 0 - Exit\n 1 - Ellipse\n 2 - Rectangle");
            Console.WriteLine("=======================================");
            Console.Write("Ange menyval [0-2]: ");
        }

        private static void ViewShapeDetail(Shape shapeType)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("==================================================");
            Console.WriteLine("=                   Detaljer                     =");
            Console.WriteLine("==================================================");
            Console.ResetColor();
            Console.WriteLine(shapeType.ToString());


            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("tryck tangent knapp för att göra ny beräkning .\nESC för att avsluta.");
            Console.ResetColor();



        }  
    }
}
