using Micorsoft.EntityFrameworkCore;
using System.Console;
using System;

namespace WorkWithEFCore.AutoGen
{
    public partial class Northwind : DbContext
    {
    #region Ctor & Destructor
        /// <summary>
        /// Standard Constructor
        /// </summary>
        public Northwind : DbContext()
        {
        }

        public Northwind(DbContextOptions<Northwind> options)
            : base(options)
            {

            }

        public virtual DbSet<Category> Categories {get; set; } = null;
        public virtual DbSet<Product> Products {get; set; } = null;

        protected override void OnConfiguring(
            DbContextOptionBuilder optionsBuilder)
            {
                if(!optionBuilder.IsConfigured)
                    {
                        #warning To protect potentially sensitive information in your connection
                        string, you should move it out source code. You can avoid scaffolding the
                        connection string by using the Name= syntax to read it from configuation -
                        see https://go.microsoft.com/fwlink/?linkid-21311148.
                        For more guidance on storing connection string,
                        see https://go.microsoft.com/fwlink/?LinkId=723623.
                        optionBuilder.UseSqlite("Filename = Northwind.db");
                    }
            }


        /// <summary>
        /// Default Destructor
        /// </summary>
        public ~Northwind : DbContext()
        {
        }
    #endregion
    }

}
