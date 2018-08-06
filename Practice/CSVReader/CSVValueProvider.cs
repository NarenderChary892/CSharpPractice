using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.CSVReader
{
    public class CsvValueProvider
    {
        public string _filePath;
        public Dictionary<int, Dictionary<int, int>> _variableCollection;
        public CsvValueProvider(string filePath)
        {
            _filePath = filePath;
            _variableCollection = CreateDictionary();

        }
        public Dictionary<int, Dictionary<int, int>> CreateDictionary()
        {
            int variableIdFromCsv = 0;
            int valueIdFromCsv = 0;
            var filePath = _filePath;
            Dictionary<int, Dictionary<int, int>> variableCollection = new Dictionary<int, Dictionary<int, int>>();
            const Int32 bufferSize = 128;
            bool isFirstRow = true;
            int lastVariableId = -1;

            // Stores in dictionary
            using (var fileStream = File.OpenRead(filePath))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, bufferSize))
            {
                String line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    if (isFirstRow)
                    {
                        isFirstRow = false;
                    }
                    else
                    {
                        var data = line.Split(',');
                        if (!string.IsNullOrEmpty(data[0]))
                        {
                            variableIdFromCsv = Int32.Parse(data[0]);
                            lastVariableId = variableIdFromCsv;
                            if (!variableCollection.ContainsKey(variableIdFromCsv))
                            {
                                variableCollection.Add(variableIdFromCsv, new Dictionary<int, int>());
                            }
                        }
                        else
                        {
                            valueIdFromCsv = Int32.Parse(data[3]);
                            int n;
                            var value = int.TryParse(data[4], out n);
                            if (value)
                            {
                                variableCollection[lastVariableId].Add(valueIdFromCsv, n);
                            }
                        }
                    }
                }
            }
            return variableCollection;
        }

        public int GetValueName(int variableId, int valueId)
        {
            // Retruning the value
            if (_variableCollection.ContainsKey(variableId))
            {
                if (_variableCollection[variableId].ContainsKey(valueId))
                {
                    return _variableCollection[variableId][valueId];
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }
    }
}
