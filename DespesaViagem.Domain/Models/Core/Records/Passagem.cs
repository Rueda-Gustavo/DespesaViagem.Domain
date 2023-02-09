namespace DespesaViagem.Domain.Models.Core.Records
{
    public record Passagem
    {
        public required string Companhia { get; set; }
        public required string Origem { get; set; }
        public required string Destino { get; set; }
        public required DateTime DataEHoraEmbarque { get; set; }
        public required decimal Preco { get; set; }

    }
}
