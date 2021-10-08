using Challenge.Models;
using System.Collections.Generic;

namespace Challenge.Services
{
    public interface ICsvParserService
    {
        List<Person> ReadCsvFileToPerson(string path);
        void WriteNewCsvFile(string path, List<Person> persons);
    }
}
