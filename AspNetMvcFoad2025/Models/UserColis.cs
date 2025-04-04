using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspNetMvcFoad2025.Models
{
	public class UserColis
	{
		[Key]
		public int IdUserColis { get; set; }

		[MaxLength(80), Display(Name ="Nom"), Required(ErrorMessage ="*")]
        public string Nom { get; set; }

		[MaxLength(80), Display(Name ="Prenom"), Required(ErrorMessage ="*")]
        public string Prenom { get; set; }

		[MaxLength(20), Display(Name ="CNI"), Required(ErrorMessage ="*")]
        public string CNI { get; set; }

		[MaxLength(15), Display(Name ="Telephone"), Required(ErrorMessage ="*")]
        public string Telephone { get; set; }


		[MaxLength(80), Display(Name ="Email"), Required(ErrorMessage ="*")]
        public string Email { get; set; }


		[MaxLength(150), Display(Name ="Adresse"), Required(ErrorMessage ="*")]
        public string Adresse { get; set; }


		[MaxLength(10), Display(Name ="Statut"), Required(ErrorMessage ="*")]
        public string Statut { get; set; }



    }
}