using System.Text.Json.Serialization;

namespace ConsoleApp1.DTO
{
	public record UF(
		[property: JsonPropertyName("id")]
		int Id,

		[property: JsonPropertyName("sigla")]
		string Sigla,

		[property: JsonPropertyName("nome")]
		string Nome,

		[property: JsonPropertyName("regiao")]
		Regiao Regiao
	);
}