using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoStore.Models;
using VideoStore.ViewModels;

namespace VideoStore.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie   dvs www.nissesvideo.se(movie)
        public ActionResult Index()
        {
            var movie = new Movie();
            movie.Name = "Starwars";

            var customer = new Customer();
            customer.Name = "Kalle";
            customer.LastName = "Hooola";

           // var  vm = new ViewModels.ViewModels();
           // var vm = new MovieViewModel();

           
            movie.currentRentingCustomer = customer;




            var movie2 = new Movie();
            movie2.Name = "Starwars - Den nya";

            var customer2= new Customer();
            customer2.Name = "Hans";
            customer2.LastName = "Den andra";

            movie2.currentRentingCustomer = customer2;

            // var  vm = new ViewModels.ViewModels();
            movie.PrevouisRentingCustomer.Add(customer2);
            movie.PrevouisRentingCustomer.Add(customer);

            movie2.PrevouisRentingCustomer.Add(customer2);
            movie2.PrevouisRentingCustomer.Add(customer);




            var vm = new MovieViewModel();

            vm.Movies.Add(movie);
            vm.Movies.Add(movie2);
          


            return View(vm);
        }
    }
}