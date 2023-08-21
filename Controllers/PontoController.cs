using Microsoft.AspNetCore.Mvc;

namespace PontoAPI;

[ApiController]
[Route("[controller]")]
public class PontoController
{
    private static List<Ponto> pontos = new List<Ponto>();
    private static int id = 0;

    [HttpPost]
    public void CadastraPonto([FromBody] Ponto ponto)
    {
        ponto.Id = id++;
        pontos.Add(ponto);
        Console.WriteLine(ponto.NomePessoa);
        Console.WriteLine(ponto.HorarioEntrada);
        Console.WriteLine(ponto.HorarioSaida);
    }

    [HttpGet]
    public IEnumerable<Ponto> ConsultaPontos([FromQuery] int skip = 0, [FromQuery] int take = 25)
    {
        return pontos.Skip(skip).Take(take);
    }

    [HttpGet("{id}")]
    public Ponto? ConsultaPontoPorId(int id)
    {
        return pontos.FirstOrDefault(ponto => ponto.Id == id);
    }
}