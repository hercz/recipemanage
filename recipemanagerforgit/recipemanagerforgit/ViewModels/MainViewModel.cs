using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using recipemanagerforgit.Commands;
using recipemanagerforgit.Models;

namespace recipemanagerforgit.ViewModels
{
    internal class MainViewModel : AbstractMainViewModel
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
                new Recipe { RecipeName = "sultkolbasz", IngredientList = new List<string> { "diszno", "kolbasz" } },
                new Recipe { RecipeName = "spagetti", IngredientList = new List<string> { "daralthus", "teszta", "paradicsom" } }
            };
        }

        private Recipe myRecipeListSelectedItemRecipe;
        public Recipe RecipeListSelectedItemRecipe
        {
            get
            {
                return myRecipeListSelectedItemRecipe;
            }
            set
            {
                myRecipeListSelectedItemRecipe = value;
                OnPropertyChanged();
            }
        }

        public ICommand DeleteRecipeCommand
        {
            get { return new DelegateCommand(DeleteRecipe); }
        }

        private void DeleteRecipe()
        {
            RecipeList.Remove(RecipeListSelectedItemRecipe);
        }
    }
}
