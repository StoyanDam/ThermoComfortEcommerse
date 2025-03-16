using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using ThermoComfort.Data.Models;

namespace ThermoComfortNew.Domain
{
    public class ApplicationUser:IdentityUser
    {
        public ApplicationUser()
        {
            Orders = new List<Order>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        [Display(Name = "Пълно име")]
        public string? FullName { get { return $"{FirstName} {LastName}"; } }
 
        public ICollection<Order> Orders { get; set; } = new HashSet<Order>();
    }
}
