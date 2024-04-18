using Microsoft.AspNetCore.Mvc;

namespace Api.GerenciadorClima._1_Controller
{
    [Route("sobre")]
    public class AboutController : Controller

    {
        [HttpGet]
        [Route("about")]
        public async Task<IActionResult> ValidaFuncionamentoApi()
        {
            return Ok("Api em funcionamento");
        }
    }

}
