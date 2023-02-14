using DespesaViagem.Domain.Models.Core.Enums;
using DespesaViagem.Domain.Models.Core.Records;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.Globalization;

namespace DespesaViagem.Infra.Models.Viagem
{
    public class Viagem
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get;  set; }
        public string Nome { get;  set; }        
        public decimal Adiantamento { get; }/*
        public Agendamento Agendamento { get; private set; }
        public Funcionario Funcionario { get; private set; }
        public decimal TotalDespesas { get; private set; }
        public Status StatusViagem { get; private set; }

        public Viagem()
        {

        }

        public Viagem(int id, string nome, decimal adiantamento, Agendamento agendamento, Funcionario funcionario)
        {
            Id = id;
            Nome = nome;
            Adiantamento = adiantamento;
            Agendamento = agendamento;
            Funcionario = funcionario;
            TotalDespesas = 0;
            StatusViagem = Status.Aberta;
        }*/
    }
}
