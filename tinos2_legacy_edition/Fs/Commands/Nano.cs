using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tinos2_legacy_edition.Commands;


namespace tinos2_legacy_edition.Fs.Commands
{
    public class Nano : Command
    {


        public Nano(string name) : base(name)
        {
        }

        public override string Execute(string[] args)
        {
            tinos2_legacy_edition.Applications.Utilities.Nano.Nano.Edit();
            return "";
        }
    }
}
