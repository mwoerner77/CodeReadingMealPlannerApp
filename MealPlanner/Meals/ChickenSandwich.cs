namespace MealPlanner.Meals
{
    //25: 
    //
    public class ChickenSandwich : IMeal
    {
        public string Name => "Chicken Sandwich";
        public List<string> IngredientNames => new List<string> { "Chicken", "Bread" };
    }
}
