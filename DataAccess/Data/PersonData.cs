using DataAccess.DbAccess;
using DataAccess.Models;

namespace DataAccess.Data;

public class PersonData : IPersonData
{
    private readonly ISqlDataAccess _db;

    public PersonData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<IEnumerable<PersonModel>> GetPersons() =>
        _db.LoadData<PersonModel, dynamic>("dbo.spPersons_GetAll", new { });

    public async Task<PersonModel?> GetPerson(int id)
    {
        var result = await _db.LoadData<PersonModel, dynamic>(
            "dbo.spPersons_Get", new { Id = id });

        return result.FirstOrDefault();
    }

    public Task InsertPerson(PersonModel person) =>
        _db.SaveData("dbo.spPersons_Insert",
            new { person.Nume, person.Prenume, person.Varsta });

    public Task UpdatePerson(PersonModel person) =>
        _db.SaveData("dbo.spPersons_Update", person);

    public Task DeletePerson(int id) =>
        _db.SaveData("dbo.spPersons_Delete",
            new { Id = id });
}
