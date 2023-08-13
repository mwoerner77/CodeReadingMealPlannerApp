namespace MealPlanner.Meals
{
    //41: 
    //
    public class HotDogSandwichWithRelish : IMeal
    {
        public string Name => "Hot Dog Sandwich with Relish";
        public List<string> IngredientNames => new List<string> { "Hot Dog", "Hot Dog Bun", "Relish" };
    }
}
