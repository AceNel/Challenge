using Challenge.Models;
using Challenge.Services;
using System;

namespace Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var csvParserService = new CsvParserService();
            var path = @"D:\Data\file.csv";
            var result = csvParserService.ReadCsvFileToPerson(path);
           
            //Console.WriteLine();


            var personToAdd = new Person()
            {
            

                FirstName = "Nelson",
                LastName = "Kimani",
                Email = "nelson@mail.com",
                DateOfBirth = ("03/10/1995"),
                PhoneNumber = "1111",
                NextOfKin = "Jane Karimi"
            };
            result.Add(personToAdd);
            csvParserService.WriteNewCsvFile(@"D:\Data\file.csv", result);
           // Console.WriteLine(result);
        }
    }
}
