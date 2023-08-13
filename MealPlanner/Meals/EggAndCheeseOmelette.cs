namespace MealPlanner.Meals
{
    //33: 
    //
    public class EggAndCheeseOmelette : IMeal
    {
        public string Name => "Egg and Cheese Omelette";
        public List<string> IngredientNames => new List<string> { "Egg", "Cheese" };
    }
}
