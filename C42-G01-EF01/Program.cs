using C42_G01_EF01.Context;
using Microsoft.EntityFrameworkCore;

namespace C42_G01_EF01
{
	internal class Program
	{
		static void Main(string[] args)
		{ 
			CompanyDbContext dbContext = new CompanyDbContext();

			dbContext.Database.Migrate();

		}
	}
}
