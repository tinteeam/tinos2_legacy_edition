using System;
using System.Collections.Generic;
using System.Text;
using tinos2_legacy_edition.Commands;
using Sys = Cosmos.System;
using System.Threading;
using Cosmos.System.FileSystem.VFS;

namespace tinos2_legacy_edition
{
    public class Kernel : Sys.Kernel
    {

        private CommandManager commandManger;
        private Fs.FSInit fsInit;

        protected override void BeforeRun()
        {
            // Clear screen and wait for 1 second
            Console.Clear();
            Thread.Sleep(1000);

            //Start loading modules
            Console.WriteLine("loading System Modules, Please wait...");
            Thread.Sleep(1000);

           
            this.fsInit = new Fs.FSInit();
            this.fsInit.Init();
            

            this.commandManger = new CommandManager();
            Thread.Sleep(1000);


            Console.WriteLine("Running vfs tests");

            Console.WriteLine("Testing VFS...");

            try
            {
                var disks = VFSManager.GetDisks();
                Console.WriteLine("Disk count: " + disks.Count);
            }
            catch (Exception ex)
            {
                Console.WriteLine("VFS test failed!");
                Console.WriteLine(ex.Message);
            }

            Thread.Sleep(1000);
            Console.Clear();
            Thread.Sleep(1000);

            // Load the system to be ready for use
            Console.WriteLine("Welcome to TINOS 2 Legacy edition");
            Console.WriteLine("Loaded successfully, type 'help' for a list of commands");
        }

        protected override void Run()
        {
            string response;
            Console.Write(">");

            response = this.commandManger.ProcessInput(Console.ReadLine());



            Console.WriteLine(response);
        }
    }
}
