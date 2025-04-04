using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspNetMvcFoad2025.Models
{
	public class Client : UserColis
    {
        [MaxLength(10), Display(Name = "Code Client"), Required(ErrorMessage = "*")]
        public string CodeClient { get; set; }
    }
}