
using System.Collections.Generic;
using System.IO;
using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing;
using System.Text;

namespace Prototype
{
    class Menu
    {
        //static List<Character> characters;//
        static List<string> options = new List<string>()
        {
            "See Directory",
            "Import",
            "Editor",
            "Search",
            "SlideShow",
            "Exit"
        };
        static void Main()
        {
            // Check for previous data
            /*if (!LoadData())
            {
                IOUser.ConsoleOutput("No previous data");
                characters = new List<Character>();
            }
            else
            {
                IOUser.ConsoleOutput("Characters loaded...");
            }
            */
            int option = -1;

            string[] edit = new string[7];
            edit[0] = "Add Tag";
            edit[1] = "Add Text";
            edit[2] = "Add Rating";
            edit[3] = "Add Filter";
            edit[4] = "Make Fusion";
            edit[5] = "Make Mosaic";
            edit[6] = "Make Collage";

            while (option != options.Count - 1)
            {
                IOUser.ConsoleListOutput("Please select one option", options);
                option = IOUser.ConsoleReadInput();
                switch (option)
                {
                    case 0:
                        IOUser.ConsoleOutput("The images on the directory are as follows:");
                        string imageP = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\image";
                        string[] dir = Directory.GetFiles(imageP);
                        
                        foreach (string d in dir)
                        {
                            Console.WriteLine(d);
                        }
                        break;
                    case 1:
                        string imageS = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\image";
                        Imagen temp3 = new Imagen();
                        Console.WriteLine("Please input the image path to import:");
                        string r = Console.ReadLine();
                        if (File.Exists(r))
                        {
                            string j = Path.GetExtension(r);
                            if (j!=".png" & j != ".jpeg" & j != ".bmp" & j != ".jpg")
                            {
                                IOUser.ConsoleOutput("invalid file type");
                                break;
                            }
                        }
                        else
                        {
                            IOUser.ConsoleOutput("invalid path,please input again");
                            break;
                        }
                        Image temp = Image.FromFile(r);

                        string t = Path.GetFileName(r);
                        /*Console.WriteLine(t);
                        foreach(int p in temp.PropertyIdList)
                        {
                            Console.WriteLine(p);
                        }
                        */
                        temp.Save(imageS + @"\"+t);
                        Image temp2 = Image.FromFile(imageS + @"\" + t);
                        temp3.Image = temp2;
                        tag geno = new tag();
                        geno.Name = "importado1";
                        List<tag> gen = new List<tag>();
                        gen.Add(geno);
                        temp3.Tags = gen;



                        IOUser.ConsoleOutput("the file: " + t + " has been imported");
                        Console.WriteLine(temp3.Tags[0].Name);
                        



                        break;
                    case 2:
                        string imageT = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\image";
                        string[] dirt = Directory.GetFiles(imageT);
                    

                        IOUser.ConsoleListOutput2("Please select the image to edit on", dirt);
                        int choice = IOUser.ConsoleReadInput();
                        for (int g=0;g<dirt.Length;g++)
                        {
                            if (g == choice)
                            {
                                string h = Path.GetFileName(dirt[g]);
                                Console.WriteLine("the file: " +h+ " has been selected" );
                                
                                IOUser.ConsoleListOutput2("what edition would you like to make to " + h + " ?", edit);



                            }

                        }


                        /*string s = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../Files/Characters.txt");
                        StreamReader reader = new StreamReader(s);

                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            string[] characterParams = line.Split(',');
                            switch (characterParams[0])
                            {
                                case "Warrior":
                                    characters.Add(new Warrior(characterParams[1], int.Parse(characterParams[2])));
                                    break;
                                case "Knight":
                                    characters.Add(new Knight(characterParams[1], int.Parse(characterParams[2])));
                                    break;
                                case "Assassin":
                                    characters.Add(new Assassin(characterParams[1], int.Parse(characterParams[2])));
                                    break;
                                case "Mage":
                                    characters.Add(new Mage(characterParams[1], int.Parse(characterParams[2])));
                                    break;
                                case "Druid":
                                    characters.Add(new Druid(characterParams[1], int.Parse(characterParams[2])));
                                    break;
                                case "Necromancer":
                                    characters.Add(new Necromancer(characterParams[1], int.Parse(characterParams[2])));
                                    break;
                                default:
                                    break;
                            }
                        }
                        foreach (Character character in characters)
                        {
                            System.Console.WriteLine($"Character class: {character.GetType().Name}, Character Name: {character.Name}");
                        }*/
                        break;
                    case 3:
                        /*foreach (Character character in characters)
                        {
                            System.Console.WriteLine($"Character class: {character.GetType().Name}, Character Name: {character.Name}");
                        }*/
                        break;
                    case 4:
                        //characters.Add(new Warrior());//
                        break;
                    default:
                        //SaveData();//
                        break;
                }
            }
        }

        /*static void changeWarriorName(Warrior warrior)
        {
            //Al ser por referencia, el parametro cambiara el valor del guerrero que se encuentra en el main.
            warrior.Name = "Phil";
        }*/

        static int PlusOne(int number)
        {
            return number + 1;
        }

        /*private static void SaveData()
        {
            // Creamos el Stream donde guardaremos nuestros personajes
            String fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../Characters.txt");
            FileStream fs = new FileStream(fileName, FileMode.Create);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, characters);
            fs.Close();
        }

        private static Boolean LoadData()
        {
            String fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../Characters.txt");
            if (!File.Exists(fileName))
            {
                return false;
            }
            FileStream fs = new FileStream(fileName, FileMode.Open);
            IFormatter formatter = new BinaryFormatter();
            characters = formatter.Deserialize(fs) as List<Character>;
            fs.Close();
            return true;
        }*/
    }
}
