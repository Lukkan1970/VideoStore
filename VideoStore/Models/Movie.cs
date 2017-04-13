using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoStore.Models
{
    public class Movie
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public Customer currentRentingCustomer { get; set; }

        public List<Customer> PrevouisRentingCustomer { get; set; }

        public Movie()
        {
                PrevouisRentingCustomer = new List<Customer>();
        }

    }
}