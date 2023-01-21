using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JoyceOfCooking.Models;
using JoyceOfCooking.ViewModels;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JoyceOfCooking.Controllers
{
    public class RecipeController : Controller
    {
        private readonly AppDbContext _context;

        public RecipeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var recipes = _context.Recipes
                .Include(i => i.IngredientList)
                .ThenInclude(n=>n.Ingredients)
                .Include(s => s.InstructionList)
                .ThenInclude(ss=>ss.Instructions)
                .ToList();
            
                
                return View(recipes.ToList());
        }

        public async Task<IActionResult> Alphabet()
        {
            string alphaArrayChar = "abcdefghijklmnopqrstuvwxyz";
            char[] alphaArray = alphaArrayChar.ToCharArray();

            List<string> alphaArraySet = new List<string>();
            foreach (var letter in alphaArray)
            {
                alphaArraySet.Add(letter.ToString());
            }

            List<AlphaAndList> alphaAndListOrama = new List<AlphaAndList>();
            int i = 0;
            while (i < alphaArraySet.Count)
            {
                AlphaAndList alphaAndList = new AlphaAndList();
                alphaAndList.AlphaLetter = alphaArraySet[i];
                string recLetter = alphaArraySet[i];
                alphaAndList.Recipes.Where(r => r.RecipeName.StartsWith(recLetter));
                i++;
                alphaAndListOrama.Add(alphaAndList);
            }

            return View(alphaAndListOrama.ToList());
        }
    }
}
