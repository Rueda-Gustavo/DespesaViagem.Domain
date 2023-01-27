namespace DespesaViagem.Domain
{
    public record Funcionario {
        public string Nome { get; set; }
        public string Matricula { get; set; }
    }

    public record Agendamento
    {
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
    }

    public enum Status
    {
        Aberta, EmAndamento, Fechada, Cancelada
    }

    public class Viagem
    {
        public int Id { get; }
        public string NomeViagem { get; set; }      
        public string DescricaoViagem { get; set; }
        public decimal Adiantamento { get; }
        public Agendamento Agendamento { get; private set; }
        public decimal TotalDespesas { get; private set; }
        public Status StatusViagem { get; private set; }        
        public IReadOnlyCollection<Despesa> Despesas 
        {
            get { return _despesas.AsReadOnly(); }
        }       
        public Funcionario Funcionario { get; private set; }

        private List<Despesa> _despesas = new List<Despesa>();

        public Viagem(int id, string nomeViagem, string descricaoViagem, decimal adiantamento, Agendamento agendamento, Funcionario funcionario)
        {
            Id = id;
            NomeViagem = nomeViagem;
            DescricaoViagem = descricaoViagem;
            Adiantamento = adiantamento;
            Agendamento = agendamento;
            TotalDespesas = 0;
            StatusViagem = Status.Aberta;
            Funcionario = funcionario;            
        }

        public void AdicionarDespesa(Despesa despesa)
        {
            if(despesa.TotalDespesa > 0)
                TotalDespesas += despesa.TotalDespesa;
            _despesas.Add(despesa);
        }

        public void RemoverDespesa(int id) { }

        public decimal GerarPrestacaoDeContas()
        {
            StatusViagem = Status.Fechada;
            return (TotalDespesas - Adiantamento);
        }

        public void IniciarViagem()
        {
            if (StatusViagem == Status.Fechada)
                throw new Exception("Viagem já foi fechada!");
            StatusViagem = Status.EmAndamento;
        }

        public void CancelarViagem()
        {
            StatusViagem = Status.Cancelada;            
        }
    }    
}