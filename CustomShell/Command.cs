using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CustomShell
{
    class Command : Program
    {
        public void StartCommand()
        {
            var help = new Help();
            help.ExecuteCommand();
            Console.WriteLine("insert a command");
            string command = Console.ReadLine();
            switch (command.ToLower())
            {
                case "help":
                    help.ExecuteCommand();
                    break;
                case "dir":
                    var dir = new GetFilesName();
                    dir.ExecuteCommand();
                    break;
                case "ls":
                    var ls = new CurrentDir();
                    ls.ExecuteCommand();
                    break;
                case "cd":
                    var cd = new GetDirectory();
                    cd.ExecuteCommand();
                    break;
                case "del":
                    var del = new DeleteFile();
                    del.ExecuteCommand();
                    break;
                case "find":
                    var find = new GetDirectories();
                    find.ExecuteCommand();
                    break;
                case "exit":
                    var program = new Program();
                    program.CloseProgram();
                    break;
                case "quit":
                    var program2 = new Program();
                    program2.CloseProgram();
                    break;
                default:
                    Console.WriteLine("");
                    break;
            }
            

        }

       virtual public void ExecuteCommand()
        {

            Console.WriteLine("insert pathName");
        }
    }
}
