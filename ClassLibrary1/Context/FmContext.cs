using FMData.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMData.Context {
	public class FmContext:DbContext {
		public FmContext(DbContextOptions<FmContext>options) :base(options) {

		}

		public DbSet<User> Users { get; set; }

		//override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
		//	optionsBuilder.UseInMemoryDatabase(databaseName: "BellekVeri");
		//}
	}
}
