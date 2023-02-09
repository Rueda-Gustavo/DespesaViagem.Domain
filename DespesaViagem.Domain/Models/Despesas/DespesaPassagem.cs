using DespesaViagem.Domain.Models.Core.Records;

namespace DespesaViagem.Domain.Models.Despesas
{    
    public class DespesaPassagem : Despesa
    {

        public Passagem Passagem { get; private set; }

        public DespesaPassagem(int id, string descricaoDespesa, Passagem passagem) : base(id, "Despesa com passagem", descricaoDespesa, passagem.Preco)
        {
            Passagem = passagem;
        }
    }
}
