using Cosmos.System.FileSystem;
using Cosmos.System.FileSystem.VFS;
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
            Console.WriteLine("Welcome to guided Formatting utility");

            var drives = VFSManager.GetDisks();
            Console.WriteLine("Found the following drives: " + drives.Count);

            while (true)
            {
                Console.WriteLine("Please enter the drive you want to format (e.g. 0:)");
                var input = Console.ReadLine();

                if (input == "0:")
                {
                    // Assuming the first disk in the list corresponds to "0:"
                    if (drives.Count > 0)
                    {
                        var blockDevice = drives[0].Host; // Access the Host property of the Disk object
                        if (blockDevice != null)
                        {
                            Disk disk = new(blockDevice);
                            Console.WriteLine("Formatting drive.....");
                            disk.FormatPartition(0, "FAT", true);
                        }
                        else
                        {
                            Console.WriteLine("Invalid drive specified.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No drives available to format.");
                    }
                }

                if (input == "exit")
                {
                    break;
                }

                
            }

            return "";
            
        }
    }
}
