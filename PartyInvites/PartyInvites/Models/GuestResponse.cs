using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage ="Proszę podać imię")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Proszę podać adres e-mail")]
        [RegularExpression(".+\\@.+\\..+" , ErrorMessage ="Proszę podać prawidłowy adres mailowy")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Proszę podać numer telefonu")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Proszę podać czy weźmiesz udział w wydarzeniu")]
        public bool? WillAttend { get; set; }
    }
}