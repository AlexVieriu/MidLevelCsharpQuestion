class PersonalDataFormatorFactory
{
    public PersonalDataFormatter Create(Source source)
    {
        switch(source)
        {
            case Source.Database:
                return new Database();
            case Source.Excel: 
                return new Excel();
            default:
                throw new ArgumentException("Invalid Source");
        }
    }
}
