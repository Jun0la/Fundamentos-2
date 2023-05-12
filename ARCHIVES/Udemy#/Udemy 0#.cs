using System;

/*

namespace TASK
{
    class Basics
    {

    static void Main()
        
        {   
            //BOM DIA BOA TARDE BOA NOITE
            
            System.Console.WriteLine("Qual a hora?");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12){System.Console.WriteLine("BOM DIA!");}
            else if (hora < 18){System.Console.WriteLine("BOA TARDE");}
            else {System.Console.WriteLine("BOA NOITE!");}
            

            
            //PAR ou IMPAR
            System.Console.WriteLine("Digite um número");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0) {System.Console.WriteLine("Par!");}
            else            {System.Console.WriteLine("Impar!");}


            // bool c1 = 2 > 3 || 4 != 5        // true por conta do || basta 1 ser true.
            // bool c2 = 2 > 3 && 4 != 5        // false se 1 for false.
            // bool c3 = ! (2 > 3) && 4 != 5    // true, ambos true.
            // bool c4 = c1 || c2 && c3;


            //split entrada de dados
            string[] Sv = Console.ReadLine().Split(' ');
            string a = Sv[0];
            int b = int.Parse(Sv[1]);
            char c = char.Parse(Sv[2]);
            // double d = double.Parse(Sv[3], CultureInfo.InvariantCulture);
            
            
            //tipos inplicitos
            
            int n1 = 3 + 4 * 2;     //11
            int n2 = (3 + 4) * 2;   //14
            int n3 = 17 % 3;        //2
            
            double n4 = (double) 10.0 / 8; //1,25

            double a = 1.0, b = -3.0, c = -4.0;
            double delta = b * b - 4.0 * a * c;
            double delta_math = Math.Pow(b, 2.0) - 4.0 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            
            
            int a = 5;
            int b = 2;
            double resultado = (double) a / b;

            double c;
            int d;
            c = 5.1;
            b = (int) a;
            

            float x = 4.5f;
            double y = x;
            

            int l = 10;
            l += 10;
            l++;


            string s = "abc";
            s += "defgh";

        
            int t = 10;
            int f = ++t;
            int r = t++;
            
        }

    }
} 

*/