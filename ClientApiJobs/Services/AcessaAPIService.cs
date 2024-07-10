using ClientApiJobs.Models.Candidato;
using ClientApiJobs.Models.Empresa;
using ClientApiJobs.Models.TokenConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ClientApiJobs.Services
{
    public class AcessaAPIService
    {
        public async Task<List<EmpresaConfigurationModel>> GetAllVagas(string URI, TokenModel accessToken)
        {
            using (var client = new HttpClient())
            {
                GetHeaderTokenAuthorization(client, accessToken.data);

                using (var response = await client.GetAsync((URI)))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsStringAsync();
                        var options = new JsonSerializerOptions
                        {
                            IncludeFields = true,
                            PropertyNameCaseInsensitive = true
                        };
                        List<EmpresaConfigurationModel> vagas = JsonSerializer.Deserialize<List<EmpresaConfigurationModel>>(content, options);
                        return vagas;
                    }
                    else
                    {
                        throw new Exception("Não foi possível carregar as vagas: " + response.StatusCode);
                    }
                }
            }
        }

        public async Task<List<EmpresaConfigurationModel>> GetAllVagasDisponiveis(string URI, TokenModel accessToken)
        {
            using (var client = new HttpClient())
            {
                GetHeaderTokenAuthorization(client, accessToken.data);

                using (var response = await client.GetAsync((URI)))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsStringAsync();
                        var options = new JsonSerializerOptions
                        {
                            IncludeFields = true,
                            PropertyNameCaseInsensitive = true
                        };
                        List<EmpresaConfigurationModel> vagas = JsonSerializer.Deserialize<List<EmpresaConfigurationModel>>(content, options);
                        return vagas;
                    }
                    else
                    {
                        throw new Exception("Não foi possível carregar as vagas: " + response.StatusCode);
                    }
                }
            }
        }

        public async Task<List<EmpresaConfigurationModel>> GetVagasPorCandidato(string URI, TokenModel accessToken)
        {
            using (var client = new HttpClient())
            {
                GetHeaderTokenAuthorization(client, accessToken.data);

                using (var response = await client.GetAsync((URI)))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsStringAsync();
                        var options = new JsonSerializerOptions
                        {
                            IncludeFields = true,
                            PropertyNameCaseInsensitive = true
                        };
                        List<EmpresaConfigurationModel> vagas = JsonSerializer.Deserialize<List<EmpresaConfigurationModel>>(content, options);
                        return vagas;
                    }
                    else
                    {
                        throw new Exception("Não foi possível carregar as vagas: " + response.StatusCode);
                    }
                }
            }
        }

        public async Task<List<CandidatoVagaModel>> GetCandidatosPorVagas(string URI, TokenModel accessToken)
        {
            using (var client = new HttpClient())
            {
                GetHeaderTokenAuthorization(client, accessToken.data);

                using (var response = await client.GetAsync((URI)))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsStringAsync();
                        var options = new JsonSerializerOptions
                        {
                            IncludeFields = true,
                            PropertyNameCaseInsensitive = true
                        };
                        List<CandidatoVagaModel> vagas = JsonSerializer.Deserialize<List<CandidatoVagaModel>>(content, options);
                        return vagas;
                    }
                    else
                    {
                        throw new Exception("Não foi possível carregar as vagas: " + response.StatusCode);
                    }
                }
            }
        }



        public static void GetHeaderTokenAuthorization(HttpClient client, TokenConfigurationModel token)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", token.AccessToken);
        }
    }
}
