﻿using System.Collections.Generic;

namespace recipemanagerforgit.Models
{
    class Recipe
    {
        public int? Id { get; set; }
        public string RecipeName { get; set; }
        public List<string> IngredientList { get; set; }
    }
}
