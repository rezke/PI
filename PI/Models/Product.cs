using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PI.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set;  }

        public virtual List<ProductIngredient> ProductIngredients { get; set;  }

    }
}