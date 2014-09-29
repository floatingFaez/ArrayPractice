using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Abul", "Faez","Faiza","Badol","Rashed","Hosna"};

            #region for array 
            //for (int i = 0; i < name.Length; i++)
            //{
            //   Console.WriteLine(name[i]);
            //} 
            #endregion

            #region foreach array
            //foreach (string i in names)
            //{
            //    Console.Write(i);
            //    Console.Write(", ");
            //} 
            #endregion

            Person Faez = new Person();

            Console.WriteLine(Faez.sayHello(names));
            Console.WriteLine(Faez.sayHello("Faez","Faiza","Abul","Milon","Badol"));


            Console.WriteLine(string.Empty);
            string String = "My Name Is Abul Faez. Whats your Name, Huh?";
            char[] chararray = String.ToCharArray();
            Array.Reverse(chararray);
            Console.WriteLine(chararray);

            Console.ReadLine();

        }
    }
}
