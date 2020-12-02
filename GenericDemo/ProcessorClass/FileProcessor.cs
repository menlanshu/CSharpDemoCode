using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace GenericDemo.ProcessorClass
{
    public static class FileProcessor
    {
        // if you want to have T alway has a Id, I think you need declare a class or interface which has a ID
        // let me have a try

        public static List<T> ReadFromFile<T>(string filePath) where T: class, new()
        {
            List<T> output = new List<T>();

            // read lines from file
            List<string> dataList = ReadDataFromFile(filePath);

            if(dataList.Count < 2)
            {
                throw new IndexOutOfRangeException($"No data in file: {filePath}");
            }

            // convert all data to object
            var properties = (new T()).GetType().GetProperties();
            // get column value
            var columnName = new List<string>(dataList[0].Split(","));

            if(columnName.Count != properties.Length)
            {
                throw new IndexOutOfRangeException("Data property count mimatch with columns in file");
            }

            var columnIndex = GetPropertyIndex(columnName, properties);
            
            dataList.RemoveAt(0);

            foreach(string line in dataList)
            {
                T newDataObject = new T();
                var dataItem = line.Split(",");
                for(int i = 0; i< columnIndex.Length; i++)
                {
                    properties[columnIndex[i]]
                        .SetValue(newDataObject, Convert.ChangeType(dataItem[i], properties[columnIndex[i]].PropertyType));
                }
                output.Add(newDataObject);
            }

            return output;
        }
        private static int[] GetPropertyIndex(List<string> colList, PropertyInfo[] properties)
        {
            int[] output = new int[colList.Count];
            int index = 0;

            foreach(var property in properties)
            {
                output[index] = colList.IndexOf(property.Name);
                index++;

                // get type is the class type of PropertyInfo
                // PropertyType is the actual type of current Property, such as string, int
                Console.WriteLine($"property type {property.GetType()}");
                Console.WriteLine($"property propertytype {property.PropertyType}");
            }

            return output;
        }
        public static void SaveToFile<T>(List<T> objectList, string filePath) where T: class, new()
        {
            // judge if any data in object list, if no data show error
            if (objectList.Count < 1)
            {
                throw new MissingMemberException("No data need to be saved, you must pass in a list with at least one item");
            }

            // get all properties of instance
            var propertyList = (new T()).GetType().GetProperties();

            // Convert object to line data
            List<string> lineList = new List<string>();
            string newLine = "";

            // get column data
            foreach(var property in propertyList)
            {
                newLine += property.Name + ",";
            }
            lineList.Add(newLine.Substring(0, newLine.Length - 1));

            foreach(var dataObject in objectList)
            {
                newLine = "";
                foreach(var property in propertyList)
                {
                    newLine += Convert.ToString(property.GetValue(dataObject)) + ",";
                }
                lineList.Add(newLine.Substring(0, newLine.Length - 1));
            }

            // Save data to file
            SaveDataToFile(lineList, filePath);
        }

        private static List<string> ReadDataFromFile(string filePath)
        {
            return new List<string>(File.ReadAllLines(filePath));
        }
        private static void SaveDataToFile(List<string> dataInfo, string filePath)
        {
            File.WriteAllLines(filePath, dataInfo.ToArray());
        }
    }
}
