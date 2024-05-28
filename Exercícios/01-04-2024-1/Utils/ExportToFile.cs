using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace _01_04_2024_1.Utils
{
    public class ExportToFile
    {
        private const string dir = @"D:\Users\Samuel\Documents\Faculdade\Programação I\ProgramacaoI\Exercícios\arquivos";
        public static bool SaveToDelimitedTxt(string fileName, string fileContent)
        {
            string filePath = @$"{dir}\{fileName}";

            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            using(StreamWriter sw = File.CreateText(filePath))
            {
                sw.Write(fileContent);
            }

            return true;
        }
    }
}