using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.GenericsDemo.WithGenerics
{
    public static class GenericTextFileProcessor
    {
        // Where T => Limitation of current T object
        // Where T : Class => only can be class
        // WHere T : Class, New() => have a constructor with empty input, 
        // because we need to use new T() in the method
        // Of cause you can pass in multi generic types when you needed such as LoadFromTextFile<T, U>() where T: class, new() where U : Person
        public static List<T> LoadFromTextFile<T>(string filePath) where T : class, new()
        {
            var lines = File.ReadAllLines(filePath).ToList();
            List<T> output = new List<T>();
            T entry = new T();
            var cols = entry.GetType().GetProperties();


            //check to be sure we have a least one header row and one data row
            if(lines.Count < 2)
            {
                throw new IndexOutOfRangeException("Thie silf was either empty or missing");
            }

            // Split the header into one column header per entry
            var headers = lines[0].Split(',');

            // Remove the header row form the lines so we don't
            // have to worry aout skipping over that first row
            lines.RemoveAt(0);

            foreach(var row in lines)
            {
                entry = new T();

                // Splits the row into individual columns. Now the index
                // of this row matches the index of the header so the
                // Firstame column header lines up with the FirstName value in this row
                var vals = row.Split(',');

                // Loops through each header entry so we can compare that
                // against the list of columns from reflection. Once we get
                // the matching column, we can do the "SetValue" method to 
                // set the column value for our entry variable to the vals
                // item at the same index as the paricular header
                for(var i = 0;i< headers.Length; i++)
                {
                    foreach (var col in cols)
                    {
                        if(col.Name == headers[i])
                        {
                            col.SetValue(entry, Convert.ChangeType(vals[i], col.PropertyType));
                        }
                    }
                }

                output.Add(entry);

            }

            return output;
        }


        public static void SaveToTextFile<T>(List<T> data, string filePath) where T : class, new()
        {
            List<string> lines = new List<string>();

            StringBuilder line = new StringBuilder();

            if (data == null || data.Count == 0)
            {
                throw new ArgumentNullException("data", "You must popluate the data parameter with at least");
            }


            var cols = data[0].GetType().GetProperties();

            // Loops through each column and gets the name so it can comma
            // Separate it into the header row
            foreach (var col in cols)
            {
                line.Append(col.Name);
                line.Append(",");
            }

            // Adds the colum nheader entries to the first line (removing
            // the last comma from the end first
            lines.Add(line.ToString().Substring(0, line.Length - 1));

            foreach (var row in data)
            {
                line = new StringBuilder();

                foreach(var col in cols)
                {
                    line.Append(col.GetValue(row));
                    line.Append(",");
                }


                // Add the row to the set of lines (removing
                // the last comma from the end
                lines.Add(line.ToString().Substring(0, line.Length - 1));

            }

            File.WriteAllLines(filePath, lines);

        }

    }
}
