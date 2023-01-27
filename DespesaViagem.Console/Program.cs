using DespesaViagem.Domain;

Console.WriteLine("Hello, World!");

Viagem viagem = new Viagem(1, "Viagem 1", "Primeira viagem", 2000.0m,
    new Agendamento { DataFinal = DateTime.UtcNow.AddDays(5), DataInicial = DateTime.UtcNow },
    new Funcionario { Matricula = "100", Nome = "Gustavo" });

viagem.AdicionarDespesa(new DespesaRefeicao(1, "Despesa com alimentos", 20.9m,
    new Estabelecimento { CNPJ = "1234", NomeEstabelecimento = "Cantina da Maria" }));
viagem.AdicionarDespesa(new DespesaRefeicao(2, "Despesa com alimentos", 20.9m,
    new Estabelecimento { CNPJ = "1234", NomeEstabelecimento = "Cantina da Maria" }));


Console.WriteLine(viagem);

//Estudar sobre testes de unidade. https://www.youtube.com/playlist?list=PLFC3ojvxXTtahqgkTg56kAY2PGvCO2C-z
//Mapear entidades para o entity framework
