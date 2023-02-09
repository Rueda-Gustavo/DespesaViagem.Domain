namespace DespesaViagem.Domain.Models.Core.Records
{
    public record Funcionario
    {
        public required string Nome { get; set; }
        public required string Matricula { get; set; }
    }
}
