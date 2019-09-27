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

        public static void ConsoleListOutput5(string title, List<Imagen> options)
        {
            ConsoleOutput(title);
            for (int i = 0; i < options.Count; i++)
            {
                Console.WriteLine($"({i}) {options[i].Nombre}");
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

        public static List<int> SearchParse(string search)
        {
            string[] t = search.Split(',');
            List<int> k = new List<int>();

            for (int p = 0; p < t.Length; p++)
            {
                int ki = Int32.Parse(t[p]);
                k.Add(ki);
            }
            return k;
        }
        public static Filtros SearchParse2(string search,List<string> list)
        {
            string[] t = search.Split('/');
            List<int> k = new List<int>();
            int Counter = 0;

            Filtros filter = new Filtros();
            List<tag> Ltag = new List<tag>();
            List<Persona> Lperson = new List<Persona>();
            List<string> Lcharacte = new List<string>();
            List<string> Lsaturation = new List<string>();
            List<string> Lresolution = new List<string>();
            List<string> Laspect = new List<string>();
            List<int> Lrating = new List<int>();



            foreach (string st in list)
            {
                if (list[Counter] == "tags")
                {
                    tag taggi = new tag();
                    taggi.Name= t[Counter];
                    Ltag.Add(taggi);

                }
                if (list[Counter] == "people")
                {
                    Persona personi = new Persona();
                    personi.Nombre = t[Counter];
                    Lperson.Add(personi);

                }
                if (list[Counter] == "characteristics")
                {
                    string Charai;
                    Charai = t[Counter];
                    Lcharacte.Add(Charai);
                }
                if (list[Counter] == "saturation")
                {
                    string sati;
                    sati = t[Counter];
                    Lsaturation.Add(sati);

                }
                if (list[Counter] == "resolution")
                {
                    string resoli;
                    resoli = t[Counter];
                    Lresolution.Add(resoli);
                }
                if (list[Counter] == "aspectratio")
                {
                    string asi;
                    asi = t[Counter];
                    Laspect.Add(asi);
                }
                if (list[Counter] == "rating")
                {
                    int rati;
                    rati = Int32.Parse(t[Counter]);
                    Lrating.Add(rati);
                }
                Counter++;


            }
            filter.Tags = Ltag;
            filter.Personas = Lperson;
            filter.Characteristic = Lcharacte;
            filter.Saturation = Lsaturation;
            filter.Resolution = Lresolution;
            filter.Aspectratio = Laspect;
            filter.Rating = Lrating;

            
            return filter;
        }

    }
}
