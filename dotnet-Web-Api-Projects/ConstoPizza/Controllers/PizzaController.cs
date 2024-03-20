using ConstoPizza.Models;
using ConstoPizza.Services;
using Microsoft.AspNetCore.Mvc;

namespace ConstoPizza.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class PizzaController:Controller
    {
        public PizzaController()
        {

        }
        //TODO : check Difference between ActionResut and IActionResult

        [HttpGet]
        public ActionResult<List<Pizza>> GetAllPizzas()=>PizzaServices.GetAllPizzas();


        [HttpGet("{id}")]
        public ActionResult<Pizza> Get(int id)
        {
            var pizza = PizzaServices.GetPizzaById(id);

            if (pizza == null)
                return NotFound();

            return pizza;
        }
    }
}
