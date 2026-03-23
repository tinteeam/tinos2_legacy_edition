using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmos.System;

namespace tinos2_legacy_edition.Commands
{
    public class Shutdown : Command
    {
        public Shutdown(string name) : base(name)
        {
        }

        public override string Execute(string[] args)
        {
            Power.Shutdown();
            return "";
        }
    }
}
