namespace MealPlanner.Meals
{
    //35: 
    //
    public class EggSandwich : IMeal
    {
        public string Name => "Egg Sandwich";
        public List<string> IngredientNames => new List<string> { "Egg", "Bread" };
    }
}
