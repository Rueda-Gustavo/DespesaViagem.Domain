using DespesaViagem.Domain.Models.Core.Records;

namespace DespesaViagem.Domain.Models.Despesas
{    
    public class DespesaRefeicao : Despesa
    {
        public Estabelecimento Estabelecimento { get; private set; }

        public DespesaRefeicao(int id, string descricaoDespesa, decimal valorDespesa, Estabelecimento estabelecimento) : base(id, "Despesa com alimentação", descricaoDespesa, valorDespesa)
        {
            Estabelecimento = estabelecimento;
        }
    }
}
