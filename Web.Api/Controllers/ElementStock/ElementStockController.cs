using Mercado.Aplicattion.Model;
using Mercado.Aplicattion.UseCase.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ElementStockController : ControllerBase
    {
        private readonly IUseCase<InsertElementStockRequest> _insert;

        public ElementStockController(IUseCase<InsertElementStockRequest> insert)
        {
            _insert = insert;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Insert([FromBody] InsertElementStockRequest request)
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
