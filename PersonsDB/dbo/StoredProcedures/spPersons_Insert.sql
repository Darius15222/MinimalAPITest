CREATE PROCEDURE [dbo].[spPersons_Insert]
	@Nume nvarchar(20),
	@Prenume nvarchar(20),
	@Varsta int

AS
BEGIN
	Insert into dbo.Persons (Nume, Prenume, Varsta)
	VALUES (@Nume, @Prenume, @Varsta)
END
