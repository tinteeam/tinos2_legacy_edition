using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tinos2_legacy_edition.Commands
{
    public class Ver : Command
    {
        public Ver(string name) : base(name) { }
        public override string Execute(string[] args)
        {
            Console.WriteLine("TINOS 2 Legacy edition version 0.1 Alpha");
            return "";
        }
    }
}
