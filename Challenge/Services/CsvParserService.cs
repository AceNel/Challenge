using CsvHelper;
using Challenge.Mappers;
using Challenge.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Challenge.Services
{
    public class CsvParserService : ICsvParserService
        {
            public List<Person> ReadCsvFileToPerson(string path)
            {
                try
                {
                using var reader = new StreamReader(path, Encoding.Default);
                using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
                    csv.Context.RegisterClassMap<PersonMap>();
                    var records = csv.GetRecords<Person>().ToList();
                    return records;

                //Loop through the records generic list: List of Type Person performing validations for each column header i.e
                // Email header
      
                 
            }
                catch (UnauthorizedAccessException e)
                {
                    throw new Exception(e.Message);
                }
                catch (FieldValidationException e)
                {
                    throw new Exception(e.Message);
                }
                catch (CsvHelperException e)
                {
                    throw new Exception(e.Message);
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }

        public void WriteNewCsvFile(string path, List<Person> persons)
        {
            using StreamWriter writer = new(path, false, new UTF8Encoding(true));
            using CsvWriter csv = new(writer, CultureInfo.InvariantCulture);
            csv.WriteHeader<Person>();
            csv.NextRecord();
            foreach (Person person in persons)
            {
                csv.WriteRecord<Person>(person);
                csv.NextRecord();
            }
        }
    }
}

