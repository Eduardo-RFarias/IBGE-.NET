using ConsoleApp1.DTO;
using System.Text.Json;

namespace ConsoleApp1.Services
{
	public class IBGEHttpClient
	{
		private readonly HttpClient client;

		public IBGEHttpClient()
		{
			client = new HttpClient
			{
				BaseAddress = new Uri("https://servicodados.ibge.gov.br/api/v1/localidades/")
			};
		}

		public async Task<IEnumerable<Municipio>> GetMunicipiosAsync(string UF)
		{
			HttpResponseMessage response = await client.GetAsync($"estados/{UF}/municipios/");

			if (!response.IsSuccessStatusCode)
			{
				throw new Exception($"Erro ao obter os municípios do estado {UF}.");
			}

			string content = await response.Content.ReadAsStringAsync();

			try
			{
				return JsonSerializer.Deserialize<IEnumerable<Municipio>>(content)!;
			}
			catch (Exception ex)
			{
				throw new Exception($"Erro ao desserializar os municípios do estado {UF}.", ex);
			}
		}
	}
}
