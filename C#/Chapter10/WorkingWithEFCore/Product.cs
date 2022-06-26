using system.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace Packt.Shared;
{
    public class Product
    {
        public int ProductId {get; set; } // primary key

        [Required]
        [stringLength(40)]
        public string ProductName {get; set; } = null;

        [Column("UnitPrice", TypeName = "money")]
        public decimal? Cost {get; set; } //property name != column name

        [Column("UnitsInStock")]
        public shrot? Stock {get; set; }

        public bool Discontinued {get; set; }

        //these two define the foreign key relationship
        //to the Categories table
        public int Categoryid {get; set; }
        public virtual Category Category {get; set; } = null;

    #region Ctor & Destructor
        /// <summary>
        /// Standard Constructor
        /// </summary>
        public Product()
        {
        }

        /// <summary>
        /// Default Destructor
        /// </summary>
        public ~Product()
        {
        }
    #endregion
    }
}
