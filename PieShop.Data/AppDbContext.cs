using System;
using System.Collections.Generic;
using System.Text;
using PieShop.Models;
using Microsoft.EntityFrameworkCore;
using PieShop.Models.Expenses;
using PieShop.Models.HRTask;

namespace PieShop.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<JobCategory> JobCategories { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<HRTask> Tasks { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Survey> Surveys { get; set; }
        public DbSet<Answer> Answers { get; set; }

        // this is for configuring the 
        // database
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=D:\\PieShopProjectEnterPrise\\PieShop.Data\\database.db");
        }

        // SEEDING INITIAL DATA

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            // Seed The Country
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 1, Name = "Belgium" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 2, Name = "Germany" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 3, Name = "Netherlands" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 4, Name = "USA" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 5, Name = "Japan" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 6, Name = "China" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 7, Name = "UK" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 8, Name = "France" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 9, Name = "Brazil" });

            // Seed the jobCategory
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { JobCategoryId = 1, JobCategoryName = "Pie research" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { JobCategoryId = 2, JobCategoryName = "Sales" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { JobCategoryId = 3, JobCategoryName = "Management" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { JobCategoryId = 4, JobCategoryName = "Store staff" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { JobCategoryId = 5, JobCategoryName = "Finance" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { JobCategoryId = 6, JobCategoryName = "QA" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { JobCategoryId = 7, JobCategoryName = "IT" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { JobCategoryId = 8, JobCategoryName = "Cleaning" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { JobCategoryId = 9, JobCategoryName = "Bakery" });

            // Seed the Currency
            modelBuilder.Entity<Currency>().HasData(new Currency()
            {
                Country = "USA",
                CurrencyId = 1,
                Name = "US Dollars",
                USExchange = 1
            });

            modelBuilder.Entity<Currency>().HasData(new Currency()
            {
                Country = "Germany",
                CurrencyId = 2,
                Name = "Euro",
                USExchange = 1.14
            });

            // Seeding Expanses

            modelBuilder.Entity<Expense>().HasData(new Expense()
            {
                ExpenseId = 1,
                Title = "Conference Expense",
                Description = "I went to a conference",
                Amount = 900,
                ExpenseType = ExpenseType.Conference,
                Date = DateTime.Now,
                CurrencyId = 1,
                EmployeeId = 1
            });

            // Seeding HRTask (you can feed a list too)
            modelBuilder.Entity<HRTask>().HasData(new List<HRTask>()
            {
                new HRTask()
                {
                    HRTaskId = 1,
                    Description = "Joe is having an issue with his account login, please look into it.",
                    Title = "Employee Onboarding",
                    Status = HRTaskStatus.Open
                },
                new HRTask()
                {
                    HRTaskId = 2,
                    Description = "The fridge needs to be cleaned out and people are ignoring the weekly rotation.",
                    Title = "Kitchen Duty",
                    Status = HRTaskStatus.Open
                },
                new HRTask()
                {
                    HRTaskId = 3,
                    Description = "Schedule a welcome lunch for our new employees",
                    Title = "Welcome Lunch",
                    Status = HRTaskStatus.Open
                },
                new HRTask()
                {
                    HRTaskId = 4,
                    Description = "We need to schedule intern interviews for the fall semester.",
                    Title = "Intern interviews",
                    Status = HRTaskStatus.Open
                }
            });

            // Seeding the Employees with a a List of Employee
            modelBuilder.Entity<Employee>().HasData(new List<Employee>()
            {
                new Employee()
                {
                    EmployeeId = 1,
                    CountryId = 1,
                    MaritalStatus = MaritalStatus.Single,
                    BirthDate = new DateTime(1979, 1, 16),
                    City = "Brussels",
                    Email = "bethany@bethanyspieshop.com",
                    FirstName = "Bethany",
                    LastName = "Smith",
                    Gender = Gender.Female,
                    PhoneNumber = "324777888773",
                    Smoker = false,
                    Street = "Grote Markt 1",
                    Zip = "1000",
                    JobCategoryId = 1,
                    Comment = "Lorem Ipsum",
                    ExitDate = null,
                    JoinedDate = new DateTime(2015, 3, 1),
                    Latitude = 50.8503,
                    Longitude = 4.3517
                },
                new Employee()
                {
                    EmployeeId = 2,
                    CountryId = 1,
                    MaritalStatus = MaritalStatus.Single,
                    BirthDate = new DateTime(1979, 1, 16),
                    City = "New York",
                    Email = "bob@bethanyspieshop.com",
                    FirstName = "Bob",
                    LastName = "Smith",
                    Gender = Gender.Female,
                    PhoneNumber = "55512312321",
                    Smoker = false,
                    Street = "Apple Road",
                    Zip = "59555",
                    JobCategoryId = 1,
                    Comment = "Lorem Ipsum",
                    ExitDate = null,
                    JoinedDate = new DateTime(2015, 3, 1),
                    Latitude = 46.8503,
                    Longitude = 48.3517
                }
            });


        }
    }
}

// package manager console setup
// add-migration initial
// update-database

// if that does not work then 
// go to the project with terminal and 
// use this command


// dotnet ef migrations add initialmigrations
// dotnet ef database update   

//[for this you need to install dotnet ef tools]
// and the project should be netcoreapp3.1