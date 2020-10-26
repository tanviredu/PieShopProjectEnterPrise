using PieShop.Models.Expenses;
using System;
using System.Collections.Generic;
using System.Text;

namespace PieShop.Data.RepositoryInterface
{
    public interface IExpanseRepository
    {
        public IEnumerable<Expense> GetAllExpense();
        public Expense GetExpenseById(int id);
        Expense UpdateExpense(Expense expense);
        Expense AddExpense(Expense expense);
    }
}
