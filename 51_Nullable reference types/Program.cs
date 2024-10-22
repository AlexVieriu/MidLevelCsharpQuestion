using NUnit.Framework;

string? nonNullableString = null;

static string FormatHouseData(IEnumerable<House> houses)
{
    return string.Join("\n", houses.Select(house =>
        $"Owner is {house.OwnerName} + {house.Address!.Number} + {house.Address!.Street}"));
}

class House
{
    public House(string ownerName, Address address)
    {
        if (ownerName == null)
            throw new ArgumentNullException(nameof(ownerName));

        if (address == null) 
            throw new ArgumentNullException(nameof (address));

        OwnerName = ownerName;
        Address = address;
    }

    public string? OwnerName { get; }
    public Address? Address { get; }
}

class Address
{
    public Address(string street, string number)
    {
        Street = street;
        Number = number;
    }

    public string? Street { get; }
    public string? Number { get; }
}

[TestFixture]
public class HouseTests
{
    [Test]
    public void NullOwnerName_ShallThrowException()
    {
        Assert.Throws<ArgumentNullException>(() =>
        new House(null, new Address("street", "1")));
    }
}