namespace DespesaViagem.Domain.Models.Core.Records
{
    public record Agendamento
    {
        public required DateTime DataInicial { get; set; }
        public required DateTime DataFinal { get; set; }
    }
}
