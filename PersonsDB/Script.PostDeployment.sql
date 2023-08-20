if not exists (select 1 from dbo.Persons)
begin
	insert into dbo.Persons(Nume, Prenume, Varsta)
	values
	('Nume1', 'Prenume1', 5),
	('Nume2', 'Prenume2', 50),
	('Nume3', 'Prenume3', 15),
	('Nume4', 'Prenume4', 25),
	('Nume5', 'Prenume5', 18);
end