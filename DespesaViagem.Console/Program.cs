using DespesaViagem.Domain.Models.Core.Records;
using DespesaViagem.Domain.Models.Despesas;
//using DespesaViagem.Domain.Models.Viagem;
using DespesaViagem.Infra.Models.Viagem;
using DespesaViagem.Infra.Database;

Console.WriteLine("Hello, World!");

/*
Viagem viagem = new Viagem(1, "Viagem 1", "Primeiro teste de Viagem", 2000, new Agendamento(), new Funcionario());
DespesaDeslocamento despesa = new DespesaDeslocamento(1, "Viagem a trabalho", 400, 1.5m, new Veiculo { Modelo = "Corsa", Placa = "ABC1234" });
viagem.AdicionarDespesa(despesa);
*/

/*Viagem viagem = new Viagem(1, "Viagem 1", "Primeira viagem", 2000.0m,
    new Agendamento { DataFinal = DateTime.UtcNow.AddDays(5), DataInicial = DateTime.UtcNow },
    new Funcionario { Matricula = "100", Nome = "Gustavo" });

viagem.AdicionarDespesa(new DespesaRefeicao(1, "Despesa com alimentos", 20.9m,
    new Estabelecimento { CNPJ = "1234", NomeEstabelecimento = "Cantina da Maria" }));
viagem.AdicionarDespesa(new DespesaRefeicao(2, "Despesa com alimentos", 20.9m,
    new Estabelecimento { CNPJ = "1234", NomeEstabelecimento = "Cantina da Maria" }));

viagem.RemoverDespesa(2);
Console.WriteLine(viagem);*/

ViagemDataAccess db = new ViagemDataAccess();
//Viagem viagem = new Viagem(1, "Viagem 1", 2000.0m,
//                     new Agendamento { DataFinal = DateTime.UtcNow.AddDays(5), DataInicial = DateTime.UtcNow },
//                     new Funcionario { Matricula = "100", Nome = "Gustavo" });

Viagem viagem = new Viagem { Id = "1", Nome = "Viagem"};

//db.CriarViagem(viagem);
Console.WriteLine(db.GetAllViagens());



//Estudar sobre testes de unidade. https://www.youtube.com/playlist?list=PLFC3ojvxXTtahqgkTg56kAY2PGvCO2C-z
//Mapear entidades para o entity framework
