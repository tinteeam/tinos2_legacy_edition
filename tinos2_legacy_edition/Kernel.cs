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

        protected override void BeforeRun()
        {
            Console.Clear();
            Thread.Sleep(1000);
            Console.WriteLine("loading Command Manager, Please wait...");
            Thread.Sleep(1000);
            this.commandManger = new CommandManager();
            Thread.Sleep(1000);
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
