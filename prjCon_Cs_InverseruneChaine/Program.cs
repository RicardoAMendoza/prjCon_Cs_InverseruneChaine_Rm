using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCon_Cs_InverseruneChaine
{
   /*
    * This project uses the following licenses:
    *  MIT License
    *  Copyright (c) 2019 Ricardo Mendoza 
    *  Montréal Québec Canada
    *  Institut Teccart
    *  www.teccart.qc.ca
    *  Hiver 2019
    */
    class Program
    {
        static void Main(string[] args)
        {
            // variable
            string xchaine = "ABCDEFG";
            Console.WriteLine("\nINVERSER UNE CHAINE", Console.ForegroundColor=ConsoleColor.Green);
            Console.WriteLine("\n\nChaine : {0}", xchaine, Console.ForegroundColor=ConsoleColor.Yellow);
            Console.WriteLine("\nInverser : {0}", fncInverserChaine(xchaine), Console.ForegroundColor=ConsoleColor.Cyan);
            Console.ReadKey();
        }

        // ---------- Inverse une chaine ---------
        // staic -> methods are methods that are called on the class itself, not on specific object instance
        // private -> the method can be acceced only by code in the same class or struct
        private static string fncInverserChaine(string source)
        {
            // StringBuilder class can be boots performance when concatenating many strings together ia a loop
            var builder = new StringBuilder();
            for (int i = source.Length - 1; i >= 0; i--)
            {
                // String.Builder.Append -> Appends information to the end of the current StringBuilder
                builder.Append(source[i]);
            }
            return builder.ToString();
        }
    }
}