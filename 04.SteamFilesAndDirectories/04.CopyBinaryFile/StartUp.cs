using System;
using System.IO;

namespace _04.CopyBinaryFile
{
    class StartUp
    {
        static void Main()
        {

            FileStream readStream = new FileStream("copyMe.png", FileMode.Open);

            using FileStream writeStream = new FileStream("newImage.png", FileMode.Create);

            while (readStream.Position < readStream.Length)   // да го спрем, когато currentPosition =  readStream.Length
            {
                byte[] buffer = new byte[4096];
                int count = readStream.Read(buffer, 0, buffer.Length);  //  четем от буфера, започвайки от нула на буфера до размера на буффера Count- is size of ReadNow

               // if (count == 0)      Работи също
               // {
               //     break;
              //  }

                writeStream.Write(buffer); // записваме 4096 байт-а от copyMe.png   в  newImage.png
            }
            
        }
    }
}
