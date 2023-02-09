namespace DespesaViagem.Domain.Models.Core.Records
{
    public record Endereco
    {
        public required string Logradouro { get; set; }
        public required int NumeroCasa { get; set; }
        public required string CEP { get; set; }
        public required string Cidade { get; set; }
        public required string Estado { get; set; }
    }
}
