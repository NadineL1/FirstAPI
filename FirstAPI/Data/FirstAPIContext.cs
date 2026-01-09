using FirstAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace FirstAPI.Data
{
	public class FirstAPIContext : DbContext
	{
		public FirstAPIContext(DbContextOptions<FirstAPIContext> options) : base(options) { }
	
		public DbSet<Book> Books { get; set; }



	}
}
