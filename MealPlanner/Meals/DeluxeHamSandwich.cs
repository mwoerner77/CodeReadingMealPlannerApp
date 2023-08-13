namespace MealPlanner.Meals
{
    //29: 
    //
    public class DeluxeHamSandwich : IMeal
    {
        public string Name => "Deluxe Ham Sandwich";
        public List<string> IngredientNames => new List<string> { "Ham", "Bread", "Lettuce", "Tomato", "Bacon" };
    }
}
