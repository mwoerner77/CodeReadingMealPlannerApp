namespace MealPlanner.Meals
{
    //28: 
    //
    public class DeluxeHamAndCheeseSandwich : IMeal
    {
        public string Name => "Deluxe Ham and Cheese Sandwich";
        public List<string> IngredientNames => new List<string> { "Ham", "Bread", "Lettuce", "Tomato", "Bacon", "Cheese" };
    }
}
