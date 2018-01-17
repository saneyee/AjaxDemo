using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace AjaxDemo.Models
{
	public class AjaxDemoContext : DbContext
	{
		public AjaxDemoContext()
		{
		}


		public virtual DbSet<Destination> Destinations { get; set; }
		

		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
			options.UseMySql(@"Server=localhost;Port=8889;database=project;uid=root;pwd=root;");
		}

		public AjaxDemoContext(DbContextOptions<AjaxDemoContext> options)
			: base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
		}
	}
}
    


