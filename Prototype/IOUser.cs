using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Prototype
{
    public static class IOUser
    {
        public static void ConsoleOutput(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public static void ConsoleError(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Beep();
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public static void ConsoleListOutput(string title, List<String> options)
        {
            ConsoleOutput(title);
            for (int i = 0; i < options.Count; i++)
            {
                Console.WriteLine($"({i}) {options[i]}");
            }
        }
        public static void ConsoleListOutput2(string title, string [] options)
        {
            ConsoleOutput(title);
            for (int i = 0; i < options.Length; i++)
            {
                string s = Path.GetFileName(options[i]);
                Console.WriteLine($"({i}) {s}");
            }
        }
        public static void ConsoleListOutput3(string title, string[] options)
        {
            ConsoleOutput(title);
            for (int i = 0; i < options.Length; i++)
            {
                string s = Path.GetFileName(options[i]);
            
                
                
                Console.WriteLine($"({i}) {s}");
                if (i + 1 == options.Length)
                {
                    Console.WriteLine($"({i + 1})" + "Exit");
                }

            }
        }
        public static void ConsoleListOutput4(string title, List<String> options)
        {
            ConsoleOutput(title);
            for (int i = 0; i < options.Count; i++)
            {
                string s = Path.GetFileName(options[i]);
                Console.WriteLine($"({i}) {s}");


                if (i + 1 == options.Count)
                {
                    Console.WriteLine($"({i + 1})" + "Exit");
                }
            }
        }

        public static int ConsoleReadInput()
        {
            string option = Console.ReadLine();
            int optionNumber;
            while (!int.TryParse(option, out optionNumber))
            {
                ConsoleError("Input must be a number");
                option = Console.ReadLine();
            }
            return optionNumber;
        }
        public static string ConsoleReadInputs()
        {
            string option = Console.ReadLine();
            int optionNumber;
            while (int.TryParse(option, out optionNumber))
            {
                ConsoleError("Input must be string");
                option = Console.ReadLine();
            }
            return option;
        }

    }
}
