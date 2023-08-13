namespace MealPlanner.Meals
{
    //42: 
    //
    public interface IMeal
    {
        public string Name { get; }

        public List<string> IngredientNames { get; }
    }
}
