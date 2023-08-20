CREATE PROCEDURE [dbo].[spPersons_GetAll]
AS
BEGIN
	Select Id, Nume, Prenume, Varsta
	From dbo.Persons;
END