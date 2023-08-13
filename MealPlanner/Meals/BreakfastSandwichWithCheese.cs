namespace MealPlanner.Meals
{
    //22: 
    //
    public class BreakfastSandwichWithCheese : IMeal
    {
        public string Name => "Breakfast Sandwich with Cheese";
        public List<string> IngredientNames => new List<string> { "Ham", "Egg", "Bread", "Cheese" };
    }
}
