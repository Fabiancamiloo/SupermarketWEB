using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupermarketWEB.Models
{
    public class Product
    {
        // [Key] -> Anotacion si la propiedad no se llama Id, ejemplo ProducId
        public int Id { get; set; } // Sera la llave promaria
        public string Name { get; set; }

        [Column(TypeName = "decimal(6,2)")]
        public decimal Price { get; set; }
        public int Stock {  get; set; }
        public int CategoryId { get; set; } // Sera la llave foranea
        public Category Category { get; set; } // Propiedad de navegacion
    }
}
