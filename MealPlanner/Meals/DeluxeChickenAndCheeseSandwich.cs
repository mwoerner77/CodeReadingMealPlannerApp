namespace MealPlanner.Meals
{
    //26: 
    //
    public class DeluxeChickenAndCheeseSandwich : IMeal
    {
        public string Name => "Deluxe Chicken and Cheese Sandwich";
        public List<string> IngredientNames => new List<string> { "Chicken", "Bread", "Lettuce", "Tomato", "Bacon", "Cheese" };
    }
}
