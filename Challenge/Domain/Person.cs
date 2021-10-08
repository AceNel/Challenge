using CsvHelper.Configuration.Attributes;
using System;
using System.ComponentModel.DataAnnotations;

namespace Challenge.Models
{
    public class Person
    {
        [Name(Constants.CsvHeaders.FirstName)]
        public string FirstName { get; set; }

        [Name(Constants.CsvHeaders.LastName)]
        public string LastName { get; set; }

        [Name(Constants.CsvHeaders.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Name(Constants.CsvHeaders.Email)]
        public string Email { get; set; }

        [Name(Constants.CsvHeaders.DateOfBirth)]
        
        public string DateOfBirth { get; set; }

        [Name(Constants.CsvHeaders.NextOfKin)]
        public string NextOfKin { get; set; }
    }
}
