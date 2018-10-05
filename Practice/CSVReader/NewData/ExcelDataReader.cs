using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.CSVReader.NewData
{
    class ExcelDataReader
    {
        public void GetExcelData()
        { 
            string filePath =( @"C:\Users\Operations01\Documents\CLASSIC350.xls");
            Dictionary<int, List<VarProperties>> dataDict = new Dictionary<int, List<VarProperties>>();
            int variableNameFromCsv;
             
            int lastVariableId = -1;
            const Int32 bufferSize = 128;
            bool IsFirstRow = true;
            bool IsSecondRow = true;
            bool IsThirdRow = true;

            using (var fileStream = File.OpenRead(filePath))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, bufferSize))
            {
                String line;
                while((line = streamReader.ReadLine()) != null)
                {
                    if(IsFirstRow && IsSecondRow && IsThirdRow)
                    {
                        IsFirstRow = false;
                        IsSecondRow = false;
                        IsThirdRow = false;
                    }
                    else
                    {
                        var data = line.Split(',');
                        if (!string.IsNullOrEmpty(data[6]))
                        {
                            variableNameFromCsv = Int32.Parse(data[6]);
                            lastVariableId = variableNameFromCsv;
                            if (!dataDict.ContainsKey(variableNameFromCsv))
                            {
                                dataDict.Add(variableNameFromCsv, new List<VarProperties>());
                            }
                        }
                        else
                        {
                            List<VarProperties> newList = new List<VarProperties>();
                           
                            //newList.Add(Int32.TryParse(data[1]));
                            //valuesFromCsv = Int32.Parse(data[3]);
                            //int n;
                            //var value = int.TryParse(data[4], out n);
                            //if (value)
                            //{
                            //    variableCollection[lastVariableId].Add(valueIdFromCsv, n);
                            //}
                        }
                    }
                }
            }
        }
    }

   
}
