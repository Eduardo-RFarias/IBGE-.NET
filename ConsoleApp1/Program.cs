using ConsoleApp1.DTO;
using ConsoleApp1.Services;

IBGEHttpClient client = new();

Console.WriteLine("Digite a sigla do estado para obter os municípios:");
string UF = Console.ReadLine()!;

IEnumerable<Municipio> municipios = await client.GetMunicipiosAsync(UF);
int numeroDeMunicipios = municipios.Count();

switch (numeroDeMunicipios)
{
	case 0:
		Console.WriteLine($"O estado {UF} não possui municípios ou não existe.");
		break;
	case 1:
		Console.WriteLine($"Foi encontrado 1 município para o estado {UF}:");
		break;
	default:
		Console.WriteLine($"Foram encontrados {numeroDeMunicipios} municípios para o estado {UF}:");
		break;
}

foreach (Municipio municipio in municipios)
{
	Console.WriteLine($"	{municipio.Nome} ({municipio.Microrregiao.Mesorregiao.Nome})");
}