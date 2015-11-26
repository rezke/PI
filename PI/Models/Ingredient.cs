using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PI.Models
{
    public class Ingredient
    {
        public int IngredientId { get; set; }
        public string Name { get; set;  }
        public string Unit { get; set;  }

        public virtual List<ProductIngredient> ProductIngredients { get; set;  }

    }
}