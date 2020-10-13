using Mercado.Aplicattion.Model;
using Mercado.Aplicattion.UseCase.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CleaningProductController : ControllerBase
    {
        private readonly IUseCase<InsertCleaningProductRequest> _insert;

        public CleaningProductController(IUseCase<InsertCleaningProductRequest> insert)
        {
            _insert = insert;
        }

        [HttpPost]
        public IActionResult Insert([FromBody] InsertCleaningProductRequest request)
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
