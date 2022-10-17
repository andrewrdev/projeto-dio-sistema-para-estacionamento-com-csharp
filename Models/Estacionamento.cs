namespace App.Models
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

        // --------------------------------------------------------------------

        public void AdicionarVeiculo()
        {
            Console.WriteLine("-------------------------------------------------\n");
            Console.WriteLine("\nDigite a placa do veículo para estacionar: \n");
            string placa = "";
            placa = Console.ReadLine();
            veiculos.Add(placa != null ? placa : "");
        }

        // --------------------------------------------------------------------

        public void RemoverVeiculo()
        {
            Console.WriteLine("-------------------------------------------------\n");
            Console.WriteLine("\nDigite a placa do veículo para remover:\n");

            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("\nDigite a quantidade de horas que o veículo permaneceu estacionado:\n");

                int horas = int.Parse(Console.ReadLine());
                decimal valorTotal = (this.precoInicial + this.precoPorHora) * horas; 

                veiculos.Remove(placa);

                Console.WriteLine($"\nO veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}\n");
            }
            else
            {
                Console.WriteLine("\nDesculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente\n");
            }
        }

        // --------------------------------------------------------------------

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("-------------------------------------------------\n");
                Console.WriteLine("\nOs veículos estacionados são:\n");

                foreach(string veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("\nNão há veículos estacionados.\n");
            }
        }
    }
}
