using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CustomShell
{
    class CurrentDir : Command
    {
        public bool execution = true;
            //EX 2 print filenames in a directory
        public override void ExecuteCommand()
        {
            string newPath = System.IO.Directory.GetParent(System.IO.Directory.GetParent(System.IO.Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString()).ToString();
            string[] pathFiles = Directory.GetFiles(newPath);

            foreach(string files in pathFiles)
            {
                Console.WriteLine(System.IO.Path.GetFileName(files));

            }

        }

        
    }
}
