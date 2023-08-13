namespace MealPlanner.Meals
{
    //46: 
    //
    public class TurkeySalad : IMeal
    {
        public string Name => "Turkey Salad";
        public List<string> IngredientNames => new List<string> { "Lettuce", "Tomato", "Turkey" };
    }
}
