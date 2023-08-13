namespace MealPlanner.Meals
{
    //45: 
    //
    public class TurkeyAndCheeseSandwich : IMeal
    {
        public string Name => "Turkey and Cheese Sandwich";
        public List<string> IngredientNames => new List<string> { "Turkey", "Bread", "Cheese" };
    }
}
