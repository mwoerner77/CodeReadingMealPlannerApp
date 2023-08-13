namespace MealPlanner.Meals
{
    //27: 
    //
    public class DeluxeChickenSandwich : IMeal
    {
        public string Name => "Deluxe Chicken Sandwich";
        public List<string> IngredientNames => new List<string> { "Chicken", "Bread", "Lettuce", "Tomato", "Bacon" };
    }
}
