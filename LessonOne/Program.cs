// See https://aka.ms/new-console-template for more information

Address MyAddress = new Address("72056", "USA", "Tampa", "Bane Ave", "14", "82");

Address MyAddress2 = new Address();

Address MyAddress3 = new Address { Index = "55894", City = "NY" };

new Address().Show();

Print($"Index: {MyAddress.Index}");
Print($"Country: {MyAddress.Country}");
Print($"City: {MyAddress.City}");
Print($"Street: {MyAddress.Street}");
Print($"House: {MyAddress.House}");
Print($"Appartment: {MyAddress.Appartment}");

PrintO(MyAddress2);

PrintO(MyAddress3);


void Print(string text)
{
    Console.WriteLine(text);
}

void PrintO(object item)
{
    Console.WriteLine(item);
}

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
        return "Default constructor";
    }
}