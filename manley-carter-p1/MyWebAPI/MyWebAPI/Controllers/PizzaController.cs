using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyWebAPI.Services.PizzaService;

namespace MyWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        private readonly IPizzaService _pizzaService;

        public PizzaController(IPizzaService pizzaService)
        {
            _pizzaService = pizzaService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Pizza>>> GetAllPizza()
        {
            return _pizzaService.GetAllPizza();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Pizza>> GetOnePizza(int id)
        {
            var result = _pizzaService.GetOnePizza(id);
            if (result is null)
                return NotFound("Total bummer! I couldn't find that type of pizza!");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Pizza>>> AddPizza(Pizza slice)
        {
            var result = _pizzaService.AddPizza(slice);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Pizza>>> UpdatePizza(int id, Pizza request)
        {
            var result = _pizzaService.UpdatePizza(id, request);
            if (result is null)
                return NotFound("Total bummer! I couldn't find that type of pizza!");

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Pizza>>> DeletePizza(int id)
        {

            var result = _pizzaService.DeletePizza(id);
            if (result is null)
                return NotFound("Total bummer! I couldn't find that type of pizza!");

            return Ok(result);
        }
    }
}
