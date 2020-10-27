using PieShop.Data.RepositoryInterface;
using PieShop.Models.Expenses;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Linq;


/*
    WHEN WE USE THE EXPANSE WE NEED THE CURRENCY TOO
    WE CAN MANUALLY ADD IT BUT IN HERE WE EGARLOAD THS
    WITH EFCORE MODULE
    SO IN THE LOGIN WHEN YOU ASK FOR EXPANSE I WILL
    PROVIDE THE CURRENCY TOO
    AND FOR EGARLOAD
 
 
 */


namespace PieShop.Data.Implementation
{
    public class ExpenseRepository : IExpanseRepository
    {

        private readonly AppDbContext _appDbContext;

        public ExpenseRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Expense AddExpense(Expense expanse)
        {
            var addEntity = _appDbContext.Expenses.Add(expanse);
            _appDbContext.SaveChanges();
            return addEntity.Entity;
        }

        public IEnumerable<Expense> GetAllExpense()
        {
            return _appDbContext.Expenses.Include(x => x.Currency);
        }

        public Expense GetExpenseById(int id)
        {
            return _appDbContext.Expenses.FirstOrDefault(x => x.ExpenseId == id);
        }

        public Expense UpdateExpense(Expense expense)
        {
            var foundExpense = _appDbContext.Expenses.FirstOrDefault(e => e.ExpenseId == expense.ExpenseId);
            if (foundExpense != null) {
                foundExpense.Amount = expense.Amount;
                foundExpense.Coveredammount = expense.Coveredammount;
                foundExpense.CurrencyId = expense.CurrencyId;
                foundExpense.EmployeeId = expense.EmployeeId;
                foundExpense.Description = expense.Description;
                foundExpense.Title = expense.Title;
                foundExpense.Status = expense.Status;
                foundExpense.Date = expense.Date;
                foundExpense.ExpenseType = expense.ExpenseType;

                _appDbContext.SaveChanges();
                return foundExpense;
            }

            return null;
        }
    }
}
