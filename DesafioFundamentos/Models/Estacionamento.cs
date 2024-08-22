namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
    
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            
            string placa = Console.ReadLine(); //Implementação: - Leonardo Aparicio
            veiculos.Add(placa); //Implementação: - Leonardo Aparicio
            Console.WriteLine("Veiculo adicionado com sucesso!"); //Implementação: - Leonardo Aparicio
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();
            
            
            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                
                int horas = Convert.ToInt32(Console.ReadLine()); //Implementação: - Leonardo Aparicio
                decimal valorTotal = precoInicial + precoPorHora * horas;  //Implementação: - Leonardo Aparicio
                
                Console.WriteLine($"O valor total é de {valorTotal}R$"); //Implementação: - Leonardo Aparicio
                
                
                
                veiculos.Remove(placa); //Implementação: - Leonardo Aparicio

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
       
                int contadorVeiculos = 0; //Implementação: - Leonardo Aparicio
                foreach (string placa in veiculos) //Implementação: - Leonardo Aparicio
                {
                    Console.WriteLine($"Veículo {contadorVeiculos}: {placa}"); //Implementação: - Leonardo Aparicio
                    contadorVeiculos++; //Implementação: - Leonardo Aparicio
                }
                
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
