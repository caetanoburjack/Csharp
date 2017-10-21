/********************************************************************
    Desafio 01 - SUED
    Autor    : Caetano Finisterre Burjack Silva
**********************************************************************/

using System;
using System.Threading;

namespace SuedCaetano
{
    class Program
    {
        public void Pensando()//metodo para exibir a msg que simula o sued pensando...
        {
            System.Timers.Timer aTimer = new System.Timers.Timer(); //instancia do timer para adicionar efeito temporizador na mensagem
            Console.WriteLine("");
            Console.Write("hum");
            for (int i = 0; i < 5; i++)//montando a mensagem
            {
                Thread.Sleep(500);
                Console.Write("m");
            }
            Console.WriteLine("");
        }

        static void Main(string[] args)
        {

            Program msg = new Program();//instancia para posterior invocação do metodo msg
            Console.WriteLine("Seja bem vindo ao ORÁCULO");
            var saudacao = "Ó querido oraculo, conhecedor de todas as coisas, máquina sobrehumana, onisciente ";
            var intruso = "Se orienta palhaço, só respondo pro meu criador...";
            while (true)//laço para execução infinita do programa
            {
                Console.WriteLine("O que desejas saber? (pressione * para sair!)");
                //definição das variaveis
                var resposta = "";
                var pass = Console.ReadKey(true).KeyChar;//capta o primeiro caracter, e não o exibe (parametro true na assinatura do metodo)
                int i = 0;
                if (pass == '*')//conferindo se foi digitado o *, e caso positivo fechando o programa.
                    Environment.Exit(0);//saindo do programa
                if (pass != ';')//aqui começa a brincadeira, se o primeiro digito n for um ';', ele entra em nó
                {
                    Console.Write(pass);//como n foi um ';' ele imprime o caracter recém digitado
                    while (Console.ReadKey().Key != ConsoleKey.Enter) { } //enquanto n se tecla enter ele vai escrevendo na tela

                    msg.Pensando();//invocação do metodo que exibirá a msg do sued pensando
                    Console.WriteLine(intruso);//exibição da mensagem para intrusos
                }
                else//caso o primeiro caracter seja um ';', entra nesse nó
                {
                    while (true)//laço infinito
                    {
                        i++;
                        var key = System.Console.ReadKey(true);
                        if (key.KeyChar == ';')//quando se nota q foi digitado o segundo ';' o sued volta o controle do console pro usuario, exibindo o q ta digitando
                            break;
                        resposta += key.KeyChar; //vai montando a resposta caracter por caracter
                        Console.Clear();//limpa o console
                        Console.Write(saudacao.Substring(0, i));//vai exibindo a saudação letra por letra, através do indice usando o valor de i... 
                    }
                    while (Console.ReadKey().Key != ConsoleKey.Enter) { }//permite que se continue depois do segundo ';'
                    msg.Pensando();//invocação do metodo que exibirá a msg do sued pensando
                    Console.WriteLine(resposta);//exibe o que o usuario digitou entre o primeiro e o segundo ';'
                }
            }
        }
    }
}
