namespace MealPlanner.Meals
{
    //37: 
    //
    public class HamSandwich : IMeal
    {
        public string Name => "Ham Sandwich";
        public List<string> IngredientNames => new List<string> { "Ham", "Bread" };
    }
}
