using System;
					
public class Program
{
	public static void Main()
	{
		bool running = true;
		int vitorias = 0;
		int empates = 0;
		int derrotas = 0;
		
		Console.WriteLine("insira seu nome");
		string nome = Console.ReadLine();
		
		Random r = new Random();
		Console.WriteLine("jokenpo");
		
		while (running) {
		Console.WriteLine("1 papel");
		Console.WriteLine("2 pedra");
		Console.WriteLine("3 tesoura");
		Console.WriteLine("insira sua escolha");
		int opcao = Convert.ToInt16(Console.ReadLine());
		
		int botn = r.Next(1,4);
		string m = "";
		
		if (opcao == 1 && botn == 1) {
			m = "empate, voce papel, bot papel";
			empates += 1;
		}
		else if (opcao == 1 && botn == 2) {
			m = "ganhou, voce papel, bot pedra";
			vitorias += 1;
		}
		else if (opcao == 1 && botn == 3) {
			m = "perdeu, voce papel, bot tesoura";
			derrotas += 1;
		}
		else if (opcao == 2 && botn == 1) {
			m = "perdeu, voce pedra, bot papel";
			derrotas += 1;
		}
		else if (opcao == 2 && botn == 2) {
			m = "empate, voce pedra, bot pedra";
			empates += 1;
		}
		else if (opcao == 2 && botn == 3) {
			m = "ganhou, voce pedra, bot tesoura";
			vitorias += 1;
		}
		else if (opcao == 3 && botn == 1) {
			m = "ganhou, voce tesoura, bot papel";
			vitorias += 1;
		}
		else if (opcao == 3 && botn == 2) {
			m = "perdeu, voce tesoura, bot pedra";
			derrotas += 1;
		}
		else if (opcao == 3 && botn == 3) {
			m = "empate, voce tesoura, bot tesoura";
			empates += 1;
		}
		
		Console.WriteLine(m);
			
		Console.WriteLine(nome + " voce deseja continuar jogando? (s/n)");
		string continuar = Console.ReadLine();
		if (continuar == "s") {
			continue;
		}
		else running = false;
			
		}
		Console.WriteLine("vitorias: " + vitorias);
		Console.WriteLine("empates: " + empates);
		Console.WriteLine("derrotas: " + derrotas);
		int jogostotais = vitorias + empates + derrotas;
		Console.WriteLine("jogos totais: " + jogostotais);
		
	}
}