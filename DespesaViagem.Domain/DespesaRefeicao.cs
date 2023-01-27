namespace DespesaViagem.Domain
{

    public record Estabelecimento
    {
        public string NomeEstabelecimento { get; set; }
        public string CNPJ { get; set; }
    }

    public class DespesaRefeicao : Despesa
    {
        public Estabelecimento Estabelecimento { get; private set;}                          
        
        public DespesaRefeicao(int id, string descricaoDespesa, decimal valorDespesa, Estabelecimento estabelecimento) : base(id, "Despesa com alimentação", descricaoDespesa, valorDespesa)
        {
            Estabelecimento = estabelecimento;
        }
    }
}
