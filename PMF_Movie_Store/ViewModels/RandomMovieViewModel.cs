using System.Collections.Generic;
using PMF_Movie_Store.Models;

namespace PMF_Movie_Store.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}