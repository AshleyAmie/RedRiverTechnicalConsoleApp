using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedRiverTechnicalConsole
{
    class RedRiverTechnical
    {
        /* Displays the selection question for the customer and 
         * takes input for Lemon Tea, Coffee, or Chocolate and 
         * their possible permutations.
         */
        static void Main(string[] args)
        {
            // empty string that will hold one of the three recipes
            string recipe = "";
            // boolean value validates the input.
            bool validInput = true;

            // If the user's input is invalid, asks for a new input until the input is acceptable
            do
            {
                // States the question
                Console.WriteLine("Please choose a recipe from the options: Lemon Tea, Coffee, or Chocolate.");
                // Takes the user's input
                string userInput = Console.ReadLine();

                // Verifies whether the input is acceptable
                validInput = VerifyInput(userInput);

                // If the input was valid, start the recipe
                if (validInput)
                {
                    recipe = userInput;
                    StartRecipe(recipe);
                } // If invalid, ask the customer to input a new order
                else
                {
                    Console.WriteLine("Invalid Input.");
                }
            } while (!validInput);

            Console.ReadKey();
        }

        /* Checks if the input is valid and returns the result.
         */
        private static bool VerifyInput(string userInput)
        {
            if (userInput == "Lemon Tea" || userInput == "lemon tea" || userInput == "tea" ||
                userInput == "Hot Chocolate" || userInput == "hot chocolate" || userInput == "chocolate" ||
                userInput == "Chocolate" || userInput == "Coffee" || userInput == "coffee")
            {
                // The input is acceptable
                return true;
            }
            else
            {
                // The input is not acceptable
                return false;
            }
        }

        /* Determines which recipe the user selected and begins 
         * preparations dependent on that order
         */
        private static void StartRecipe(string recipe)
        {
            // Reassigns string recipe to the correct term for a given recipe
            if (recipe == "Lemon Tea" || recipe == "lemon tea" || recipe == "tea")
            {
                recipe = "Lemon Tea";
            }
            else if (recipe == "Coffee" || recipe == "coffee")
            {
                recipe = "Coffee";
            }
            else
            {
                recipe = "Chocolate";
            }

            // Begins the process in a given order based on the recipe
            BoilWater(recipe);

            if (recipe == "Chocolate")
            {
                // Add the chocolate powder to the Chocolate
                AddToDrink(recipe);
                // Pour the chocolate into the cup
                PourDrink(recipe);
            }
            else
            {
                // Steeps/Brews the tea or coffee
                SteepDrink(recipe);
                // Pours the tea or coffee into a cup
                PourDrink(recipe);
                // Adds lemon or milk and sugar to the cup
                AddToDrink(recipe);
            }
        }

        /* Boils the water for the given recipe
         */ 
        private static void BoilWater(string recipe)
        {
            Console.WriteLine("Boiling water for " + recipe);
            Console.ReadKey();
        }

        /* Steeps the tea or coffee for three minutes
         */
        private static void SteepDrink(string recipe)
        {
            // string variable that prevents repeated code
            string lengthOfTime = " for three minutes.";

            // Determines whether the drink needs to steep or brew
            if (recipe == "Lemon Tea")
            {
                Console.WriteLine("Steeping " + recipe + lengthOfTime);
            }
            else
            {
                Console.WriteLine("Brewing " + recipe + lengthOfTime);
            }
            Console.ReadKey();
        }

        /* Pours the selected drink into a cup
         */
        private static void PourDrink(string recipe)
        {
            Console.WriteLine("Pouring " + recipe + " into cup.");
            Console.ReadKey();
        }

        /* Adds lemon, milk and sugar, or drinking chocolate to 
         * the drink
         */
        private static void AddToDrink(string recipe)
        {
            // String variables that prevent repeated code
            string adding = "Adding ";
            string additive = "";

            // Determines what needs to be added to the drink based on the recipe
            if (recipe == "Lemon Tea")
            {
                additive = "lemon to ";
            }
            else if (recipe == "Coffee")
            {
                additive = "milk and sugar to ";
            }
            else
            {
                additive = "drinking chocolate powder to ";
            }

            Console.WriteLine(adding + additive + recipe + ".");
        }
    }
}
