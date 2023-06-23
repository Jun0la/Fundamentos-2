using System;

namespace TASK
{
    class Basics_3
    {

    static void Main()
        
        {
            
            // CLASS TRIANGULO             
            class Triangle
            
            public double A;
            public double B;
            public double C;   

            public double Area()
            {
            double p = (A + B + C) / 2;

            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));

            return raiz;    
            }
            
            Triangle x, y;

            x = new Triangle();
            y = new Triangle();

            Console.WriteLine("Entre com as medidas do triangulo X");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo Y");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();

            double areaY = y.Area();

            Console.WriteLine("Área de x = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }

            else { Console.WriteLine("Maior área: Y"); 
            }
            
 
        }
    } 
} 