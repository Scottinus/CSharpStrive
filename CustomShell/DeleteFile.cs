using System;
using System.IO;
namespace CustomShell
{
    class DeleteFile : Command
    {
        // Default folder
        public override void ExecuteCommand()
        {
            // Files to be deleted
            Console.WriteLine("Insert the path of directory: ");
            string rootFolder =Console.ReadLine();
            Console.WriteLine("insert name of file: ");
            string authorsFile = Console.ReadLine();
            try
            {
                // Check if file exists with its full path
                if (File.Exists(Path.Combine(rootFolder, authorsFile)))
                {
                    // If file found, delete it
                    File.Delete(Path.Combine(rootFolder, authorsFile));
                    Console.WriteLine("File deleted.");
                }
                else Console.WriteLine("File not found");
            }
            catch (IOException ioExp)
            {
                Console.WriteLine(ioExp.Message);
            }
            Console.ReadKey();
        }

    }
}