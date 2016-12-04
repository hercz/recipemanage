using System.Collections.Generic;
using System.Collections.ObjectModel;
using recipemanagerforgit.Models;

namespace recipemanagerforgit.ViewModels
{
    class MainViewModel : AbstractMainViewModel
    {
        public ObservableCollection<Recipe> RecipeList { get; set; }
        public MainViewModel()
        {
            FillRececipeListWithTestData();
        }

        public void FillRececipeListWithTestData()
        {
            RecipeList = new ObservableCollection<Recipe>()
            {
                new Recipe { RecipeName = "Kacsacsomb", IngredientList = new List<string> { "Kacsa", "comb" } },
                new Recipe { RecipeName = "sultkolbasy", IngredientList = new List<string> { "diszno", "kolbasz" } },
                new Recipe { RecipeName = "spagetti", IngredientList = new List<string> { "daralthus", "teszta", "paradicsom" } }
            };
        }

        private Recipe myrecipeListSelectedItemRecipe;
        public Recipe RecipeListSelectedItemRecipe
        {
            get
            {
                return myrecipeListSelectedItemRecipe;
            }
            set
            {
                myrecipeListSelectedItemRecipe = value;
                OnPropertyChanged();
            }
        }
    }
}
