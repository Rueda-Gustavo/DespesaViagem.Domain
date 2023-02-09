using DespesaViagem.Domain.Models.Core.Records;

namespace DespesaViagem.Domain.Models.Despesas
{    
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
