using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SimulatorCMD
{
    static class Drawer
    {
        static public void WriteFiles(DirectoryInfo path)
        {
            foreach (FileInfo file in path.GetFiles())
            {
                Console.WriteLine(file.Name);
            }
        }
        static public void WriteDir(DirectoryInfo path)
        {
            foreach (DirectoryInfo dir in path.GetDirectories())
            {
                Console.WriteLine(dir.Name);
            }
        }
    }
}
