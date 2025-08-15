using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspNetMvcFoad2025.Models
{
	public class Animal
	{

        [Key]
        public int Id { get; set; }

        [MaxLength(50), Display(Name = "Nom"), Required(ErrorMessage = "*")]
        public string Nom { get; set; }

        [MaxLength(30), Display(Name = "Type"), Required(ErrorMessage = "*")]
        public string Type { get; set; }

        [MaxLength(30), Display(Name = "Sexe"), Required(ErrorMessage = "*")]
        public string Sexe { get; set; }

        [Display(Name = "Poids"), Required(ErrorMessage = "*")]
        public float Poids { get; set; }

        [Display(Name = "Taille"), Required(ErrorMessage = "*")]
        public float Taille { get; set; }

        [DataType(DataType.Date), Display(Name = "Date De Naissance"), Required(ErrorMessage = "*")]
        public DateTime? DateNaissance { get; set; }
    }
}