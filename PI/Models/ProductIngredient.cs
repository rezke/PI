using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PI.Models
{
    public class ProductIngredient
    {
        public Product Product { get; set;  }
        public Ingredient Ingredient { get; set;  }
        public int Quantity { get; set;  }
        
        [Key, Column(Order = 1)]
        public int ProductId { get; set; }
        [Key, Column(Order = 2)]
        public int IngredientId { get; set;  }

    }
}