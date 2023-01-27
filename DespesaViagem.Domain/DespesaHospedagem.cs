namespace DespesaViagem.Domain
{
    public record Endereco
    {
        public required string Logradouro { get; set; }
        public required int NumeroCasa { get; set; }
        public required string CEP { get; set; }
        public required string Cidade { get; set;}
        public required string Estado { get; set; }
    }

    public class DespesaHospedagem : Despesa
    {
        public Endereco Endereco { get; private set; }        
        public int QuantidadeDias { get; private set; }
        public decimal ValorDiaria { get; private set; }
        public DespesaHospedagem(int id, string descricaoDespesa, Endereco endereco, int quantidadeDias, decimal valorDiaria)
            : base(id, "Despesa com hospedagem", descricaoDespesa, quantidadeDias * valorDiaria)
        {
            Endereco = endereco;
            QuantidadeDias = quantidadeDias;
            ValorDiaria = valorDiaria;
        }


    }
}
