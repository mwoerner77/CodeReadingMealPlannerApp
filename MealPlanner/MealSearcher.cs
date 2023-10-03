namespace MealPlanner
{
    using MealPlanner.FoodItems;
    using MealPlanner.Meals;
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    public class MealSearcher
    {
        private readonly string mealNamespace = "MealPlanner.Meals";
        private readonly List<string> excludedMealClassNames = new List<string> { "IMeal", "MealFactory" };
        private readonly FoodItemFactory foodItemFactory;
        private readonly MealsFactory mealsFactory;
        private IDictionary<string, IList<string>?> mealIngredients;

        public MealSearcher() 
        {
            //53: 
            //
            this.foodItemFactory = new FoodItemFactory();
            this.mealsFactory = new MealsFactory();
            this.mealIngredients = new Dictionary<string, IList<string>?>();

            //54: 
            //
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type[] allTypes = assembly.GetTypes();
            Type[] mealTypes = Array.FindAll(allTypes, t => t.Namespace == this.mealNamespace);

            //55: 
            //
            foreach (Type type in mealTypes)
            {
                //56: 
                //
                if (!this.excludedMealClassNames.Contains(type.Name))
                {
                    //57: 
                    //
                    IMeal? meal = (IMeal?) Activator.CreateInstance(type);
                    if (meal != null)
                    {
                        this.mealIngredients.Add(meal.Name, meal.IngredientNames);
                    }
                }
            }
        }

        //58: 
        //
        public IList<MealInformation> GetPossibleMeals(string ingredient)
        {
            //59: 
            //
            IList<MealInformation> possibleMealsInformation = new List<MealInformation>();
            foreach (KeyValuePair<string, IList<string>?> mealData in mealIngredients)
            {
                //60: 
                //
                bool? mealContainsAvailableIngredients = mealData.Value?.All(neededIngredient => ingredient == neededIngredient);
                if (mealContainsAvailableIngredients == true)
                {
                    //61: 
                    //
                    MealInformation mealInformation = new MealInformation()
                    {
                        Meal = this.mealsFactory.GetMeal(mealData.Key),
                        MealCalories = this.GetMealCalories(mealData.Key)
                    };

                    possibleMealsInformation.Add(mealInformation);
                }
            }

            return possibleMealsInformation;
        }

        //62: 
        //
        public int GetCalories(string? name)
        {
            //63: 
            //
            int calories = 0;
            IFoodItem? foodItem = this.foodItemFactory.GetFoodItem(name);
            if (foodItem != null)
            {
                return foodItem.Calories;
            }

            //64: 
            //
            return calories;
        }

        //65: 
        //
        public IList<MealInformation> GetPossibleMeals(List<string> ingredients)
        {
            //66: 
            //
            IList<MealInformation> possibleMealsInformation = new List<MealInformation>();
            foreach (KeyValuePair<string, IList<string>?> mealData in mealIngredients)
            {
                //67: 
                //
                bool? mealContainsAvailableIngredients = mealData.Value?.All(neededIngredient => ingredients.Contains(neededIngredient));
                if (mealContainsAvailableIngredients == true)
                {
                    //68: 
                    //
                    MealInformation mealInformation = new MealInformation()
                    {
                        Meal = this.mealsFactory.GetMeal(mealData.Key),
                        MealCalories = this.GetMealCalories(mealData.Key)
                    };

                    possibleMealsInformation.Add(mealInformation);
                }
            }

            return possibleMealsInformation;
        }

        //69: 
        //
        private int GetMealCalories(string? mealName)
        {
            //70: 
            //
            int calories = 0;
            IMeal? meal = this.mealsFactory.GetMeal(mealName);
            
            //71: 
            //
            if (meal != null)
            {
                foreach (string ingredientName in meal.IngredientNames)
                {
                    //72: 
                    //
                    IFoodItem? ingredient = this.foodItemFactory.GetFoodItem(ingredientName);
                    if (ingredient != null)
                    {
                        calories += ingredient.Calories;
                    }
                }
            }
          
            return calories;
        }
    }
}
