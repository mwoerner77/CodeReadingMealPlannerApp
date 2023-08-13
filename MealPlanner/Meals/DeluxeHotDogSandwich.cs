namespace MealPlanner.Meals
{
    //30: 
    //
    public class DeluxeHotDogSandwich : IMeal
    {
        public string Name => "Deluxe Hot Dog Sandwich";
        public List<string> IngredientNames => new List<string> { "Hot Dog", "Hot Dog Bun", "Ketchup", "Mustard", "Relish" };
    }
}
