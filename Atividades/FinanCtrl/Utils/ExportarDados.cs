using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using FinanCtrl.Data;
using FinanCtrl.Models;

namespace FinanCtrl.Utils
{
    public class ExportarDados
    {
        public void Export()
        {
            StreamWriter Export = File.AppendText(@"D:\Users\Samuel\Documents\Faculdade\Programação I\ProgramacaoI\Atividades\FinanCtrl\Arquivos\lucro.txt");

            foreach (Lucro lucro in DataSet.lucros)
            {
                Export.WriteLine(lucro.ToString());
            }
            
            Export.Close();
        }
    }
}