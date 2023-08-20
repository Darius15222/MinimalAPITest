CREATE PROCEDURE [dbo].[spPersons_Get]
	@Id int
AS
BEGIN
	SELECT Id, Nume, Prenume, Varsta
	FROM dbo.Persons
	WHERE Id = @Id;
END
