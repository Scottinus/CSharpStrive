using System;


namespace CustomShell
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = true;
            while (check == true)
            {
                Console.WriteLine();
                var executeCommand = new Command();
                executeCommand.StartCommand();

            }


        }
        virtual public void CloseProgram()
        {
            Environment.Exit(-1);
        }
    }
}
