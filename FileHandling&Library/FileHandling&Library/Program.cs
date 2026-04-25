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

            try
            {
                string filePath = "C:\\Users\\user\\OOPCsharp\\FileHandling&Library\\FileHandling&Library\\UserInfo.txt";
                string name = "User";
                string specialization = "Full-Stack Web Development";
                string age = "25";
                string description = "I specialize in frontend engineering and database management, focusing on responsive layouts.";

                string[] linesToWrite = {
            $"Name: {name}",
            $"Specialization: {specialization}",
            $"Age: {age}",
            $"Description: {description}"
        };

                File.WriteAllLines(filePath, linesToWrite);

                int totalCharactersNoSpaces = 0;
                int totalWords = 0;


                foreach (string line in File.ReadLines(filePath))
                {
                    Console.WriteLine(line);

                     totalCharactersNoSpaces += line.Count(c => !char.IsWhiteSpace(c));

                    string[] words = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    totalWords += words.Length;
                }

                Console.WriteLine($"Total characters {totalCharactersNoSpaces}");
                Console.WriteLine($"Total words: {totalWords}");

            }
            catch (Exception e) {

                Console.WriteLine(e.ToString());


            }

        }
        
    }
}
