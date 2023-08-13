namespace MealPlanner.Meals
{
    //24: 
    //
    public class ChickenSalad : IMeal
    {
        public string Name => "Chicken Salad";
        public List<string> IngredientNames => new List<string> { "Lettuce", "Tomato", "Chicken" };
    }
}
