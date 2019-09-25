﻿using System;
using System.Collections.Generic;
using System.Text;

using System.IO;

namespace Prototype
{
    public static class WindowStatus
    {
        public static void Writer(Imagen desx)
        {

            Console.WriteLine("1 Name:"+ desx.Nombre);
            Console.WriteLine("2 Date:" + desx.Fecha);
            string s = "3 Tags: ";
            for (int t = 0; t < desx.Tags.Count; t++)
            {
                if (t == 0)
                {
                 s = s  + desx.Tags[t].Name;
                }
                else
                {
                 s = s + "," + desx.Tags[t].Name;
                }
                
            }
            Console.WriteLine(s);
            Console.WriteLine("4 Path:" + desx.Direccionmemoria);
            Console.WriteLine("Please input a key to choose again");
            Console.ReadKey();
            Console.SetCursorPosition(0, Console.CursorTop-6);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop + 1 );
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop + 1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop + 1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop + 1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop + 1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop + 1);
            
            Console.SetCursorPosition(0, Console.CursorTop - 6);

            //Console.Write(new string(' ', Console.WindowWidth));//
            //Console.Clear();//




        }
    }
}