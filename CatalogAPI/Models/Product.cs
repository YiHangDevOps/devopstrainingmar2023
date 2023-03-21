using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatalogAPI.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
//fdsafdsafdsalfdsafjdsalkfjkl
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Product_Id")]
        public long ProductId { get; set; }
        public ProductDescription Description { get; set; }
	//user3 testing
        [ForeignKey("Catalog")]
        [Column("Catalog_Id_FK")]
        public long CatalogId { get; set; }
        public Catalog Catalog { get; set; }
    }
}
