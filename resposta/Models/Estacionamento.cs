using System;
namespace resposta.Models
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
			// TODO: Pedir para o usu�rio digitar uma placa (ReadLine) e adicionar na lista "veiculos"
			// *IMPLEMENTE AQUI*
			Console.WriteLine("Digite a placa do ve�culo para estacionar:");
			string veiculo = Console.ReadLine().ToUpper();
			veiculos.Add(veiculo);
		}

		public void RemoverVeiculo()
		{
			// Pedir para o usu�rio digitar a placa e armazenar na vari�vel placa
			// *IMPLEMENTE AQUI*
			Console.WriteLine("Digite a placa do ve�culo para remover:");
			string placa = Console.ReadLine();
			// Verifica se o ve�culo existe
			if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
			{
				Console.WriteLine("Digite a quantidade de horas que o ve�culo permaneceu estacionado:");
				int horas = int.Parse(Console.ReadLine());
				// TODO: Pedir para o usu�rio digitar a quantidade de horas que o ve�culo permaneceu estacionado,
				// TODO: Realizar o seguinte c�lculo: "precoInicial + precoPorHora * horas" para a vari�vel valorTotal                
				// *IMPLEMENTE AQUI*

				decimal valorTotal = precoInicial + precoPorHora * horas;

				// TODO: Remover a placa digitada da lista de ve�culos
				// *IMPLEMENTE AQUI*
				veiculos.Remove(placa);
				Console.WriteLine($"O ve�culo {placa} foi removido e o pre�o total foi de: R$ {valorTotal}");
			}
			else
			{
				Console.WriteLine("Desculpe, esse ve�culo n�o est� estacionado aqui. Confira se digitou a placa corretamente");
			}
		}

		public void ListarVeiculos()
		{
			// Verifica se h� ve�culos no estacionamento
			if (veiculos.Any())
			{
				Console.WriteLine("Os ve�culos estacionados s�o:");
				// TODO: Realizar um la�o de repeti��o, exibindo os ve�culos estacionados
				// *IMPLEMENTE AQUI*
				foreach (string item in veiculos)
				{
					Console.WriteLine(item);
				}
			}
			else
			{
				Console.WriteLine("N�o h� ve�culos estacionados.");
			}
		}
	}
}
