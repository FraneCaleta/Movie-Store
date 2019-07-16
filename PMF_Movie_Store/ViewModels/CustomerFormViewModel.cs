using System.Collections.Generic;
using PMF_Movie_Store.Models;

namespace PMF_Movie_Store.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}