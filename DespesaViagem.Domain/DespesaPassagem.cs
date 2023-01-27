namespace DespesaViagem.Domain
{
    public record Passagem
    {
        public required string Companhia { get; set; }
        public required string Origem { get; set; }
        public required string Destino { get; set; }
        public required DateTime DataEHoraEmbarque { get; set; }
        public required decimal Preco { get; set; }

    }
    public class DespesaPassagem : Despesa
    {
     
        public Passagem Passagem { get; private set; }

        public DespesaPassagem(int id, string descricaoDespesa, Passagem passagem) : base(id, "Despesa com passagem", descricaoDespesa, passagem.Preco)
        {
            Passagem = passagem;
        }
    }
}
