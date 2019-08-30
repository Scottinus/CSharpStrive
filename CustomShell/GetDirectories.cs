using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CustomShell
{
    class GetDirectories : Command
    {
        public override void ExecuteCommand()
        {
            string[] filePaths = Directory.GetFiles(@"c:\MyDir\", "*.bmp",
                                           SearchOption.AllDirectories);

        }

    }
}
