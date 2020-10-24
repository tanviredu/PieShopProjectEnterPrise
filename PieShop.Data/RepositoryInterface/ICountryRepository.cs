using PieShop.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PieShop.Data.RepositoryInterface
{
    public interface ICountryRepository
    {
        //reutn type and mentod
        IEnumerable<Country> GetAllCountries();
        Country GetCountryById(int countryId);
    }
}
