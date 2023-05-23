using System;
using System.IO;

namespace Udemy
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePatch = @"C:\Users\ju-sh\OneDrive\Área de Trabalho\FUN\ARCHIVES\Udemy System.IO\Udemy#\file.txt";
            string targetPatch = @"C:\Users\ju-sh\OneDrive\Área de Trabalho\FUN\ARCHIVES\Udemy System.IO\Udemy#\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePatch);
                fileInfo.CopyTo(targetPatch);
                string[] lines = File.ReadAllLines(sourcePatch);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An ERROR!");
                Console.WriteLine(e.Message);
            }
        }
    }
}