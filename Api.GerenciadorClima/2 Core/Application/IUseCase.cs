using Api.GerenciadorClima._2_Core.Domain.Entitie;
using Api.GerenciadorClima._2_Core.DTO;

namespace Api.GerenciadorClima._2_Core.Application
{
    public interface IUseCase
    {
        public Task<ResponseClima> ConsultTempo (RequestClima recebimento);
    }
}
