using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;

string filePath = "users.csv";

var users = new List<User>
{
    new User("John", "Doe", "gardener"),
    new User("Lucy", "Smith", "teacher"),
    new User("Brian", "Bethamy", "programmer")
};

InsertDataIntoCSVFile(users, filePath);
ReadCSVFile(filePath);

void ReadCSVFile(string filePath)
{
    using var streamReader = File.OpenText(filePath);
    using var csvReader = new CsvReader(streamReader, CultureInfo.CurrentCulture);

    var readUsers = csvReader.GetRecords<User>();

    foreach (var user in readUsers)
    {
        Console.WriteLine(user);
    }
}

void InsertDataIntoCSVFile (List<User> users, string filePath)
{
    using var writer = new StreamWriter(filePath);
    using var csvWriter = new CsvWriter(writer, CultureInfo.CurrentCulture);

    csvWriter.WriteRecords(users);

    //csvWriter.WriteField("FirstName");
    //csvWriter.WriteField("LastName");
    //csvWriter.WriteField("Occupation");
    //csvWriter.NextRecord();

    //foreach (var user in users)
    //{
    //    csvWriter.WriteField(user.FirstName);
    //    csvWriter.WriteField(user.LastName);
    //    csvWriter.WriteField(user.Occupation);
    //    csvWriter.NextRecord();
    //}

}


record User(string FirstName, String LastName, string Occupation);