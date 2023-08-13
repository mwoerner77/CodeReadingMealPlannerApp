namespace MealPlanner.Meals
{
    //40: 
    //
    public class HotDogSandwichWithMustard : IMeal
    {
        public string Name => "Hot Dog Sandwich with Mustard";
        public List<string> IngredientNames => new List<string> { "Hot Dog", "Hot Dog Bun", "Mustard" };
    }
}
