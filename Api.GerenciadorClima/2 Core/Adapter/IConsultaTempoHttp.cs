using Api.GerenciadorClima._2_Core.DTO;

namespace Api.GerenciadorClima._2_Core.Adapter
{
    public interface IConsultaTempoHttp
    {
        public Task ConsultaTempo(RequestClima nomeDoPais);
    }
}
