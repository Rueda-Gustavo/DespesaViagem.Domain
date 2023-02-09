using DespesaViagem.Domain.Models.Core.Records;

namespace DespesaViagem.Domain.Models.Despesas
{
    public class DespesaDeslocamento : Despesa
    {

        public int Quilometragem { get; private set; }
        public decimal ValorPorQuilometro { get; private set; }
        public Veiculo Veiculo { get; private set; }


        public DespesaDeslocamento(int id, string descricaoDespesa, int quilometragem, decimal valorPorQuilometro, Veiculo veiculo)
            : base(id, "Despesa com deslocamento", descricaoDespesa, quilometragem * valorPorQuilometro)
        {
            Quilometragem = quilometragem;
            ValorPorQuilometro = valorPorQuilometro;
            Veiculo = veiculo;
        }
    }
}
