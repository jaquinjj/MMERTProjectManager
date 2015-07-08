using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Oku
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            string text = System.IO.File.ReadAllText("Oku.cs");
            
            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}
