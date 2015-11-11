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
            string sourceBaseDirectory = @"";
            string targetBaseDirectory = @"";
           

            if (!Directory.Exists(targetBaseDirectory))
                Directory.CreateDirectory(targetBaseDirectory);

            BackupTool bt = new BackupTool();
            Console.WriteLine("=== COPYING FILES ===");
            bt.RecursiveCopy(sourceBaseDirectory, targetBaseDirectory);

            bt.Report();
        }
    }
}
