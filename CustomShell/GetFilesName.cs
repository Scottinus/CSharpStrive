using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace CustomShell
{
    class GetFilesName : Command
    {


        public override void ExecuteCommand()
        {
            Console.WriteLine("insert the path folder");
           string newPath = Console.ReadLine();
           // string newPath = @"C:\Users\Scott\Desktop\C#\CustomShell\CustomShell";
            //EX 1 print filenames in a directory
            string[] pathFiles = Directory.GetFiles(newPath);

            for(int i = 0; i <= pathFiles.Length; i++)
            {
                string path = pathFiles[i];
                Console.WriteLine(System.IO.Path.GetFileName(path));

        }
            }

}
}
