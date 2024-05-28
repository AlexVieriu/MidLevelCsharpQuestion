
// Cohesion class
using System.Threading.Channels;

class PetsCollection
{
    // non of this methods can be moved away from this class 
    private List<Pet> _pets = new();
    public void Add(Pet pet) => _pets.Add(pet);
    public int Count => _pets.Count;
    public IEnumerable<PetType> GetCurrentlyStoredTypes() =>
        _pets.Select(pet => pet.PetType).Distinct();
    public bool Contains(PetType petType) =>
        GetCurrentlyStoredTypes().Contains(petType);
}

public record Pet(string Name, PetType PetType, float Weight);
public enum PetType { Cat, Dog, Fish }


// Non-Cohesion class
public class HousePricer
{
    private readonly decimal _dollarsPerSquareMeter;
    private readonly IOwnersDatabase _ownersDatabase;

    public HousePricer(decimal dollarsPerSquareMeter, IOwnersDatabase ownersDatabase)
    {
        _dollarsPerSquareMeter = dollarsPerSquareMeter;
        _ownersDatabase = ownersDatabase;
    }

    // Responsibility 1 - price of the house
    public decimal GetPrice(House house) =>
        _dollarsPerSquareMeter * house.Area *
        GetPriceMultiplierBasedOnFloors(house.Floors);

    private decimal GetPriceMultiplierBasedOnFloors(int floors)
        => floors switch { 1 => 1m, 2 => 1.5m, _ => 1.6m };

    // Responsibility 2 - notifying the owner
    public void SendPriceToOwner(House house) => 
        Console.WriteLine($"Sending price {GetPrice(house)} to {FindOwnerEmail(house.)}");

    private string FindOwnerEmail(string address) =>
        _ownersDatabase.GetEmailByAddress(address);

}
