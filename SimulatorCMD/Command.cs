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
                    NewPath = new DirectoryInfo(string.Concat(Path, "\\", FolderName));
                    Path = new DirectoryInfo(Catalog.Path);
                }
                Drawer.WriteFiles(NewPath);
                Drawer.WriteDir(NewPath);
            }
            else if (Cmd.Contains("new"))
                File.Create(FolderName);
            else
                File.Delete(FolderName);
        }
    }
}
//D:\ExamRetake\SimulatorCMD\bin\Debug\netcoreapp3.1
//D:\ExamRetake\SimulatorCMD\bin\Debug
//D:\ExamRetake\SimulatorCMD\bin\Debug\netcoreapp3.1
//D:\ExamRetake\SimulatorCMD\bin\Debug\Folder1         ->             D:\ExamRetake\SimulatorCMD\bin\Debug\netcoreapp3.1\Folder1      
