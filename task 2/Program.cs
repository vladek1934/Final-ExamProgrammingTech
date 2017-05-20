
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{

    class Program
    {





        static void Main(string[] args)
        {
            Console.WriteLine("Vvedite adress");
            string dir = Console.ReadLine();
            string directory = @dir;

            System.IO.Directory.SetCurrentDirectory(directory);

            string currentDirName = System.IO.Directory.GetCurrentDirectory();
            Console.WriteLine(currentDirName);

            string[] files = System.IO.Directory.GetFiles(currentDirName, "*.txt");

            foreach (string s in files)
            {

                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                string current2 = s;

                string[] lines = System.IO.File.ReadAllLines(@s);

                foreach (string line in lines)
                {
                    if (line == "abcd") { Console.WriteLine(s); }
                }

            }

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("All of those files contain abcd");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}

