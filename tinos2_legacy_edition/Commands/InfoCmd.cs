using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tinos2_legacy_edition.Commands
{
    public class InfoCmd : Command
    {
        public InfoCmd(string name) : base(name) { }

        public override string Execute(string[] args)
        {
            Console.WriteLine("TINOS 2 Legacy edition is a legacy build for tin os lineup.\n");
            Console.WriteLine("Source code is based off of TINOS version 2 (also known as tinos2)");
            return "";
        }
    }
}
