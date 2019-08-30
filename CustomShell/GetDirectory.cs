using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace CustomShell
{
    class GetDirectory : Command
    {
        public override void ExecuteCommand()
        {

            Console.WriteLine(System.IO.Directory.GetParent(System.IO.Directory.GetParent(System.IO.Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString()).ToString());
        }
    }
}
