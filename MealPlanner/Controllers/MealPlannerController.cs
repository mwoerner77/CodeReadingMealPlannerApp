namespace MealPlanner.Controllers
{
    using MealPlanner.Models;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("[controller]")]
    public class MealPlannerController : ControllerBase
    {
        private MealSearcher mealSearcher;

        public MealPlannerController()
        {
            //1: 
            //
            this.mealSearcher = new MealSearcher();
        }

        [HttpGet("GetPossibleMeals")]
        public ActionResult<MealsResponseItem> Get(string mealIngredients)
        {
            //2: 
            //
            List<string> ingredientList = mealIngredients.Split(',').ToList();
            MealsResponseItem mealsResponseItem = new MealsResponseItem
            {
                MealInformation = this.mealSearcher.GetPossibleMeals(ingredientList)
            };

            //3: 
            //
            if (mealsResponseItem.MealInformation != null && mealsResponseItem.MealInformation.Count > 0) 
            {
                return Ok(mealsResponseItem);
            }
            else
            {
                return NotFound();
            }
        }
    }
}