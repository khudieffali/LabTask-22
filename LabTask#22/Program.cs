
using LabTask_22;



Console.WriteLine("Brand adini qeyd edin");
string brand = Console.ReadLine();
Console.WriteLine("Model adini qeyd edin");
string model = Console.ReadLine();

millCheck:
Console.WriteLine("Millage qeyd edin");
string millAge = Console.ReadLine();
bool checkMillAge = double.TryParse(millAge, out double MillAge);
if (!checkMillAge) goto millCheck;

fuelCap:
Console.WriteLine("Fuel Capacity qeyd edin");
string fuelCapacity = Console.ReadLine();
bool chekcFuelCapacity = double.TryParse(fuelCapacity, out double FuelCapacity);
if (!chekcFuelCapacity) goto fuelCap;

restFl:
Console.WriteLine("Rest Fuel qeyd edin");
string restFuel = Console.ReadLine();
bool checkRestFuel = double.TryParse(restFuel, out double RestFuel);
if (!checkRestFuel) goto restFl;

Car car = new(brand, model, MillAge, FuelCapacity, RestFuel);

Console.WriteLine($" Avtomobiliniz elave olundu - {car.Brand} {car.Model} {car.RestFuel}");

enterFuel:
Console.WriteLine("Daxil edeceyiniz benzini qeyd edin");
string entFuel = Console.ReadLine();
bool checkEnterFuel = double.TryParse(entFuel, out double EnterFuel);
if (!checkEnterFuel) goto enterFuel;


if (car.AddFuel(EnterFuel))
{
    Console.WriteLine("Benzin Elave olundu");
    Console.WriteLine($"{car.Brand} {car.Model} {car.RestFuel}");
}
else { goto enterFuel;}




