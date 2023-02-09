namespace DespesaViagem.Domain.Models.Core.Records
{
    public record Veiculo
    {
        public required string Placa { get; set; }
        public required string Modelo { get; set; }
    }
}
