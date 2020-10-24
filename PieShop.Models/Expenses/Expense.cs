using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace PieShop.Models.Expenses
{
    public class Expense
    {
        public int ExpenseId { get; set; }
        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set;}

        [Required]
        public double Ammount { get; set; }
        public double Coveredammount { get; set; }

        [Required]
        public ExpenseType ExpenseType { get; set; }
        public ExpenseStatus Status { get; set; }

        [Required]
        public DateTime? Date { get; set; }


        // relation
        // this expances has one to one relation
        // with Currency and the Employee
        [Required]
        public int CurrencyId { get; set; }

        [Required]
        public int EmployeeId { get; set; }

        public Currency Currency { get; set; }
        public Employee Employee { get; set; }


    }
}
