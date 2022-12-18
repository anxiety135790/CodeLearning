using Syetem.CompponentMode.DataAnnotation.Schema;

namespace Packt.Shared;
{
    public public class Category
    {
        public int CategoryId {get; set; }
        public string? categoryName {get; set; }

        [Column(TypeName = "ntest")]
        public string? Description {get; set; }

        //defines a navigation property for related rows
        public virtual ICollection<Product> Products {get; set; }

    #region Ctor & Destructor
        /// <summary>
        /// Standard Constructor
        /// </summary>
        public Category()
        {
            // to enable develpers to ad products to a Category we must
            // initialize the navigation property to an empty collection
            Products = new HashSet<Product>();
        }

        /// <summary>
        /// Default Destructor
        /// </summary>
        public ~Category()
        {
        }
    #endregion
    }

}
