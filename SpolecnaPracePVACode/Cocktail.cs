﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpolecnaPracePVACode
{
    internal class Cocktail
    {
        public string idDrink { get; set; }
        public string strDrink { get; set; }
        public string strGlass { get; set; }
        public string strAlcoholic { get; set; }
        public string strCategory { get; set; }
        public string strInstructions { get; set; }
        public string strDrinkThumb { get; set; }

        // Ingredience 1–15
        public string strIngredient1 { get; set; }
        public string strIngredient2 { get; set; }
        public string strIngredient3 { get; set; }
        public string strIngredient4 { get; set; }
        public string strIngredient5 { get; set; }
        public string strIngredient6 { get; set; }
        public string strIngredient7 { get; set; }
        public string strIngredient8 { get; set; }
        public string strIngredient9 { get; set; }
        public string strIngredient10 { get; set; }
        public string strIngredient11 { get; set; }
        public string strIngredient12 { get; set; }
        public string strIngredient13 { get; set; }
        public string strIngredient14 { get; set; }
        public string strIngredient15 { get; set; }

        public List<string> GetIngredients()
        {
            return new List<string?>
            {
                strIngredient1, strIngredient2, strIngredient3, strIngredient4, strIngredient5,
                strIngredient6, strIngredient7, strIngredient8, strIngredient9, strIngredient10,
                strIngredient11, strIngredient12, strIngredient13, strIngredient14, strIngredient15
            }.Where(i => !string.IsNullOrWhiteSpace(i)).ToList()!; // Vrátí jen ty ingredience, které nejsou null nebo prázdné
        }
    }
}
