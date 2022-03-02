
using Microsoft.AspNetCore.Mvc;
using OpenApiDemo.Models;

namespace OpenApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MealboxController : ControllerBase
    {
        [HttpGet]
        [Route("GetMealboxes")]
        public ActionResult<List<Mealbox>> GetMealboxes()
        {
            return new OkObjectResult(new List<Mealbox>()
            {
                new Mealbox("TestMealbox", DateTime.Now, new List<Recipe>()
                {
                    new Recipe("Pizza", 3, new List<string>()
                    {
                        "Flour", "Tomatosauce", "Cheese"
                    }),
                    new Recipe("Steak and fries", 2, new List<string>()
                    {
                        "Steak", "Fries", "Sauce", "A lot of wine"
                    })
                    
                }),
                new Mealbox("TestMealbox2", DateTime.Now, new List<Recipe>()
                {
                    new Recipe("Pizza", 3, new List<string>()
                    {
                        "Flour", "Tomatosauce", "Cheese"
                    }),
                    new Recipe("Steak and fries", 2, new List<string>()
                    {
                        "Steak", "Fries", "Sauce", "A lot of wine"
                    })
                    
                })
            });
        }
    }
}