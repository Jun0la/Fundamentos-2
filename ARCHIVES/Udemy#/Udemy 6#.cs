namespace TASK
{
class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Mary");
            list.Add("Bob");
            list.Insert(0, "A Manow");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            string s1 = list.Find(x => x[0] == 'A');
            string s2 = list.FindLast(x => x[0] == 'B');

            int pos1 = list.FindIndex(x => x[0] == 'A');
            int pos2 = list.FindLastIndex(x => x[0] == 'B');

            Console.WriteLine("First " + s1 + s2);
            Console.WriteLine("Primeiro = " + pos1 + pos2);
            //Console.WriteLine("List count = " + list.Count);

            List<string> list2 = list.FindAll(x => x.Length>= 1);
            foreach (string obj in list2) 
            {
                Console.WriteLine(obj);
            }

            //list.Remove("Bob");
            /*
            list.RemoveAt(1);
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }
            */

            //double[,] mat = new double[2, 3]; 
        }
    }
}