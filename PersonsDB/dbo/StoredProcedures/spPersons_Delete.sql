CREATE PROCEDURE [dbo].[spPersons_Delete]
	@Id int
AS
BEGIN
	DELETE
	FROM dbo.Persons
	WHERE Id = @Id;
END
