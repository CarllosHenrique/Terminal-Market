using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        double saldo = 1000;
        Dictionary<string, double> acoes = new Dictionary<string, double>()
        {
            {"ABEV3", 13.43},
            {"ITSA4", 8.13},
            {"AMER3", 1.07},
            {"TASA4", 14.63},
            {"KLBN4", 3.88},
            {"PETR4", 25.10}
        };
        double taxaParaCadaTransacao = 0.05;
        Console.Write("Antes de iniciar o jogo, digite seu nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Bem-vindo ao Compass Market {0}", nome);
        Console.WriteLine("Você tem R${0} em dinheiro para investir.", saldo);

        while (true)
        {
            Console.WriteLine("\nAções disponíveis:");
            foreach (KeyValuePair<string, double> acao in acoes)
            {
                Console.WriteLine("{0} - Preço: R${1}", acao.Key, acao.Value);
            }
            Console.Write("\nDigite o nome da empresa que deseja comprar ações: ");
            string escolha = Console.ReadLine();
            if (escolha.ToLower() == "sair")
            {
                break;
            }
            if (!acoes.ContainsKey(escolha))
            {
                Console.WriteLine("Empresa inválida. Tente novamente.");
                continue;
            }
            Console.Write("Digite a quantidade de ações que deseja comprar: ");
            try
            {
                int qtd = int.Parse(Console.ReadLine());
                double precoTotal = acoes[escolha] * qtd;
                if (precoTotal > saldo)
                {
                    Console.WriteLine("O preço total foi R${0}, Saldo insuficiente. Tente novamente.", precoTotal);
                    continue;
                }

                saldo -= precoTotal * (1 + taxaParaCadaTransacao);
                double debitado = precoTotal * (1 + taxaParaCadaTransacao);
                Console.WriteLine("Compra realizada com sucesso.Foram debitados R${0} da sua conta, Saldo atual: R${1}", debitado, saldo);
                acoes[escolha] += qtd;
                double variacao = new Random().NextDouble() * (0.2) - 0.1; 
                acoes[escolha] = Math.Round(acoes[escolha] * (1 + variacao), 2);
                Console.WriteLine("Preço da ação da {0} atualizado para R${1}", escolha, acoes[escolha]);

                
            }
            catch (System.SystemException)
            {
                Console.WriteLine("Ocorreu um erro. Tente novamente!");
            }
        }

        Console.WriteLine("Transações encerradas. Obrigado por jogar!");
    }
}


