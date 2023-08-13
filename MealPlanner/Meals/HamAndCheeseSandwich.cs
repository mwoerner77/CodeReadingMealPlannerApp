namespace MealPlanner.Meals
{
    //36: 
    //
    public class HamAndCheeseSandwich : IMeal
    {
        public string Name => "Ham and Cheese Sandwich";
        public List<string> IngredientNames => new List<string> { "Ham", "Bread", "Cheese" };
    }
}
