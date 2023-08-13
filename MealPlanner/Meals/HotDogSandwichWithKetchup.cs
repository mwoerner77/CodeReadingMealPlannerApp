namespace MealPlanner.Meals
{
    //39: 
    //
    public class HotDogSandwichWithKetchup : IMeal
    {
        public string Name => "Hot Dog Sandwich with Ketchup";
        public List<string> IngredientNames => new List<string> { "Hot Dog", "Hot Dog Bun", "Ketchup" };
    }
}
