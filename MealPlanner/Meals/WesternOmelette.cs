namespace MealPlanner.Meals
{
    //48: 
    //
    public class WesternOmelette : IMeal
    {
        public string Name => "Western Omelette";
        public List<string> IngredientNames => new List<string> { "Egg", "Cheese", "Ham" };
    }
}
