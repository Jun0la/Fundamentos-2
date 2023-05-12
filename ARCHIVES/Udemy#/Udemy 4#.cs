namespace TASK
{
    public class Basics_4
    {
        struct Point
    {
        public double X;
        public double Y;

        public override string ToString()
        {
            return "(" + X + ", " + Y + ")";
        }
        static void Main(string[] args)
        {

            /*
            double? x = null;
            double  a = x ?? 5; 
            
            double? y = 10;

            System.Console.WriteLine(x.GetValueOrDefault());
            System.Console.WriteLine(x.HasValue);

            if (x.HasValue) Console.WriteLine (x.Value)
            else "X is Null"

            if (y.HasValue) Console.Write (y.Value)
            else "Y is null"
            */

            Point p;

            p.X= 10;
            p.Y= 20;

            Console.WriteLine(p);

    }
  }
}