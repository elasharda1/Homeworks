﻿using System;
using System.IO;

class CopyBinaryFile
{
    static void Main()
    {
        string ImagePath = "../../image.jpg";
        string copyPath = "../../result.jpg";
        using (var source = new FileStream(ImagePath, FileMode.Open))
        {
            using (var destination = new FileStream(copyPath, FileMode.Create))
            {
                byte[] buffer = new byte[4096];
                while (true)
                {
                    int readBytes = source.Read(buffer, 0, buffer.Length);
                    if (readBytes == 0)
                    {
                        break;
                    }

                    destination.Write(buffer, 0, readBytes);
                }
            }
        }

       
    }
}