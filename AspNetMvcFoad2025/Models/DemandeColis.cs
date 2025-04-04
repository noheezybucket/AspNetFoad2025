using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AspNetMvcFoad2025.Models
{
	public class DemandeColis
	{
		[Key]
		public int IdDemandeColis { get; set; }

		[Display(Name = "Client")]
        public int? IdClient { get; set; }
		[ForeignKey("IdClient")]
		public virtual Client Client { get; set; }


        [Display(Name = "Livreur")]
        public int? IdLivreur { get; set; }
        [ForeignKey("IdLivreur")]
        public virtual Livreur Livreur { get; set; }


        [Display(Name = "Colis")]
        public int? IdColis { get; set; }
        [ForeignKey("IdColis")]
        public virtual Colis Colis { get; set; }


        [DataType(DataType.Date), Display(Name = "Date Livree"), Required(ErrorMessage = "*")]
        public DateTime DateLivrer { get; set; }

        [DataType(DataType.Date), Display(Name = "Date souhaitee"), Required(ErrorMessage = "*")]
        public DateTime DateSouhaiter { get; set; }

        [DataType(DataType.Date), Display(Name = "Date demandee"), Required(ErrorMessage = "*")]
        public DateTime DateDemande { get; set; }

        [MaxLength(15), Display(Name = "Statut"), Required(ErrorMessage = "*")]
        public string Statut { get; set; }

        [MaxLength(25), Display(Name = "Lieu de depart"), Required(ErrorMessage = "*")]
        public string LieuDepart { get; set; }

        [MaxLength(25), Display(Name = "Lieu de arrivee"), Required(ErrorMessage = "*")]
        public string LieuArrivee { get; set; }

        [Display(Name = "Prix"), Required(ErrorMessage = "*")]
        public float Prix { get; set; }


    }
}