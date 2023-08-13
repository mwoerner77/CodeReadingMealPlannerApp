namespace MealPlanner
{
    using MealPlanner.Meals;

    public class MealsFactory
    {
        //73: 
        //
        public IMeal? GetMeal(string? mealName)
        {  
            if (mealName != null)
            {
                switch (mealName.ToLower())
                {
                    case "blt sandwich":
                        return new BLTSandwich();
                    case "breakfast sandwich":
                        return new BreakfastSandwich();
                    case "breakfast sandwich with cheese":
                        return new BreakfastSandwichWithCheese();
                    case "chicken and cheese sandwich":
                        return new ChickenAndCheeseSandwich();
                    case "chicken salad":
                        return new ChickenSalad();
                    case "chicken sandwich":
                        return new ChickenSandwich();
                    case "deluxe chicken and cheese sandwich":
                        return new DeluxeChickenAndCheeseSandwich();
                    case "deluxe chicken sandwich":
                        return new DeluxeChickenSandwich();
                    case "deluxe ham and cheese sandwich":
                        return new DeluxeHamAndCheeseSandwich();
                    case "deluxe ham sandwich":
                        return new DeluxeHamSandwich();
                    case "deluxe hot dog sandwich":
                        return new DeluxeHotDogSandwich();
                    case "deluxe turkey and cheese sandwich":
                        return new DeluxeTurkeyAndCheeseSandwich();
                    case "deluxe turkey sandwich":
                        return new DeluxeTurkeySandwich();
                    case "egg and cheese omelette":
                        return new EggAndCheeseOmelette();
                    case "egg and cheese sandwich":
                        return new EggAndCheeseSandwich();
                    case "egg sandwich":
                        return new EggSandwich();
                    case "ham and cheese sandwich":
                        return new HamAndCheeseSandwich();
                    case "ham sandwich":
                        return new HamSandwich();
                    case "hot dog sandwich":
                        return new HotDogSandwich();
                    case "hot dog sandwich with ketchup":
                        return new HotDogSandwichWithKetchup();
                    case "hot dog sandwich with mustard":
                        return new HotDogSandwichWithMustard();
                    case "hot dog sandwich with relish":
                        return new HotDogSandwichWithRelish();
                    case "salad":
                        return new Salad();
                    case "scrambled eggs":
                        return new ScrambledEggs();
                    case "turkey and cheese sandwich":
                        return new TurkeyAndCheeseSandwich();
                    case "turkey salad":
                        return new TurkeySalad();
                    case "turkey sandwich":
                        return new TurkeySandwich();
                    case "western omelette":
                        return new WesternOmelette();
                    default:
                        return null;
                }
            }
            return null;
        }
    }
}
