using DataAccess.Models;

namespace DataAccess.Data
{
    public interface IPersonData
    {
        Task DeletePerson(int id);
        Task<IEnumerable<PersonModel>> GetPersons();
        Task<PersonModel?> GetPerson(int id);
        Task InsertPerson(PersonModel person);
        Task UpdatePerson(PersonModel person);
    }
}