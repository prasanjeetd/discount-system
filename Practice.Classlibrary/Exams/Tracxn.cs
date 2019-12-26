using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Practice.Classlibrary.Exams
{
    public class Tracxn
    {
        public void Solution()
        {
            int numberOfDays = 5;
            int numberOfIngredients = 3;

            List<string> ingredients = "FATOil FIBERSpinach CARBRice FATCheese FIBERBeans".Split(" ").ToList();

            int sixty = Convert.ToInt32(Math.Ceiling((60 * numberOfIngredients) * 0.01));

            for (int i = 0; i < numberOfDays; i++)
            {

                if (i < numberOfIngredients || ingredients.Count < numberOfIngredients)
                {
                    Console.Write("-");
                }
                else
                {
                    if (!ProcessFood(ingredients, numberOfIngredients, sixty))
                    {
                        Console.WriteLine("-");
                    }


                }
            }


        }

        bool ProcessFood(List<string> ingredients, int numberOfIngredients, int sixty)
        {
            string catToTake = CatToTake(ingredients, sixty);

            string foodToTake = FoodToTake(ingredients, numberOfIngredients, sixty, catToTake);
            var foodToRemove = foodToTake.Split(":");

            if (foodToRemove.Length == numberOfIngredients)
            {
                Console.Write(foodToTake);
                ingredients.RemoveAll(x => foodToRemove.Contains(x.ToLower()));
                return true;
            }

            return false;

        }

        string CatToTake(List<string> ingredients, int sixty)
        {

            int fatCnt = 0;
            int fibreCnt = 0;
            int cabCnt = 0;

            string catToTake = "fat";

            for (int i = 0; i < ingredients.Count; i++)
            {
                string foodItem = ingredients[i];

                if (foodItem.ToLower().StartsWith("fat"))
                {
                    fatCnt++;
                }
                else if (foodItem.ToLower().StartsWith("fiber"))
                {
                    fibreCnt++;
                }
                else
                {
                    cabCnt++;
                }

                if (fatCnt >= sixty)
                {
                    catToTake = "fat";
                    break;
                }
                else if (fibreCnt >= sixty)
                {
                    catToTake = "fibre";
                    break;
                }
                else if (cabCnt >= sixty)
                {
                    catToTake = "cab";
                    break;
                }

            }

            return catToTake;
        }

        string FoodToTake(List<string> ingredients, int numberOfIngredients, int sixty, string catToTake)
        {
            string foodToTake = "";

            int catCnt = 0;
            int nonCatCnt = 0;
            int foodCnt = 0;
            int maxNonCatFood = numberOfIngredients - sixty;

            for (int i = 0; i < ingredients.Count; i++)
            {
                string foodItem = ingredients[i].ToLower();

                if (foodItem.StartsWith(catToTake))
                {
                    catCnt++;

                    if (foodToTake != "")
                    {
                        foodToTake = foodToTake + ":" + foodItem;
                    }
                    else
                    {
                        foodToTake = foodItem;
                    }

                    foodCnt++;

                }
                else if (nonCatCnt < maxNonCatFood)
                {
                    nonCatCnt++;

                    if (foodToTake != "")
                    {
                        foodToTake = foodToTake + ":" + foodItem;
                    }
                    else
                    {
                        foodToTake = foodItem;
                    }


                    foodCnt++;
                }

                if (foodCnt == numberOfIngredients)
                {
                    break;
                }

            }

            return foodToTake;
        }
    }
}
