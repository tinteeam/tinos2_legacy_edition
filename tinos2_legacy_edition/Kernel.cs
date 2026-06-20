using System;
using System.Collections.Generic;
using System.Text;
using tinos2_legacy_edition.Commands;
using Sys = Cosmos.System;
using System.Threading;

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

            String isFsLoaded = "false";
            this.fsInit = new Fs.FSInit();
            isFsLoaded = "true";

            this.commandManger = new CommandManager();
            Thread.Sleep(1000);

           if(isFsLoaded == "true")
            {
                Console.WriteLine("FS Module loaded successfully");
            } else
            {
                Console.WriteLine("WARNING!");
                Console.WriteLine("FS module failed to load, Filesystem commands will not work");
            }

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
