namespace MealPlanner.Meals
{
    //43: 
    //
    public class Salad : IMeal
    {
        public string Name => "Salad";
        public List<string> IngredientNames => new List<string> { "Lettuce", "Tomato" };
    }
}
