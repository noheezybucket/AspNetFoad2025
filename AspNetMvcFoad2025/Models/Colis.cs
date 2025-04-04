using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspNetMvcFoad2025.Models
{
	public class Colis
	{
		[Key]
		public int IdColis { get; set; }

		[MaxLength(15), Required(ErrorMessage = "Champs requis"), Display(Name="Code Colis")]
        public string CodeColis { get; set; }

        [MaxLength(80), Required(ErrorMessage = "Champs requis"), Display(Name = "Libelle Colis")]
        public string LibelleColis { get; set; }

        [MaxLength(1000), Required(ErrorMessage = "Champs requis"), Display(Name = "Description Colis")]
        public string DescriptionColis { get; set; }

        [Display(Name = "Poids Colis")]
        public float PoidsColis { get; set; }

        [MaxLength(20), Required(ErrorMessage = "*"), Display(Name = "Type Colis")]
        public string TypeColis { get; set; }




    }
}