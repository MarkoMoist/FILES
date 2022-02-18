using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateLOGitpe21
{
    class Program
    {
        static void Main(string[] args)
        {
          
            string newDirectory = "LOGITpe21";
            CreateMyDirectory(newDirectory);
        } 
        
        private static void CreateMyDirectory(string myDirectoryName)
        {
            string rootDirectory = @"C:\Users\marko\Samples";
            string directoryFullPath = $@"{rootDirectory}/{myDirectoryName}";
        
          if (Directory.Exists(directoryFullPath))
            {
                Console.WriteLine($"Directory {myDirectoryName} already exsists in {rootDirectory}.");
            }
            else
            {
                Directory.CreateDirectory(directoryFullPath);
                Console.WriteLine($"Directory {myDirectoryName} has been created.");
            }
        
        
        
        }
    }
}
