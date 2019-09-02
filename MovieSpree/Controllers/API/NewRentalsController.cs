using MovieSpree.Dtos;
using MovieSpree.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MovieSpree.Controllers.API
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }
        
        [HttpPost]
        public IHttpActionResult CreateRental(NewRentalDto rentalDto)
        {
            /****** 
             Following line of code is using to get Customer from the context and comparing it to rentalDto.
             And here we are using "Single" method because this API will use only internally in an organisation.
             If the API would be used as a public API then we could use "Single or Default" and would check for a valid customerId 
             to prevent from malicious user.
             ******/
            var customer = _context.Customers.Single(c => c.Id == rentalDto.CustomerId);

            /*
             Following line of code is using to get list of Movies and comparing it to rentalDto's movieIds.
             This will translate a SQL statement (Select * FROM Movies WHERE Id IN (1,2,3)); like this.
             */
            var movies = _context.Movies.Where(m => rentalDto.MovieIds.Contains(m.Id)).ToList();

            
            foreach(var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                    return BadRequest("Movies are not avialble");

                movie.NumberAvailable--;        // availability of Movies will decrease by each movie renting.

                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now,
                };
                _context.Rentals.Add(rental);
            }
            _context.SaveChanges();

            return Ok();
        }
    }
}
