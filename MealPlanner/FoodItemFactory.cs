namespace MealPlanner
{
    using MealPlanner.FoodItems;

    public class FoodItemFactory
    {
        public IFoodItem? GetFoodItem(string? foodName)
        {
            //50: 
            //
            if (foodName == null)
                return null;

            //51: 
            //
            switch (foodName.ToLower())
            {
                case "bacon":
                    return new Bacon();
                case "bread":
                    return new Bread();
                case "cheese":
                    return new Cheese();
                case "chicken":
                    return new Chicken();
                case "egg":
                    return new Egg();
                case "ham":
                    return new Ham();
                case "hot dog":
                    return new HotDog();
                case "hot dog bun":
                    return new HotDogBun();
                case "ketchup":
                    return new Ketchup();
                case "lettuce":
                    return new Lettuce();
                case "mustard":
                    return new Mustard();
                case "relish":
                    return new Relish();
                case "tomato":
                    return new Tomato();
                case "turkey":
                    return new Turkey();
                default:
                    return null;
            }
        }
    }
}
