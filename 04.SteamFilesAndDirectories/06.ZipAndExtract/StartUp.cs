using System;
using System.IO.Compression;

namespace _06.ZipAndExtract
{
    class StartUp
    {
        static void Main()
        {
            using ZipArchive zipFile = ZipFile.Open("zipFile.zip", ZipArchiveMode.Create);
            ZipArchiveEntry zipArchiveEntry = zipFile.CreateEntryFromFile("copyMe.png", "copyMeEntry.png");
           
        }
    }
}
