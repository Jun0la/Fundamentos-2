using System;

namespace Test
{
    class Test_Basics
    {
        static void Main(String[] args)
        {
            string original = "abcdefghijklmnopqrstuvxyz     -.";
            
            string s1 = original.ToUpper();
            string s2 = original.Trim();

            int n1 = original.IndexOf("vxyz");
            int n2 = original.LastIndexOf("z");

            string s3 = original.Substring(21);
            string s5 = original.Replace('a', 'x');

            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = String.IsNullOrWhiteSpace(original);

            //Console.WriteLine(s3 + s5 + b1);
        }
    }
}