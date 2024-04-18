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
        
        public async Task<ResponseClima> ConsultTempo(RequestClima recebimento)
        {
            await _consultaTempoHttp.ConsultaTempo(recebimento);

            return new ResponseClima();
        }

    }
}
