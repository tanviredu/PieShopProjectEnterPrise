using System;
using System.Collections.Generic;
using System.Text;

namespace PieShop.Models
{
    public class Country
    {
        // if you want to add any class in entity
        // framework you need to give it a int ID 
        // attribute before giving it a field [Name]
        public int CountryId { get; set; }
        public string Name { get; set; }
    }
}
