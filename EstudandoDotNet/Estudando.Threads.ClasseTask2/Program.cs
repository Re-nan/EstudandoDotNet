using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/* Classe Task
 * A classe Task representa uma tarefa, uma tarefa nada mais é um código que deve ser executado por uma thread.
 * E o conceito de Tarefa é algo que é executado em uma thread a parte. A grande vantagem de você utulizar Task é que
 * a Task esconde toda a complexidade de você trabalhar com threads, você apenas d eum obj Task para executar um
 * determinado código e você não precisa se preocupar com a ocupação das threads necessárias, o C# obtem essas threads
 * a partir do pool de threads da CLR 
 */

namespace Estudando.Threads.ClasseTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // === Cenário 1 ====
            // Task com método void 

            // Criando uma Task passando no construtor qual tarefa deve ser executada, e iniciando ela
            Task t = new Task(MostrarMensagem); // passando um método ou delegate do tipo Action
            t.Start();

            // O método Wait() força a Task ser aguardada, esperando que a thread principal termine
            t.Wait();

            // Executar com ctrl + F5
            // O Console.ReadKey força a thread principal aguardar o usuário digitar alguma coisa na tela
            // Console.ReadKey();



            // === Cenário 2 ====
            // Task com método parametrizado
            // Como o meu método recebe um int como parametro vou criar minha Task com expressão lambda
            Task<long> t2 = Task.Factory.StartNew(() => CalculaFatorial(10));

            // Para ler o retorno do valor eu chamo a propertie Result
            // Aqui a thread que chamou o Result fica aguardando a thread terminar de executar para poder garantir que tenha o valor
            long fatorial = t2.Result;
            Console.WriteLine(fatorial);


        }

        // === Cenário 1 ====
        /* Suponha que você tem um método chamado MostrarMensagem()
         * que agaurda 2 segundos e exibe uma mensagem
         */
        static void MostrarMensagem()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Aprendendo a usar tasks!");
        }


        // === Cenário 2 ====
        // Retorna o farorial de um número n
        static long CalculaFatorial(int n)
        {
            if(n == 0)
            {
                return 1;
            }
            return n * CalculaFatorial(n - 1);
        }
    }
}
