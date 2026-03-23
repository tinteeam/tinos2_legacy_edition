using System;
using System.Collections.Generic;
using System.Text;
using tinos2_legacy_edition.Commands;
using Sys = Cosmos.System;

namespace tinos2_legacy_edition
{
    public class Kernel : Sys.Kernel
    {

        private CommandManager commandManger;

        protected override void BeforeRun()
        {
            this.commandManger = new CommandManager();
            Console.WriteLine("Welcome to TINOS 2 Legacy edition");
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
