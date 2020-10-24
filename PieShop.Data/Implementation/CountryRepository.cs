using PieShop.Data.RepositoryInterface;
using PieShop.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PieShop.Data.Implementation
{
    public class CountryRepository : ICountryRepository
    {
        private readonly AppDbContext _appDbContext;

        // the constructor is for  when the class
        // will init it will already get a dbContext
        // connection
        public CountryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Country> GetAllCountries()
        {
            throw new NotImplementedException();
        }

        public Country GetCountryById(int countryId)
        {
            throw new NotImplementedException();
        }
    }
}
