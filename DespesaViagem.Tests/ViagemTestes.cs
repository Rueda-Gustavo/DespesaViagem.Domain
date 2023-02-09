using DespesaViagem.Domain.Models.Core.Records;
using DespesaViagem.Domain.Models.Despesas;
using DespesaViagem.Domain.Models.Viagem;

namespace DespesaViagem.Tests
{
    public class ViagemTestes
    {
        [Fact]
        public void Viagem_AdicionarDespesa_TotalDespesaDeveEstarCorreto()
        {
            //Arrange
            Viagem viagem = new Viagem(1, "Viagem para SP", 
                "Viagem corporativa, reunião com clientes", 5000m, 
                new Agendamento { DataInicial = DateTime.UtcNow.AddDays(5), DataFinal = DateTime.UtcNow.AddDays(20)}, 
                new Funcionario { Matricula = "A1B2", Nome = "José" });

            DespesaPassagem despesaPassagem = new DespesaPassagem(1,
                "Passagem de avião para SP",
                new Passagem
                {
                    Companhia = "Azul",
                    DataEHoraEmbarque = DateTime.UtcNow.AddDays(1).AddHours(2),
                    Destino = "SP",
                    Origem = "RJ",
                    Preco = 2299.90m
                });

            DespesaRefeicao despesaRefeicao = new DespesaRefeicao(2,
                "Café da manhã do primeiro dia", 35.9m,
                new Estabelecimento { CNPJ = "132456984", NomeEstabelecimento = "Maria Cereja" });

            //Act             
            viagem.IniciarViagem();

            viagem.AdicionarDespesa(despesaPassagem);
            viagem.AdicionarDespesa(despesaRefeicao);
            decimal totalDespesa = viagem.TotalDespesas;


            //Assert
            Assert.Equal(2335.80m, totalDespesa);
        }
        
        [Fact]
        public void Viagem_RemoverDespesa_TotalDespesaDeveEstarCorreto()
        {
            //Arrange
            Viagem viagem = new Viagem(1, "Viagem para SP",
                "Viagem corporativa, reunião com clientes", 5000m,
                new Agendamento { DataInicial = DateTime.UtcNow.AddDays(5), DataFinal = DateTime.UtcNow.AddDays(20) },
                new Funcionario { Matricula = "A1B2", Nome = "José" });

            DespesaPassagem despesaPassagem = new DespesaPassagem(1,
                "Passagem de avião para SP",
                new Passagem
                {
                    Companhia = "Azul",
                    DataEHoraEmbarque = DateTime.UtcNow.AddDays(1).AddHours(2),
                    Destino = "SP",
                    Origem = "RJ",
                    Preco = 3299.90m
                });

            DespesaRefeicao despesaRefeicao = new DespesaRefeicao(2,
                "Café da manhã do primeiro dia", 40.9m,
                new Estabelecimento { CNPJ = "132456984", NomeEstabelecimento = "Maria Cereja" });


            //Act 
            viagem.IniciarViagem();

            viagem.AdicionarDespesa(despesaPassagem);
            viagem.AdicionarDespesa(despesaRefeicao);

            viagem.RemoverDespesa(1);
            viagem.RemoverDespesa(2);
            decimal totalDespesa = viagem.TotalDespesas;


            //Assert
            Assert.Equal(0m, totalDespesa);
        }

        [Fact]
        public void Viagem_RemoverDespesaComIdNegativo_DeveRetornarExcecao()
        {
            //Arrange
            Viagem viagem = new Viagem(1, "Viagem para SP",
                "Viagem corporativa, reunião com clientes", 5000m,
                new Agendamento { DataInicial = DateTime.UtcNow.AddDays(5), DataFinal = DateTime.UtcNow.AddDays(20) },
                new Funcionario { Matricula = "A1B2", Nome = "José" });

            //Act 
            viagem.IniciarViagem();
            
            Action act = () => viagem.RemoverDespesa(-1);

            //Assert
            var ex = Assert.Throws<ArgumentException>(act);
            Assert.Equal("Por favor, informe um id válido.", ex.Message);
        }

        [Fact]
        public void Viagem_RemoverDespesaInexistente_DeveRetornarExcecao()
        {
            //Arrange
            Viagem viagem = new Viagem(1, "Viagem para SP",
                "Viagem corporativa, reunião com clientes", 5000m,
                new Agendamento { DataInicial = DateTime.UtcNow.AddDays(5), DataFinal = DateTime.UtcNow.AddDays(20) },
                new Funcionario { Matricula = "A1B2", Nome = "José" });

            //Act 
            viagem.IniciarViagem();

            Action act = () => viagem.RemoverDespesa(1);

            //Assert
            var ex = Assert.Throws<ArgumentException>(act);
            Assert.Equal("A despesa não foi encontrada.", ex.Message);
        }

        [Fact]
        public void Viagem_GerarPrestacaoDeContas_ResultadoDeveEstarCorreto()
        {
            //Arrange
            Viagem viagem = new Viagem(1, "Viagem para SP",
                "Viagem corporativa, reunião com clientes", 5000m,
                new Agendamento { DataInicial = DateTime.UtcNow.AddDays(5), DataFinal = DateTime.UtcNow.AddDays(20) },
                new Funcionario { Matricula = "A1B2", Nome = "José" });

            //Act 
            viagem.IniciarViagem();

            Action act = () => viagem.RemoverDespesa(1);

            //Assert
            var ex = Assert.Throws<ArgumentException>(act);
            Assert.Equal("A despesa não foi encontrada.", ex.Message);
        }

    }
}
