namespace DespesaViagem.Domain
{
    internal class Class1
    {
        public void teste()
        {
            //Hospedagem, Refeição, Passagem
            Viagem viagem = new Viagem(1, "Viagem 1", "Primeiro teste de Viagem", 2000, new Agendamento(), new Funcionario());            
            DespesaDeslocamento despesa = new DespesaDeslocamento(1, "Viagem a trabalho", 400, 1.5m, new Veiculo { Modelo = "Corsa", Placa = "ABC1234" });

            viagem.AdicionarDespesa(despesa);
        }
    }
}
