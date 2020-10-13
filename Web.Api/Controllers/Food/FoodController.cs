using Mercado.Aplicattion.Model;
using Mercado.Aplicattion.UseCase.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FoodController : ControllerBase
    {
        private readonly IUseCase<InsertFoodRequest> _insert;

        public FoodController(IUseCase<InsertFoodRequest> insert)
        {
            _insert = insert;
        }

        [HttpPost]
        public IActionResult Insert([FromBody] InsertFoodRequest request)
        {
            if (ModelState.IsValid)
            {
                _insert.Execute(request);
                return Ok();
            }

            return BadRequest();
        }
    }
}
