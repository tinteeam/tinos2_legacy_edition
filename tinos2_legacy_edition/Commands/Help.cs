using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tinos2_legacy_edition.Commands
{
    public class Help : Command
    {
        public Help(string name) : base(name) { }
        public override string Execute(string[] args)
        {
            Console.WriteLine("Available commands:");
            Console.WriteLine("- help: Displays this help message.");
            Console.WriteLine("- info: Provides information about TINOS 2 Legacy edition.");
            Console.WriteLine("- ver: Displays the version of TINOS 2 Legacy edition.");
            return "";
        }
    
    }
}
