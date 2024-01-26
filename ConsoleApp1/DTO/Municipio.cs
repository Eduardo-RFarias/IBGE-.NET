using System.Text.Json.Serialization;

namespace ConsoleApp1.DTO
{
	public record Municipio(
		[property: JsonPropertyName("id")]
		int Id,

		[property: JsonPropertyName("nome")]
		string Nome,

		[property: JsonPropertyName("microrregiao")]
		Microrregiao Microrregiao
	);
}