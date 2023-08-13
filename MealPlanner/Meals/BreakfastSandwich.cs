namespace MealPlanner.Meals
{
    //20: 
    //
    public class BreakfastSandwich : IMeal
    {
        public string Name => "Breakfast Sandwich";
        public List<string> IngredientNames => new List<string> { "Ham", "Egg", "Bread" };
    }
}
