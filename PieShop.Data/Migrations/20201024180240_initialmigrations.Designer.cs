﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PieShop.Data;

namespace PieShop.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20201024180240_initialmigrations")]
    partial class initialmigrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9");

            modelBuilder.Entity("PieShop.Models.Answer", b =>
                {
                    b.Property<int>("AnswerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Rating")
                        .HasColumnType("REAL");

                    b.Property<string>("Response")
                        .HasColumnType("TEXT");

                    b.Property<int>("SurveyId")
                        .HasColumnType("INTEGER");

                    b.HasKey("AnswerId");

                    b.HasIndex("SurveyId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("PieShop.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("CountryId");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            CountryId = 1,
                            Name = "Belgium"
                        },
                        new
                        {
                            CountryId = 2,
                            Name = "Germany"
                        },
                        new
                        {
                            CountryId = 3,
                            Name = "Netherlands"
                        },
                        new
                        {
                            CountryId = 4,
                            Name = "USA"
                        },
                        new
                        {
                            CountryId = 5,
                            Name = "Japan"
                        },
                        new
                        {
                            CountryId = 6,
                            Name = "China"
                        },
                        new
                        {
                            CountryId = 7,
                            Name = "UK"
                        },
                        new
                        {
                            CountryId = 8,
                            Name = "France"
                        },
                        new
                        {
                            CountryId = 9,
                            Name = "Brazil"
                        });
                });

            modelBuilder.Entity("PieShop.Models.Currency", b =>
                {
                    b.Property<int>("CurrencyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Country")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<double>("USExchange")
                        .HasColumnType("REAL");

                    b.HasKey("CurrencyId");

                    b.ToTable("Currencies");

                    b.HasData(
                        new
                        {
                            CurrencyId = 1,
                            Country = "USA",
                            Name = "US Dollars",
                            USExchange = 1.0
                        },
                        new
                        {
                            CurrencyId = 2,
                            Country = "Germany",
                            Name = "Euro",
                            USExchange = 1.1399999999999999
                        });
                });

            modelBuilder.Entity("PieShop.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("Comment")
                        .HasColumnType("TEXT")
                        .HasMaxLength(1000);

                    b.Property<int>("CountryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("ExitDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<int>("Gender")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsOPEX")
                        .HasColumnType("INTEGER");

                    b.Property<int>("JobCategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("JoinedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<double>("Latitude")
                        .HasColumnType("REAL");

                    b.Property<double>("Longitude")
                        .HasColumnType("REAL");

                    b.Property<int>("MaritalStatus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Smoker")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Street")
                        .HasColumnType("TEXT");

                    b.Property<string>("Zip")
                        .HasColumnType("TEXT");

                    b.Property<bool>("isFTE")
                        .HasColumnType("INTEGER");

                    b.HasKey("EmployeeId");

                    b.HasIndex("CountryId");

                    b.HasIndex("JobCategoryId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            BirthDate = new DateTime(1979, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            City = "Brussels",
                            Comment = "Lorem Ipsum",
                            CountryId = 1,
                            Email = "bethany@bethanyspieshop.com",
                            FirstName = "Bethany",
                            Gender = 1,
                            IsOPEX = false,
                            JobCategoryId = 1,
                            JoinedDate = new DateTime(2015, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Smith",
                            Latitude = 50.850299999999997,
                            Longitude = 4.3517000000000001,
                            MaritalStatus = 1,
                            PhoneNumber = "324777888773",
                            Smoker = false,
                            Street = "Grote Markt 1",
                            Zip = "1000",
                            isFTE = false
                        },
                        new
                        {
                            EmployeeId = 2,
                            BirthDate = new DateTime(1979, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            City = "New York",
                            Comment = "Lorem Ipsum",
                            CountryId = 1,
                            Email = "bob@bethanyspieshop.com",
                            FirstName = "Bob",
                            Gender = 1,
                            IsOPEX = false,
                            JobCategoryId = 1,
                            JoinedDate = new DateTime(2015, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Smith",
                            Latitude = 46.850299999999997,
                            Longitude = 48.351700000000001,
                            MaritalStatus = 1,
                            PhoneNumber = "55512312321",
                            Smoker = false,
                            Street = "Apple Road",
                            Zip = "59555",
                            isFTE = false
                        });
                });

            modelBuilder.Entity("PieShop.Models.Expenses.Expense", b =>
                {
                    b.Property<int>("ExpenseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Amount")
                        .HasColumnType("REAL");

                    b.Property<double>("Coveredammount")
                        .HasColumnType("REAL");

                    b.Property<int>("CurrencyId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Date")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ExpenseType")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ExpenseId");

                    b.HasIndex("CurrencyId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Expenses");

                    b.HasData(
                        new
                        {
                            ExpenseId = 1,
                            Amount = 900.0,
                            Coveredammount = 0.0,
                            CurrencyId = 1,
                            Date = new DateTime(2020, 10, 25, 0, 2, 38, 646, DateTimeKind.Local).AddTicks(1352),
                            Description = "I went to a conference",
                            EmployeeId = 1,
                            ExpenseType = 2,
                            Status = 0,
                            Title = "Conference Expense"
                        });
                });

            modelBuilder.Entity("PieShop.Models.HRTask.HRTask", b =>
                {
                    b.Property<int>("HRTaskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AssignedTo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("HRTaskId");

                    b.ToTable("Tasks");

                    b.HasData(
                        new
                        {
                            HRTaskId = 1,
                            AssignedTo = 0,
                            Description = "Joe is having an issue with his account login, please look into it.",
                            Status = 0,
                            Title = "Employee Onboarding"
                        },
                        new
                        {
                            HRTaskId = 2,
                            AssignedTo = 0,
                            Description = "The fridge needs to be cleaned out and people are ignoring the weekly rotation.",
                            Status = 0,
                            Title = "Kitchen Duty"
                        },
                        new
                        {
                            HRTaskId = 3,
                            AssignedTo = 0,
                            Description = "Schedule a welcome lunch for our new employees",
                            Status = 0,
                            Title = "Welcome Lunch"
                        },
                        new
                        {
                            HRTaskId = 4,
                            AssignedTo = 0,
                            Description = "We need to schedule intern interviews for the fall semester.",
                            Status = 0,
                            Title = "Intern interviews"
                        });
                });

            modelBuilder.Entity("PieShop.Models.JobCategory", b =>
                {
                    b.Property<int>("JobCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("JobCategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("JobCategoryId");

                    b.ToTable("JobCategories");

                    b.HasData(
                        new
                        {
                            JobCategoryId = 1,
                            JobCategoryName = "Pie research"
                        },
                        new
                        {
                            JobCategoryId = 2,
                            JobCategoryName = "Sales"
                        },
                        new
                        {
                            JobCategoryId = 3,
                            JobCategoryName = "Management"
                        },
                        new
                        {
                            JobCategoryId = 4,
                            JobCategoryName = "Store staff"
                        },
                        new
                        {
                            JobCategoryId = 5,
                            JobCategoryName = "Finance"
                        },
                        new
                        {
                            JobCategoryId = 6,
                            JobCategoryName = "QA"
                        },
                        new
                        {
                            JobCategoryId = 7,
                            JobCategoryName = "IT"
                        },
                        new
                        {
                            JobCategoryId = 8,
                            JobCategoryName = "Cleaning"
                        },
                        new
                        {
                            JobCategoryId = 9,
                            JobCategoryName = "Bakery"
                        });
                });

            modelBuilder.Entity("PieShop.Models.Survey", b =>
                {
                    b.Property<int>("SurveyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("SurveyId");

                    b.ToTable("Surveys");
                });

            modelBuilder.Entity("PieShop.Models.Answer", b =>
                {
                    b.HasOne("PieShop.Models.Survey", "Survey")
                        .WithMany("Answers")
                        .HasForeignKey("SurveyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PieShop.Models.Employee", b =>
                {
                    b.HasOne("PieShop.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PieShop.Models.JobCategory", "JobCategory")
                        .WithMany()
                        .HasForeignKey("JobCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PieShop.Models.Expenses.Expense", b =>
                {
                    b.HasOne("PieShop.Models.Currency", "Currency")
                        .WithMany()
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PieShop.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
