using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventManagement.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal EventPrice { get; set; }
        public string Location { get; set; }
        public string City { get; set; }
        public decimal TicketPrice { get; set; }
        public DateTime Date { get; set; }

        public ICollection<Category> Categories { get; set; }

        public Event()
        {
            Categories = new HashSet<Category>();
        }

    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<SubCategory> SubCategories { get; set; }

        public Category()
        {
            SubCategories = new HashSet<SubCategory>();
        }
    }

    public class SubCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Participant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Genders Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }

    public class Enroll
    {
        public int Id { get; set; }

        public Participant Participant { get; set; }
        public Event Event { get; set; }
    }

    public class Payment
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public Modes Mode { get; set; }

        public Enroll Enroll { get; set; }
    }

    public enum Modes
    {
        Cash,
        CC,
        DC
    }

    public enum Genders
    {
        Male,
        Female
    }
}