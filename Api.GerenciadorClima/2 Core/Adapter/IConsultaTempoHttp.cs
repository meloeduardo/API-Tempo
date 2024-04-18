using Api.GerenciadorClima._2_Core.DTO;

namespace Api.GerenciadorClima._2_Core.Adapter
{
    public interface IConsultaTempoHttp
    {
        //Realizar a alteração no metodo para retornar um Objeto Response Clima em vez de string
        //Altera a interface no metodo para retornar um Objeto Response Clima em vez de string
        public Task<string> ConsultaTempo(RequestClima nomeDoPais);
    }
}
