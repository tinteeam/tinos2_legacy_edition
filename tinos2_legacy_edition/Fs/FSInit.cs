using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sysfs = Cosmos.System.FileSystem;
using Cosmos.System.FileSystem.VFS;
using Cosmos.System.FileSystem;
using System.Threading;
using System.Runtime.CompilerServices;

namespace tinos2_legacy_edition.Fs
{
    public class FSInit
    {
        static CosmosVFS vfs = new CosmosVFS();
         

        public void Init()
        {
            
            Console.WriteLine("Initializing File System Module, Please Wait...");
            Thread.Sleep(1000);
            VFSManager.RegisterVFS(vfs);
            
            Console.WriteLine("File System Module Initialized Successfully");

        }
    }
}
