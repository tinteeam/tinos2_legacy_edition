using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tinos2_legacy_edition.Commands
{
    public class Clear : Command
    {
        public Clear(String name) : base(name) { }
        public override string Execute(string[] args)
        {
            Console.Clear();
            return "";
        }
    }
}
