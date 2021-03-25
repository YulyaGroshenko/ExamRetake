using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SimulatorCMD
{
    class Command
    {
        public string Cmd { get; private set; }
        public string FolderName { get; private set; }
        public DirectoryInfo NewPath { get; private set; }
        public DirectoryInfo Path { get; private set; } = 
            new DirectoryInfo(Catalog.Path.Replace($"\\{Catalog.Path.Split("\\")[^1]}", ""));
        public Command(string command) => Cmd = command;
        public void RunCommand()
        {
            string[] cmdSplit = Cmd.Split(" ");
            FolderName = cmdSplit[1];
            if (Cmd.Contains("cd"))
            {              
                if (FolderName == ".")
                {                    
                    NewPath = Path;
                }
                else
                {                    
                    NewPath = new DirectoryInfo(string.Concat(Catalog.Path, "\\", FolderName));
                    Catalog.Path = NewPath.ToString();
                }
                Drawer.WriteFiles(NewPath);
                Drawer.WriteDir(NewPath);
            }
            else if (Cmd.Contains("new"))
                File.Create(FolderName);
            else if (Cmd.Contains("delete"))
                File.Delete(FolderName);
        }
    }
} 
