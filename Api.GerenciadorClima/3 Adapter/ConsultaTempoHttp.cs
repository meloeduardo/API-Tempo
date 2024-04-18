using Api.GerenciadorClima._2_Core.Adapter;
using Api.GerenciadorClima._2_Core.DTO;
using Flurl;
using Flurl.Http;
using Microsoft.AspNetCore.DataProtection.KeyManagement;

namespace Api.GerenciadorClima._3_Adapter
{
    public class ConsultaTempoHttp : IConsultaTempoHttp
    {
        public async Task ConsultaTempo(RequestClima nomeDoPais)
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

                var response = await url.GetJsonAsync<dynamic>();

                if (response.IsSuccessStatusCode)
                {
                    var conteudo = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(conteudo);
                    // Aqui você pode processar o conteúdo da resposta conforme necessário
                }
                else
                {
                    Console.WriteLine($"Erro: {response.StatusCode}");
                }
            }
            catch (FlurlHttpException ex)
            {
                Console.WriteLine($"Erro ao fazer a chamada HTTP: {ex.Message}");
            }
        }
    }
}
