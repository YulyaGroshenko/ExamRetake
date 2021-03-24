using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SimulatorCMD
{
    static class Catalog
    {
        static public string Path { get; set; }
        static public DirectoryInfo Dir { get; private set; }
        static Catalog()
        {
            Path = Environment.CurrentDirectory;
            Dir = new DirectoryInfo(Path);
        }
    }    
}
