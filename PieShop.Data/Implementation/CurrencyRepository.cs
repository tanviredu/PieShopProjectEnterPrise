using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PieShop.Data.RepositoryInterface;
using PieShop.Models;

namespace PieShop.Data.Implementation
{
    public class CurrencyRepository : ICurrencyRepository
    {
        private readonly AppDbContext _appDbContext;

        public CurrencyRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Currency AddCurrency(Currency currency)
        {
            var addEntity = _appDbContext.Currencies.Add(currency);
            _appDbContext.SaveChanges();
            return addEntity.Entity;
            // this this a currency Entity
            // since we are returning the currency Entity
            // we have to return something
        
        }

        public IEnumerable<Currency> GetAllCurrencys()
        {
            return _appDbContext.Currencies.Select(c => c).ToList();
        }

        public Currency GetCurrencyById(int id)
        {
            return _appDbContext.Currencies.FirstOrDefault(c => c.CurrencyId == id);
        }
    }
}
