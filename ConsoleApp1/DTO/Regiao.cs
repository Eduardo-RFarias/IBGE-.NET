using System.Text.Json.Serialization;

namespace ConsoleApp1.DTO
{
	public record Regiao(
		[property: JsonPropertyName("id")]
		int Id,

		[property: JsonPropertyName("sigla")]
		string Sigla,

		[property: JsonPropertyName("nome")]
		string Nome
	);
}