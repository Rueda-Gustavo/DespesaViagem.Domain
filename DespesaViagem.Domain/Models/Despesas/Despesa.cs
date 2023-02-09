namespace DespesaViagem.Domain.Models.Despesas
{

    public abstract class Despesa
    {
        public int Id { get; private set; }
        public virtual string NomeDespesa { get; protected set; }
        public virtual string DescricaoDespesa { get; protected set; }
        public virtual decimal TotalDespesa { get; protected set; }
        public virtual DateTime DataDespesa { get; protected set; }

        public Despesa(int id, string nomeDespesa, string descricaoDespesa, decimal totalDespesa)
        {            
            Id = id;
            NomeDespesa = nomeDespesa;
            DescricaoDespesa = descricaoDespesa;
            TotalDespesa = totalDespesa;
            DataDespesa = DateTime.UtcNow;
        }
        //Abstract class - https://sourcemaking.com/refactoring/replace-conditional-with-polymorphism        
    }
}
