namespace MealPlanner.Meals
{
    //31: 
    //
    public class DeluxeTurkeyAndCheeseSandwich : IMeal
    {
        public string Name => "Deluxe Turkey and Cheese Sandwich";
        public List<string> IngredientNames => new List<string> { "Turkey", "Bread", "Lettuce", "Tomato", "Bacon", "Cheese" };
    }
}
