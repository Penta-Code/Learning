using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonOne
{
    public class Address
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
}