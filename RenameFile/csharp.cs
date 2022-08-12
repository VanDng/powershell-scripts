using System;
using System.IO;

namespace MyScriptSpace
{
    public static class MyScriptMain
    {
        public static void Main(string[] args)
        {
            string dir = args[0];
            string searchString = args[1];
            string replaceString = args[2];
            string pattern = args[3];
            string isRecursive = args[4];

            string[] filePaths = Directory.GetFiles(
                dir,
                pattern,
                isRecursive == "1" ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly
            );

            foreach(string filePath in filePaths)
            {
                if (!filePath.Contains(searchString)) continue;

                Console.WriteLine(filePath);

                FileInfo fileInfo = new FileInfo(filePath);

                string newFilePath = 
                    fileInfo.DirectoryName
                     + "\\"
                     + fileInfo.Name.Replace(searchString, replaceString); 

                fileInfo.MoveTo(newFilePath);
            }
        }
    }
}