using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _05.DirectoryTraversal
{
    class StartUp
    {
        static void Main()
        {
            string directoryPath = Directory.GetCurrentDirectory(); // вземане на текуща директория на проекта
            string[] fileNames = Directory.GetFiles(directoryPath);
            Dictionary<string, Dictionary<string, double>> filesData = new Dictionary<string, Dictionary<string, double>>();

            foreach (var fullFileName in fileNames)
            {
                FileInfo fileInfo = new FileInfo(fullFileName);

                string extension = fileInfo.Extension;
                long size = fileInfo.Length; // size v byte
                double kbSize = Math.Round(size / 1024.0, 3);                //или size / 1024.0;  // size v kByte

                if(!filesData.ContainsKey(extension))
                {
                    filesData.Add(extension, new Dictionary<string, double>());
                }

                if(!filesData[extension].ContainsKey(fullFileName))
                {

                    filesData[extension].Add(fileInfo.Name,kbSize);
                }
            }
            Dictionary<string, Dictionary<string, double>> sortedDict = filesData.OrderByDescending(kvp => kvp.Value.Count).ThenBy(kvp => kvp.Key).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            List<string> res = new List<string>();

            foreach (var item in sortedDict)
            {
                res.Add(item.Key);

                foreach (var fileData in item.Value.OrderBy(kvp =>kvp.Value))
                {
                    res.Add($"--{fileData.Key} - {fileData.Value}kb");
                }
            }
            string Filepath =Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),"report.txt");  // вземане на пътя до desktop-a

         
            File.WriteAllLines(Filepath, res);
        }
    }
}
