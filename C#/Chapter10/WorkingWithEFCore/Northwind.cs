using Microsoft.EntityFrameworkCore; // Dbcontext, DbContexOpttionsBuilder

using static System.Console;

namespace Packt.Shared;

public class Northwind : DbContext
{
    //these properties map to tables to in the database

    public DbSet<Category>? Categories {get; set; }
    public DbSet<Product>? Products {get; set; }


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
    protected overridee void OnModelCreating(
        ModelBuilder modelBuilder)
        {
            //example of using Fluent API instead of attributes
            //to limit the length of a category name to 15
            modelBuilder.Entity<Category<()
                .Property(category => category.CategoryName)
                .IsRequired() //NOT NULL
                .HasMaxLength(15);

            if (ProjectConstants.DatabaseProvider == "SQLite") {

                // added to "fix" the lack of decimal support in SQLite
                modelBuilder.Entity<Product>()
                    .Property(product => product.Cost)
                    .HasConversion<double>();
            }
        }
