// Use case: some data is coming from Database, others form Excel
var factory_inheritance = new PersonalDataFormatorFactory();

var fromExcel = factory_inheritance.Create(Source.Excel); // returns a Excel object
Console.WriteLine(fromExcel.Format());

Console.WriteLine();

var fromDatabase = factory_inheritance.Create(Source.Database); // return the Database object
Console.WriteLine(fromDatabase.Format());

Console.WriteLine();
