using static System.Console;

// Example 1
var currencies = new Dictionary<string, string>();
currencies["USA"] = "USA";
currencies["Japan"] = "JPY";
currencies["Brazil"] = "BRL";

var currenciesCompareToUsDollar = new Dictionary<string, decimal>();
currenciesCompareToUsDollar["USD"] = 1m;
currenciesCompareToUsDollar["JPY"] = 0.0086m;
currenciesCompareToUsDollar["BRL"] = 0.18m;
//currenciesCompareToUsDollar.Add("BRL", 0.18m); // will throw and error because we already have a item with the same key
currenciesCompareToUsDollar["BRL"] = 0.17m;
WriteLine(currenciesCompareToUsDollar["BRL"]);

var saveGames = new Dictionary<string, string>()
{
    ["save1"] = @"C:/saves/save1.dat",
    ["autosave"] = @"C:/saves/auto/save.dat",
    ["beforeBossFight"] = @"C:/saves/beforeBossFight.dat"
};

// Example 2
var employee = new List<Employee>
{
    new Employee(Department.Xenobiology, 15000),
    new Employee(Department.MissionControl, 10000),
    new Employee(Department.PlanetTerraforming, 9000),
    new Employee(Department.PlanetTerraforming, 8000),
    new Employee(Department.MissionControl, 11000),
    new Employee(Department.MissionControl, 12000)
};

var averageSalariesInDepartments = employee.GroupBy(e => e.Department)
    .ToDictionary(groupingKey => groupingKey.Key,
                  groupingData => groupingData.Average(g => g.Salary));

foreach (var averageSalaryInDepartment in averageSalariesInDepartments)
{
    WriteLine($"Average salary in {averageSalaryInDepartment.Key}  is {averageSalaryInDepartment.Value}");
}


ReadKey();


// Example 2
record Employee(Department Department, decimal Salary);
enum Department { MissionControl, Xenobiology, PlanetTerraforming }
