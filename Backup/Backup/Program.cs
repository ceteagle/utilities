using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backup
{
    class Program
    {
        static void Main(string[] args)
        {

           

            if (!Directory.Exists(targetBaseDirectory))
                Directory.CreateDirectory(targetBaseDirectory);

            BackupTool bt = new BackupTool();
            Console.WriteLine("=== BACKING UP PICTURES ===");
            bt.RecursiveCopy(sourceBaseDirectory, targetBaseDirectory);

            Console.WriteLine("\n=== BACKING UP VIDEOS ===");
            
            bt.RecursiveCopy(sourceBaseDirectory, targetBaseDirectory);

            bt.Report();
        }
    }
}
