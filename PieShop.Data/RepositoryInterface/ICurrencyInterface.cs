using PieShop.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PieShop.Data.RepositoryInterface
{
    public interface ICurrencyRepository
    {
        // return type Name and if any then input parameter
        IEnumerable<Currency> GetAllCurrencys();
        Currency GetCurrencyById(int id);
        Currency AddCurrency(Currency currency);
    }
}
