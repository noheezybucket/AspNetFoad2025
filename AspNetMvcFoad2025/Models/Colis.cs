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

		[MaxLength(30, ErrorMessage ="Chaine trop longue"), Required(ErrorMessage = "Champs requis"), Display(Name="Code Colis")]
        public string CodeColis { get; set; }

        [MaxLength(30, ErrorMessage = "Chaine trop longue"), Required(ErrorMessage = "Champs requis"), Display(Name = "Libelle Colis")]
        public string LibelleColis { get; set; }

        [MaxLength(1000, ErrorMessage = "Chaine trop longue"), Required(ErrorMessage = "Champs requis"), Display(Name = "Description Colis")]
        public string DescriptionColis { get; set; }




    }
}