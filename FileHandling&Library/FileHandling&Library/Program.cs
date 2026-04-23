using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling_Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                String[] lines = File.ReadAllLines("C:\\Users\\user\\OOPCsharp\\FileHandling&Library\\FileHandling&Library\\data.txt");
              
                File.AppendAllText( "C:\\Users\\user\\OOPCsharp\\FileHandling&Library\\FileHandling&Library\\data.txt", "\n hello word");

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }

            }
            catch(Exception e) {
            
            Console.WriteLine(e.ToString());
            
            }

        }
    }
}
