using System;

namespace passtime
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\WriteText.txt");
            System.Console.WriteLine("Contents of WriteText.txt = {0}", text);
            
            string[] lines = System.IO.File.ReadAllLines(@"C:\WriteLines2.txt");
            System.Console.WriteLine("Contents of WriteLines2.txt = ");
        
            foreach (string line in lines)
            {

                Console.WriteLine("\t" + line);
            }
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadLine();
        }
    }
}
