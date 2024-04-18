using Api.GerenciadorClima._2_Core.Adapter;
using Api.GerenciadorClima._2_Core.Domain.Entitie;
using Api.GerenciadorClima._2_Core.DTO;

namespace Api.GerenciadorClima._2_Core.Application
{
    public class UseCase : IUseCase
    {
        private readonly IConsultaTempoHttp _consultaTempoHttp;
        public UseCase(IConsultaTempoHttp consultaTempoHttp)
        {
            _consultaTempoHttp = consultaTempoHttp;
        }
        //Realizar a alteração no metodo para retornar um Objeto Response Clima em vez de string
        //Altera a interface no metodo para retornar um Objeto Response Clima em vez de string

        //public async Task<ResponseClima> ConsultTempo(RequestClima recebimento)
        //{
        //   var result =  await _consultaTempoHttp.ConsultaTempo(recebimento);

        //    return new ResponseClima();
        //}
        public async Task<string> ConsultTempo(RequestClima recebimento)
        {
            var result = await _consultaTempoHttp.ConsultaTempo(recebimento);

            return result;
        }

    }
}
