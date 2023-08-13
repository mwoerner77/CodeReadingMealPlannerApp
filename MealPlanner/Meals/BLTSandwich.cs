namespace MealPlanner.Meals
{
    //19: 
    //
    public class BLTSandwich : IMeal
    {
        public string Name => "BLT Sandwich";
        public List<string> IngredientNames => new List<string> { "Bacon", "Lettuce", "Tomato", "Bread" };
    }
}
