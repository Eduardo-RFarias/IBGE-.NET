using System.Text.Json.Serialization;

namespace ConsoleApp1.DTO
{
	public record Mesorregiao(
		[property: JsonPropertyName("id")]
		int Id,

		[property: JsonPropertyName("nome")]
		string Nome,

		[property: JsonPropertyName("UF")]
		UF UF
	);
}