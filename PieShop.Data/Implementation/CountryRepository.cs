using PieShop.Data.RepositoryInterface;
using PieShop.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PieShop.Data.Implementation
{
    public class CountryRepository : ICountryRepository
    {
        private readonly AppDbContext _appDbContext;

        // the constructor is for  when the class
        // will init it will already get a dbContext
        // connection
        // we injected the database service in this concrete
        // implementation
        public CountryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Country> GetAllCountries()
        {
            return _appDbContext.Countries.Select(c => c).ToList();
        }

        public Country GetCountryById(int countryId)
        {
            return _appDbContext.Countries.FirstOrDefault(c => c.CountryId == countryId);
        }
    }
}
