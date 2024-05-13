public record Person
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Residence { get; set; }
    public string Hobby { get; set; }

    public Person()
    {

    }

    public Person(string name, string lastName, string residence, string hobby)
    {
        Name = name;
        LastName = lastName;
        Residence = residence;
        Hobby = hobby;
    }
}
