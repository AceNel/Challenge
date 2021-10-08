using CsvHelper.Configuration;
using Challenge.Models;

namespace Challenge.Mappers
{
    public sealed class PersonMap : ClassMap<Person>
    {
        public PersonMap()
        {
            Map(m => m.FirstName).Name(Constants.CsvHeaders.FirstName);
            Map(m => m.LastName).Name(Constants.CsvHeaders.LastName);
            Map(m => m.Email).Name(Constants.CsvHeaders.Email);
            Map(m => m.DateOfBirth).Name(Constants.CsvHeaders.DateOfBirth);
            Map(m => m.PhoneNumber).Name(Constants.CsvHeaders.PhoneNumber);
            Map(m => m.NextOfKin).Name(Constants.CsvHeaders.NextOfKin);
           
        }
    }
}
