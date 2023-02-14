using DespesaViagem.Domain.Models.Core.Enums;
using DespesaViagem.Domain.Models.Core.Records;
using DespesaViagem.Domain.Models.Despesas;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DespesaViagem.Domain.Models.Viagem
{            
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
            if (despesa.TotalDespesa > 0 && StatusViagem == Status.EmAndamento)
                TotalDespesas += despesa.TotalDespesa;
            _despesas.Add(despesa);
        }

        public void RemoverDespesa(int id)
        {
            if (id > 0)
            {
                Despesa? despesa = BuscarDespesa(id);
                if (despesa != null)
                {
                    TotalDespesas -= despesa.TotalDespesa;
                    _despesas.Remove(despesa);
                    return;
                }
                throw new ArgumentException("A despesa não foi encontrada.");
                //Console.WriteLine("A despesa não foi encontrada.");
                //return;
            }
            throw new ArgumentException("Por favor, informe um id válido.");
            //Console.WriteLine("Por favor, informe um id válido.");
            //return;
        }

        public decimal GerarPrestacaoDeContas()
        {
            StatusViagem = Status.Fechada;
            return TotalDespesas - Adiantamento;
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

        private Despesa? BuscarDespesa(int id)
        {
            foreach(var item in _despesas)
            {
                if(item.Id == id)
                    return item;
            }
            return default;
        }
    }
}