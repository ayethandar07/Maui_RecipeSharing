using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maui_RecipeDemo.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public List<string> Method { get; set; }
        public string ImageURL { get; set; }
    }
}
