using System;
using System.Collections.Generic;
using System.IO;

namespace SimulatorCMD
{
    class Program
    {
        static void Main()
        {
            Drawer.WriteFiles(Catalog.Dir);
            Drawer.WriteDir(Catalog.Dir);
            while (true)
            {
                string command = Console.ReadLine();
                Command cmd = new Command(command);
                cmd.RunCommand();
            }
        }
    }
}
