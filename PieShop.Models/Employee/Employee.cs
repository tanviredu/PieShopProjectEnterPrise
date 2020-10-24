using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace PieShop.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        
        [Required]
        [StringLength(50,ErrorMessage ="First Name is too long!!!")]
        public string FirstName { get; set; }
        
        [Required]
        [StringLength(50, ErrorMessage = "First Name is too long!!!")]
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        
        // relation
        public int CountryId { get; set; }
        public Country Country { get; set; }

        public string PhoneNumber { get; set; }
        public bool Smoker { get; set; }

        public bool IsOPEX { get; set; }
        public bool isFTE { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public Gender Gender { get; set; }

        [StringLength(1000, ErrorMessage = "Comment Length is too long!!")]
        public string Comment { get; set; }
        public DateTime? JoinedDate { get; set; }
        public DateTime? ExitDate { get; set; }


        // relation this two field 
        // define there is a JobcategoryId int that
        // is related with the Jobcategory class JobCategoryId
        public int JobCategoryId { get; set; }
        public JobCategory JobCategory { get; set; }

        public double Latitude { get; set; }
        public double Longitude { get; set; }






    }
}
