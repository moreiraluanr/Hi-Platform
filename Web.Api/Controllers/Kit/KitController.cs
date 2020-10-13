using Mercado.Aplicattion.Model;
using Mercado.Aplicattion.UseCase.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class KitController : ControllerBase
    {
        private IUseCase<ListKitRequest, ListKitResponse> _list;

        public KitController(IUseCase<ListKitRequest, ListKitResponse> list)
        {
            _list = list;
        }

        [HttpGet]
        public IActionResult List()
        {
            if (ModelState.IsValid)
            {
                var list = _list.Execute(new ListKitRequest());
                return Ok(list);
            }
            return BadRequest();
        }
    }
}
