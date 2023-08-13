namespace MealPlanner.Meals
{
    //47: 
    //
    public class TurkeySandwich : IMeal
    {
        public string Name => "Turkey Sandwich";
        public List<string> IngredientNames => new List<string> { "Turkey", "Bread" };
    }
}
