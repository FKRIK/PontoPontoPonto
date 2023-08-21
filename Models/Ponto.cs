using System.ComponentModel.DataAnnotations;

namespace PontoAPI;
public class Ponto
{
    public int Id { get; set; }
    [Required(ErrorMessage = "O nome é obrigatório")]
    public string NomePessoa { get; set; }
    public string HorarioEntrada { get; set; }
    public string? HorarioSaida { get; set; }

    public Ponto(string nomePessoa)
    {
        NomePessoa = nomePessoa;
        HorarioEntrada = DateTime.Now.ToString("HH:mm:ss");
        HorarioSaida = "-";
    }
    
}
