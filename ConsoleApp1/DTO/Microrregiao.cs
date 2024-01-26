using System.Text.Json.Serialization;

namespace ConsoleApp1.DTO
{
	public record Microrregiao(
		[property: JsonPropertyName("id")]
		int Id,

		[property: JsonPropertyName("nome")]
		string Nome,

		[property: JsonPropertyName("mesorregiao")]
		Mesorregiao Mesorregiao
	);
}