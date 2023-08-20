CREATE PROCEDURE [dbo].[spPersons_Update]
	@Id int,
	@Nume nvarchar(20),
	@Prenume nvarchar(20),
	@Varsta int
AS
BEGIN
	Update dbo.Persons
	set Nume = @Nume, Prenume = @Prenume, Varsta = @Varsta
	where Id = @Id;
END
