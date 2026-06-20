using Cosmos.System.FileSystem.VFS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tinos2_legacy_edition.Commands;

namespace tinos2_legacy_edition.Fs.Commands
{
    public class Touch : Command
    {
        public Touch(string name) : base(name)
        {
        }

        public override string Execute(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Usage: touch [filename]");
                Console.WriteLine("Type 'touch help' for more information.");
            }

            VFSManager.CreateFile(args[0]);
            
            return "";
        }
    }
}
