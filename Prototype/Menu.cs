
using System.Collections.Generic;
using System.IO;
using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing;
using System.Text;
using System.Xml;


namespace Prototype
{
    class Menu
    {
        
        static List<string> options = new List<string>()
        {
            "See Directory",
            "Import",
            "Editor",
            "Search",
            "SlideShow",
            "Exit"
        };
        static List<string> SPaths = new List<string>();
        static List<Imagen> BDE = new List<Imagen>();
        static List<Buscador> SmartSearch = new List<Buscador>();
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

            //Lista Ediciones
            string[] edit = new string[7];
            edit[0] = "Add Tag";
            edit[1] = "Add Text";
            edit[2] = "Add Rating";
            edit[3] = "Add Filter";
            edit[4] = "Make Fusion";
            edit[5] = "Make Mosaic";
            edit[6] = "Make Collage";

            //Lista Filtros
            string[] filters = new string[4];
            filters[0] = "Trasparent";
            filters[1] = "Black and White";
            filters[2] = "Sepia";
            filters[3] = "Negative";


            string[] SearchE = new string[2];
            SearchE[0] = "Normal Search";
            SearchE[1] = "Special Search";


            string[] SearchF = new string[7];
            SearchF[0] = "By Tag";

            SearchF[1] = "By People";
            SearchF[2] = "By People Characteristic";
            SearchF[3] = "By Saturation";
            SearchF[4] = "By Resolution";
            SearchF[5] = "By resolution ratio";
            SearchF[6] = "By rating";

            string[] SearchD = new string[7];
            SearchD[0] = "tags";

            SearchD[1] = "people";
            SearchD[2] = "characteristics";
            SearchD[3] = "saturation";
            SearchD[4] = "resolution";
            SearchD[5] = "aspectratio";
            SearchD[6] = "rating";


            string imageST = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\image";
            string[] diro = Directory.GetFiles(imageST);
            int counter = 0;
            foreach (string di in diro)
            {
                Imagen tempo = new Imagen();
                tag testo = new tag();
                tag testo4 = new tag();
                List<tag> testo2 = new List<tag>();
                testo.Name = "prueba";
                testo4.Name = "prueba2";
                testo2.Add(testo);
                testo2.Add(testo4);
                tempo.Image = Image.FromFile(di);
                tempo.Nombre = Path.GetFileName(di);
                tempo.Direccionmemoria = di;
                tempo.Tags = testo2;
                tempo.Id = counter;
                tempo.Fecha = "25/09/2019";
                counter++;





                /*char[] spearator = { ',' };
                
                String[] strlist = tempo.Nombre.Split(spearator,2, StringSplitOptions.None);

                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(strlist[0]+".bin", FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, tempo);
                stream.Close();*/
                SPaths.Add(di);
                BDE.Add(tempo);


            }
            
            
            




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
                        List<String> BDEl = new List<string>();
                      
                        for (int cu=0; cu < SPaths.Count;cu++)
                        {
                            BDEl.Add(SPaths[cu]);
                        }

                        
                        
                        foreach (string d in dir)
                        {
                            Console.WriteLine(d);
                        }
                        IOUser.ConsoleListOutput4("please choose the one you want details on:", BDEl);
                        int u=0;
                        while (u<BDEl.Count)
                        {
                            u = IOUser.ConsoleReadInput();
                            for (int l = 0; l < dir.Length; l++)
                            {
                                if (l == u)
                                {
                                    
                                    WindowStatus.Writer(BDE[u]);

                                }

                            }
                        }
                        
                        //WindowStatus.Writer();//
                        break;
                    case 1:
                        
                        
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
                        
                        Imagen temp3= Importador.Tagger(Importador.import(r));
                        //Image temp = Image.FromFile(r);//

                        //string t = Path.GetFileName(r);//
                        /*Console.WriteLine(t);
                        foreach(int p in temp.PropertyIdList)
                        {
                            Console.WriteLine(p);
                        }
                        */




                        SPaths.Add(r);
                        string s = Path.GetFileName(r);
                        IOUser.ConsoleOutput("the file: " + s + " has been imported");
                        Console.WriteLine(temp3.Tags[0].Name);
                        BDE.Add(temp3);
                        //WindowStatus.Writer(BDE[0]);//
                        



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
                                
                                IOUser.ConsoleListOutput3("what edition would you like to make to " + h + " ?", edit);
                                int editionChoice=0;
                                while (editionChoice < edit.Length)
                                {
                                    editionChoice = IOUser.ConsoleReadInput();
                                    switch (editionChoice)
                                    {
                                        case 0:
                                            Console.WriteLine("please input the tag you wish to add to " + h);
                                            Imagen imag = BDE[g];
                                            string t = IOUser.ConsoleReadInputs();
                                            Retoque.AddTag(imag, t);
                                            Console.WriteLine("Tag:"+ t +"has been added to" +h);
                                            Console.WriteLine("you can make another edition on" + h + "or you can choose (7) exit");
                                            break;

                                        case 1:
                                            Console.WriteLine("please input the text you like to add to " + h);
                                            Imagen imag1 = BDE[g];
                                            string t1 = IOUser.ConsoleReadInputs();
                                            Retoque.AddText(imag1, t1, 50, 50);
                                            Console.WriteLine("Text:" + t1 + "has been added to" + h);
                                            Console.WriteLine("you can make another edition on" +h+"or you can choose (7) exit");
                                            break;

                                        case 2:
                                            Console.WriteLine("please input a score between 0 to 5 for " + h);
                                            Imagen imag2 = BDE[g];
                                            int t2 = IOUser.ConsoleReadInput();
                                            while (t2 < 0 || t2 > 5)
                                            {
                                                Console.WriteLine("You enter an invalid rating");
                                                Console.WriteLine("Please enter a number between 0 to 5");
                                                t2 = IOUser.ConsoleReadInput();
                                            }
                                            Retoque.AddRanking(imag2, t2);
                                            Console.WriteLine(h + " has now a score of " + t2);
                                            Console.WriteLine("you can make another edition on" + h + "or you can choose (7) exit");
                                            break;

                                        case 3:
                                            Image imag3 = BDE[g].Image;
                                            string imagePath = BDE[g].Direccionmemoria;
                                            IOUser.ConsoleListOutput2("what filter would you like to add to " + h + " ?", filters);
                                            int filterChoice = IOUser.ConsoleReadInput();
                                            Retoque.AddFilter(imag3, imagePath, filterChoice);
                                            Console.WriteLine("Filter:" + filters[filterChoice] + "has been aplied to" + h);
                                            Console.WriteLine("you can make another edition on" + h + "or you can choose (7) exit");
                                            break;

                                        case 4:
                                            Image imag4 = BDE[g].Image;
                                            string imagePath1 = BDE[g].Direccionmemoria;
                                            List<Imagen> BDE2 = new List<Imagen>();
                                            foreach (var imagen in BDE)
                                            {
                                                BDE2.Add(imagen);
                                            }
                                            BDE2.RemoveAt(g);
                                            IOUser.ConsoleListOutput5("with what photo would you like you like to fusion " + h + " with?", BDE2);
                                            int Selected = IOUser.ConsoleReadInput();
                                            Image imag5 = BDE2[Selected].Image;
                                            string imagePath2 = BDE2[Selected].Direccionmemoria;
                                            string h1 = BDE2[Selected].Nombre;
                                            ProduccionImagen.MakeFusion(imag4, imag5, imagePath1, imagePath2);
                                            Console.WriteLine("You have successfully fusioned '" + h + "' with '" + h1 + "'");
                                            Console.WriteLine("you can make another edition on " + h + "or you can choose (7) exit");
                                            break;


                                    }
                                }



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
                        IOUser.ConsoleListOutput2("Please select the type of search you'd like to use:", SearchE);
                        int choice4 = 2;
                        while (choice4 != 0 & choice4 != 1)
                        {
                            choice4 = IOUser.ConsoleReadInput();
                            switch (choice4)

                            {
                                case 0:
                                    IOUser.ConsoleListOutput3("Please Select the filters You'd like for the search", SearchF);
                                    string searchI = "Note that for multiple filters you have to use the , separator between your input";
                                    Console.WriteLine(searchI);
                                    string inputs = IOUser.ConsoleReadInputs();
                                    List<int> sinputs = IOUser.SearchParse(inputs);

                                    List<Filtros> Lfiltros = new List<Filtros>();
                                    Buscador Searchi = new Buscador();
                                    Filtros Nfilter = new Filtros();
                                    List<string> st = new List<string>();


                                    for (int it = 0; it < SearchF.Length; it++)
                                    {
                                        for (int ito = 0; ito < sinputs.Count; ito++)
                                        {

                                            if (SearchD[it] == SearchD[sinputs[ito]])
                                            {


                                                if (SearchD[it] == "tags")
                                                {
                                                    st.Add("tags");
                                                }
                                                if (SearchD[it] == "people")
                                                {
                                                    st.Add("people");
                                                }
                                                if (SearchD[it] == "characteristics")
                                                {
                                                    st.Add("characteristics");
                                                }
                                                if (SearchD[it] == "saturation")
                                                {
                                                    st.Add("saturation");
                                                }
                                                if (SearchD[it] == "resolution")
                                                {
                                                    st.Add("resolution");
                                                }
                                                if (SearchD[it] == "aspectratio")
                                                {
                                                    st.Add("aspectratio");
                                                }
                                                if (SearchD[it] == "rating")
                                                {
                                                    st.Add("rating");
                                                }


                                            }
                                        }


                                    }
                                    Nfilter.Filters = st;
                                    Lfiltros.Add(Nfilter);
                                    Searchi.Filtros = Lfiltros;
                                    Searchi.Searchterm = inputs;

                                    Console.WriteLine("please input the" + WindowStatus.ShowSearch(Searchi.Filtros[0].Filters) + "you'd like to search(use the/ separator in each one):");


                                    SmartSearch.Add(Searchi);
                                    break;
                                case 1:

                                    break;
                                default:
                                    IOUser.ConsoleError("input must be within range");
                                    break;
                            }
                        }
                        break;
                    case 4:
                        IOUser.ConsoleOutput("SlideShow Option hasnt been implemented yet please choose another option");
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
