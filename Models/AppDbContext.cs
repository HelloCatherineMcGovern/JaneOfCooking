using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace JoyceOfCooking.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<IngredientList> IngredientLists { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Instruction> Instructions { get; set; }
        public DbSet<InstructionList> InstructionLists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Recipe>().HasData(new Recipe
            {
                RecipeId = 1,
                RecipeName = "Ham and Cheese Quiche",
                IngredientListId = 1,
                InstructionListId = 1,
            });

            modelBuilder.Entity<Recipe>().HasData(new Recipe
            {
                RecipeId = 2,
                RecipeName = "Spinach Quiche",
                IngredientListId = 2,
                InstructionListId = 2,
            });

            modelBuilder.Entity<IngredientList>().HasData(new IngredientList
            {
                IngredientListId = 1,
            });

            modelBuilder.Entity<IngredientList>().HasData(new IngredientList
            {
                IngredientListId = 2,
            });

            //Recipe List 1 Ingredient Seed
            //Recipe List 1 Ingredient Seed
            //Recipe List 1 Ingredient Seed
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient
            {
                IngredientId = 1,
                IngredientText = "3 eggs",
                IngredientListId = 1,  //Foreign Key
            });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient
            {
                IngredientId = 2,
                IngredientText = "1-1/2 c. milk",
                IngredientListId = 1,  //Foreign Key
            });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient
            {
                IngredientId = 3,
                IngredientText = "1-1/2 c. shredded cheese",
                IngredientListId = 1,  //Foreign Key
            });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient
            {
                IngredientId = 4,
                IngredientText = "1 c. cooked meat &/or veg",
                IngredientListId = 1,  //Foreign Key
            });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient
            {
                IngredientId = 5,
                IngredientText = "herbs, salt, pepper",
                IngredientListId = 1,  //Foreign Key
            });



            //Recipe 1 Ingredient Seed
            //Recipe 1 Ingredient Seed
            //Recipe 1 Ingredient Seed
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient
            {
                IngredientId = 6,
                IngredientText = "3 eggs",
                IngredientListId = 2,  //Foreign Key
            });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient
            {
                IngredientId = 7,
                IngredientText = "1-1/2 c. milk",
                IngredientListId = 2,  //Foreign Key
            });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient
            {
                IngredientId = 8,
                IngredientText = "1-1/2 c. shredded cheese",
                IngredientListId = 2,  //Foreign Key
            });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient
            {
                IngredientId = 9,
                IngredientText = "1 c. cooked meat &/or veg",
                IngredientListId = 2,  //Foreign Key
            });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient
            {
                IngredientId = 10,
                IngredientText = "herbs, salt, pepper",
                IngredientListId = 2,  //Foreign Key
            });



            //INSTRUCTION LIST SEED
            modelBuilder.Entity<InstructionList>().HasData(new InstructionList
            {
                InstructionListId = 1,
           
            });
            modelBuilder.Entity<InstructionList>().HasData(new InstructionList
            {
                InstructionListId = 2,

            });

            //INSTRUCTION LIST SEED - RECIPE LIST 1

            modelBuilder.Entity<Instruction>().HasData(new Instruction
            {
                InstructionId = 1,
                InstructionText = "Bake crust according to directions",
                InstructionListId = 1,
            });
            modelBuilder.Entity<Instruction>().HasData(new Instruction
            {
                InstructionId = 2,
                InstructionText = "Beat other ingredients together",
                InstructionListId = 1,
            });
            modelBuilder.Entity<Instruction>().HasData(new Instruction
            {
                InstructionId = 3,
                InstructionText = "Cook at 325 degrees for 50 minutes",
                InstructionListId = 1,
            });


            //INSTRUCTION LIST SEED - RECIPE LIST 2

            modelBuilder.Entity<Instruction>().HasData(new Instruction
            {
                InstructionId = 4,
                InstructionText = "Bake crust according to directions",
                InstructionListId = 2,
            });
            modelBuilder.Entity<Instruction>().HasData(new Instruction
            {
                InstructionId = 5,
                InstructionText = "Beat other ingredients together",
                InstructionListId = 1,
            });
            modelBuilder.Entity<Instruction>().HasData(new Instruction
            {
                InstructionId = 6,
                InstructionText = "Cook at 325 degrees for 50 minutes",
                InstructionListId = 1,
            });

        }




    }
}
