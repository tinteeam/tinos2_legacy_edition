using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tinos2_legacy_edition.Commands;

namespace tinos2_legacy_edition.Fs.Commands
{
    public class Format : Command
    {
        public Format(string name) : base(name)
        {
        }

        public override string Execute(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Usage: format [drive]");
                Console.WriteLine("Type 'format help' for more information.");
            }
            if (args[0] == "help")
            {
                Console.WriteLine("Usage: format [drive]");
                Console.WriteLine();

                Console.WriteLine("help - Displays this help message");
                Console.WriteLine("drive - The drive to format (e.g. 0:)");
                Console.WriteLine();

                Console.WriteLine("Formats the specified drive, erasing all data on it. Use with caution!");
            }

            return "";
        }
    }
}
