namespace DespesaViagem.Domain.Models.Core.Records
{
    public record Estabelecimento
    {
        public required string NomeEstabelecimento { get; set; }
        public required string CNPJ { get; set; }
    }
}
