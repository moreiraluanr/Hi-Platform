using Mercado.Aplicattion.Model;
using Mercado.Aplicattion.UseCase.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MarketResearchController : ControllerBase
    {
        private readonly IUseCase<InsertMarketResearchRequest> _insert;

        public MarketResearchController(IUseCase<InsertMarketResearchRequest> insert)
        {
            _insert = insert;
        }

        [HttpPost]
        public IActionResult Insert([FromBody] InsertMarketResearchRequest request)
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
