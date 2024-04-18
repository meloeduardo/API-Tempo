using Api.GerenciadorClima._2_Core.Application;
using Api.GerenciadorClima._2_Core.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace Api.GerenciadorClima._1_Controller
{
    [Route("whetarmap")]
    public class WhetarMapController : Controller
    {
        private readonly IUseCase _consultaUseCase;
        public WhetarMapController(IUseCase consultaUseCase)
        {
            _consultaUseCase = consultaUseCase;
        }
        //Realizar a alteração no metodo para retornar um Objeto Response Clima em vez de string
        //Altera a interface no metodo para retornar um Objeto Response Clima em vez de string
        [HttpGet]
        [Route("tempo")]
        public async Task<IActionResult> ResultTempo([FromQuery]string city)
        {
            var recebimento = new RequestClima();
            recebimento.City = city;
            
            var resultado = await _consultaUseCase.ConsultTempo(recebimento);
            return Ok(resultado);
            
        }

        
    }
}
