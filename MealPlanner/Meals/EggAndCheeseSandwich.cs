namespace MealPlanner.Meals
{
    //34: 
    //
    public class EggAndCheeseSandwich : IMeal
    {
        public string Name => "Egg and Cheese Sandwich";
        public List<string> IngredientNames => new List<string> { "Egg", "Bread", "Cheese" };
    }
}
