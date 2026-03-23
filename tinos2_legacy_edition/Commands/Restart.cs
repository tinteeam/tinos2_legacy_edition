using Cosmos.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tinos2_legacy_edition.Commands
{
    public class Restart : Command
    {
        public Restart(string name) : base(name)
        {
        }

        public override string Execute(string[] args)
        {
            Power.Reboot();
            return "";
        }
    }
}
