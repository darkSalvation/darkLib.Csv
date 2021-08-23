using System;
using System.Collections.Generic;
using System.IO;

namespace darkLib.Csv
{
    public sealed class CsvParser
    {
        private readonly char _delimiter;

        public CsvParser(Char delimiter)
        {
            _delimiter = delimiter;
        }

        public List<T> Parse<T>(string input) where T : new()
        {
            var reader = new StringReader(input);
            var line = string.Empty;


            List<T> result = new List<T>();

            while ((line = reader.ReadLine()) != null)
            {
                T entity = new T();
                int position = 0;
                foreach (var item in line.Split(_delimiter))
                {
                    switch (position++)
                    {
                        case 0:
                            typeof(T).GetProperty("Firstname").SetValue(entity, item);
                            break;
                        case 1:
                            typeof(T).GetProperty("Lastname").SetValue(entity, item);
                            break;
                        case 2:
                            typeof(T).GetProperty("Email").SetValue(entity, item);
                            break;
                        default:
                            break;
                    }
                }

                result.Add(entity);
            }
            return result;
        }
    }
}
