using System;
using System.Collection.Generic;
using System.ComponentModel.DataAnnoations;
using System.ComponentModel.DateAnnoations.Schema;
using Miscrosoft.EntityFrameworkCore;

namespace WorkingWithEFCore.AutoGen
{
    [Index(nameof(CategoryName), Name = "CategoryName")]
    public partial class Category
    {
    #region Ctor & Destructor
        /// <summary>
        /// Standard Constructor
        /// </summary>
        public Category()
        {
            Products = new HashSet<Product>();
        }

        [Key]
        public long CategoryId {get; set; }

        [Required]
        [Column(TypeName = "nvarchar (15)")] //SQLite
        [StringLength(15)] //SQL Server
        public string CategoryName {get; set; }

        [Column(TypeName = "ntext")]
        public string? Description {get; set; }

        [Column(TypeName = "image")]
        public byte[]? Picture {get; set; }


        [InverseProperty(nameof(Product.Category))]
        public virtual ICollection<Product> Products {get; set; }


        /// <summary>
        /// Default Destructor
        /// </summary>
        public ~Category()
        {
        }
    #endregion
    }
}
