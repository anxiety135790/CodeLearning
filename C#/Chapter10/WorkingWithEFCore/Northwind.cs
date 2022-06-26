using Microsoft.EntityFrameworkCore;

using static System.Console;

namespace Packt.Shared;

public class Northwind : DbContext
{
    protected override void OnConfiguring(
        DbContextOptionsBuilder optionsBuilder)
        {
            if(ProjectConstants.DatabaseProvider == "SQLite")
            {
                string path = Path.Combine(
                    Environment.CurrentDirectory, " Northwind.db");

                WriteLine($"Using {path} database file.");   
                optionsBuilder.UseSqlit($"Filename{paht}");
                            
            }
            else
            {
                string connection = "Data Source=.;" +
                "Initial Catalog-Northwind;" +
                "Intergated Securty-ture;" +
                "MutipleActiveResultSetes=true;";

                optionsBuilder.UseSqlServer(connection);
            }
        }
}
    
