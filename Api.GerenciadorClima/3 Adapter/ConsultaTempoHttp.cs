using Api.GerenciadorClima._2_Core.Adapter;
using Api.GerenciadorClima._2_Core.DTO;
using Flurl;
using Flurl.Http;
using Microsoft.AspNetCore.DataProtection.KeyManagement;

namespace Api.GerenciadorClima._3_Adapter
{
    public class ConsultaTempoHttp : IConsultaTempoHttp
    {
        //Realizar a alteração no metodo para retornar um Objeto Response Clima em vez de string
        //Altera a interface no metodo para retornar um Objeto Response Clima em vez de string

        public async Task<string> ConsultaTempo(RequestClima nomeDoPais)
        {
            try
            {
                 var BaseUrl = "https://api.openweathermap.org/data/2.5/weather";
                 var ApiKey = "6d17cf5b65fcd27b66e26e156bd3eb0f"; // Substitua pela sua chave de API do OpenWeatherMap
                 var url = BaseUrl
                    .SetQueryParams(new
                    {
                        q = nomeDoPais.City,
                        appid = ApiKey
                    });

                //Realizar a alteração no metodo para retornar um Json em vez de string
                var response = await url.GetStringAsync();

                //lemnbra de primeiro fazer um teste para tu saber o que retorna da Api dos caras
                //No Objeto response clima tem que ter o nome dos mesmo atributos que retorna de lá
                //entra no objeto ResponseClima que tem um exemplo


                return response;

            }
            catch (FlurlHttpException ex)
            {
                Console.WriteLine($"Erro ao fazer a chamada HTTP: {ex.Message}");
                throw ex;
            }
        }
    }
}
