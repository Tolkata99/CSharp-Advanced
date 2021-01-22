using System;
using System.IO;

namespace CopyMe
{
    class Program
    {
        static void Main(string[] args)
        {

            using (FileStream reader = new FileStream("../../../CopyMe.png", FileMode.Open))
            {
                using (FileStream writer = new FileStream("../../../neswFile.png", FileMode.Create))
                {
                    byte[] buffer = new byte[500];

                    while (reader.CanRead)
                    {
                        int bytesRead = reader.Read(buffer, 0, buffer.Length);

                        if(bytesRead == 0)
                        {
                            break;
                        }

                        writer.Write(buffer, 0, buffer.Length);
                    }
                }
            }
        }
    }
}
