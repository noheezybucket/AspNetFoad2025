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

		public DbSet<Colis> Colis { get; set; }
    }
}