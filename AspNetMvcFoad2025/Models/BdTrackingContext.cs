using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AspNetMvcFoad2025.Models
{
	public class BdTrackingContext:DbContext
	{
		public BdTrackingContext() : base("name=connBdTracking") 
		{
		}

		public DbSet<Colis> colis { get; set; }
		public DbSet<UserColis> userColis { get; set; }
		public DbSet<Client> clients { get; set; }
        public DbSet<Administrateur> administrateurs { get; set; }
        public DbSet<Livreur> livreurs { get; set; }
        public DbSet<DemandeColis> demandeColis { get; set; }
		public DbSet<SuiviDemande> suiviDemandes { get; set; }

        public System.Data.Entity.DbSet<AspNetMvcFoad2025.Models.Animal> Animals { get; set; }
    }
}