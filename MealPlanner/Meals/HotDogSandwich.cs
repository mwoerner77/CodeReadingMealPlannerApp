namespace MealPlanner.Meals
{
    //38: 
    //
    public class HotDogSandwich : IMeal
    {
        public string Name => "Hot Dog Sandwich";
        public List<string> IngredientNames => new List<string> { "Hot Dog", "Hot Dog Bun" };
    }
}
