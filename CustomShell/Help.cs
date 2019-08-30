using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CustomShell
{
    class Help: Command
    {
        public override void ExecuteCommand()
        {

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Scott\Desktop\C#\CustomShell\CustomShell\Help.txt");
            System.Console.WriteLine("------ Command List ------");
            foreach (string line in lines)
            {
                Console.WriteLine("\t" + line);
            }
        }

    }
}
