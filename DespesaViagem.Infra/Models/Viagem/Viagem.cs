using DespesaViagem.Domain.Models.Core.Enums;
using DespesaViagem.Domain.Models.Core.Records;

namespace DespesaViagem.Infra.Models.Viagem
{
    public class Viagem
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Adiantamento { get; }
        public Agendamento Agendamento { get; private set; }
        public decimal TotalDespesas { get; private set; }
        public Status StatusViagem { get; private set; }
    }
}
