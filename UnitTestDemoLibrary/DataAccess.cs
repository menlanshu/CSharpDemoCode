using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnitTestDemoLibrary.Models;

namespace UnitTestDemoLibrary
{
    public class DataAccess
    {
        private string personTextFile = "PersonText.txt";

        public void AddNewPerson(IPersonModel person)
        {
            List<string> lines = new List<string>();
            List<IPersonModel> people = GetAllPeople();
            AddNewPersonToList(people, person);

            lines = ConvertModelsToCSV(people);

            File.WriteAllLines(personTextFile, lines);
        }

        private void AddNewPersonToList(List<IPersonModel> people, IPersonModel newPerson)
        {
            people.Add(newPerson);
        }

        public List<string> ConvertModelsToCSV(List<IPersonModel> people)
        {
            List<string> lines = new List<string>();

            foreach (var user in people)
            {
                lines.Add($"{user.FirstName},{user.LastName}");
            }

            return lines;
        }

        public List<IPersonModel> GetAllPeople()
        {
            List<IPersonModel> output = new List<IPersonModel>();
            var content = File.ReadAllLines(personTextFile);

            foreach(var line in content)
            {
                var data = line.Split(',');
                IPersonModel personModel = new PersonModel
                {
                    FirstName = data[0],
                    LastName = data[1],
                };
                output.Add(personModel);
            }

            return output;
        }
    }
}
