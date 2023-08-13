namespace MealPlanner.Meals
{
    //32: 
    //
    public class DeluxeTurkeySandwich : IMeal
    {
        public string Name => "Deluxe Turkey Sandwich";
        public List<string> IngredientNames => new List<string> { "Turkey", "Bread", "Lettuce", "Tomato", "Bacon" };
    }
}
