namespace MealPlanner.Meals
{
    //23: 
    //
    public class ChickenAndCheeseSandwich : IMeal
    {
        public string Name => "Chicken and Cheese Sandwich";
        public List<string> IngredientNames => new List<string> { "Chicken", "Bread", "Cheese" };
    }
}
