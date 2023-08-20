namespace MinimalAPI;

public static class API
{
    public static void ConfigureAPI(this WebApplication app)
    {
		app.MapGet("/Persons", GetPersons);
		app.MapGet("/Persons/{id}", GetPerson);
		app.MapPost("/Persons", InsertPerson);
		app.MapPut("/Persons", UpdatePerson);
		app.MapDelete("/Persons", DeletePerson);
    }

    private static async Task<IResult> GetPersons(IPersonData data)
    {
		try
		{
			return Results.Ok(await data.GetPersons());
		}
		catch (Exception e)
		{
			return Results.Problem(e.Message);
		}
    }

	private static async Task<IResult> GetPerson(int id, IPersonData data)
	{
        try
        {
            var result = await data.GetPerson(id);
            
            if (result == null)
                return Results.NotFound();

            return Results.Ok(result);
        }
        catch (Exception e)
        {
            return Results.Problem(e.Message);
        }
    }

    private static async Task<IResult> InsertPerson(PersonModel person, IPersonData data)
    {
        try
        {
            await data.InsertPerson(person);
            return Results.Ok();
        }
        catch (Exception e)
        {
            return Results.Problem(e.Message);
        }
    }

    private static async Task<IResult> UpdatePerson(PersonModel person, IPersonData data)
    {
        try
        {
            await data.UpdatePerson(person);
            return Results.Ok();
        }
        catch (Exception e)
        {
            return Results.Problem(e.Message);
        }
    }

    private static async Task<IResult> DeletePerson(int id, IPersonData data)
    {
        try
        {
            await data.DeletePerson(id);
            return Results.Ok();
        }
        catch (Exception e)
        {
            return Results.Problem(e.Message);
        }
    }
}
