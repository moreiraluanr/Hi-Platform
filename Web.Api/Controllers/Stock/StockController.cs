using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mercado.Aplicattion.Model;
using Mercado.Aplicattion.UseCase.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StockController : ControllerBase
    {
        private readonly IUseCase<InsertStockRequest> _insert;

        public StockController(IUseCase<InsertStockRequest> insert)
        {
            _insert = insert;
        }

        [HttpPost]
        public IActionResult Insert([FromBody] InsertStockRequest request)
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
