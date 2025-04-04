using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspNetMvcFoad2025.Models
{
	public class Livreur: UserColis
    {
        [MaxLength(20), Display(Name = "Matricule"), Required(ErrorMessage = "*")]
        public string Matricule { get; set; }

        [MaxLength(20), Display(Name = "Carte grise"), Required(ErrorMessage = "*")]
        public string CarteGrise { get; set; }

        [MaxLength(25), Display(Name = "Permis"), Required(ErrorMessage = "*")]
        public string Permis { get; set; }


    }
}