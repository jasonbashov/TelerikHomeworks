﻿using System;
using System.Linq;

namespace CohesionAndCoupling
{
    class File
    {
        public static string GetFileExtension(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                return "";
            }

            string extension = fileName.Substring(indexOfLastDot + 1);
            return extension;
        }

        public static string GetFileNameWithoutExtension(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                return fileName;
            }

            string fileNameWithoutExtension = fileName.Substring(0, indexOfLastDot);
            return fileNameWithoutExtension;
        }
    }
}
