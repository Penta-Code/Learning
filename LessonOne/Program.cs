// See https://aka.ms/new-console-template for more information

Address MyAddress = new Address("72056", "US", "Tampa", "Bane Ave", "14", "82");

Address MyAddress2 = new Address();
MyAddress2.Index = "74558";
MyAddress2.Country = "US";
MyAddress2.City = "Dallas";
MyAddress2.Street = "Chopen St.";
MyAddress2.House = "28";
MyAddress2.Appartment = "122";

Address MyAddress3 = new Address { Index = "55894", Country = "US", City = "NY", Street = "Sunny Ave", House = "46", Appartment = "72" };

Console.WriteLine($"Index: {MyAddress.Index}");
Console.WriteLine($"Country: {MyAddress.Country}");
Console.WriteLine($"City: {MyAddress.City}");
Console.WriteLine($"Street: {MyAddress.Street}");
Console.WriteLine($"House: {MyAddress.House}");
Console.WriteLine($"Appartment: {MyAddress.Appartment}");

Console.WriteLine($"\nIndex: {MyAddress2.Index}");
Console.WriteLine($"Country: {MyAddress2.Country}");
Console.WriteLine($"City: {MyAddress2.City}");
Console.WriteLine($"Street: {MyAddress2.Street}");
Console.WriteLine($"House: {MyAddress2.House}");
Console.WriteLine($"Appartment: {MyAddress2.Appartment}");

Console.WriteLine($"\nIndex: {MyAddress3.Index}");
Console.WriteLine($"Country: {MyAddress3.Country}");
Console.WriteLine($"City: {MyAddress3.City}");
Console.WriteLine($"Street: {MyAddress3.Street}");
Console.WriteLine($"House: {MyAddress3.House}");
Console.WriteLine($"Appartment: {MyAddress3.Appartment}");


class Address
{
    private string index = "", country = "", city = "", street = "", house = "", appartment = "";
    public string? Index { get; set; }
    public string? Country { get; set; }
    public string? City { get; set; }
    public string? Street { get; set; }
    public string? House { get; set; }
    public string? Appartment { get; set; }


    public Address()
    { 
    
    }

    public Address(string index, string country, string city, string street, string house, string appartment)
    {
        Index = index;
        Country = country;
        City = city;
        Street = street;
        House = house;
        Appartment = appartment;
    }

    public override string ToString()
    {
        return "Overriden constr";
    }
}