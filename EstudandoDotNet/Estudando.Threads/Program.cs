using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/* Programção Multithread
 * - Um SO possuí vários processos, 1 processo é um programa rodando, um bloco de notas, um player... 
 * cada programa aberto é um processo. Quando você cria um programa em C#, ela também é um processo 
 * executando no SO.
 * 
 * - Toda aplicação quando está sendo executada tem pelo menos 1 thread, sem uma thread não existe a
 * execução de uma aplicação. A thread é uma linha de execução dentro de um processo, cada processo 
 * sempre tem uma thread, mas também pode ter mais, e chamamos isso de multithread
 * 
 * - Cada processo tem uma área de memómoria definida só para ele e nenhum outro processo pode utilizar.
 * O SO gerencia isso. 
 * 
 * - Um processo pode ter mais de uma linha de execução simultânea. As threads do processo compartilham o
 * heap do processo. Cada aplicação só tem 1 heap, se suas threads criam um obj, elas são criadas no
 * mesmo heap da aplicação. E uma thread pode ter acesso ao obj da outra mesmo que não tenha sido ela
 * quem o criou. Mitas aplicações são multithread, ex: editor de texto, enquanto você digita ele verifica
 * ortografia, salva o doc em segundo plano entre outras, ele faz coisas mesmo que você não esteja 
 * interagindo com elas, cada função dessa é uma thread.
 * 
 * -Estados de uma thread
 * Criada = Existe mas ainda não está em execução (e após iniciar recebe o status de Aguardando)
 * Aguardando = Quando é posta em execução, ela vai pra fila de thread, por isso esse status
 * Executando = Quando ela está no processador tendo suas linhas de código executadas
 * 
 * - Depois de um tempo o escalonador, tira a thread de execução e volta ela pra fila onde ela tem seu status
 * alterado para aguardando, ele chama outra thread, executa, devolve, e depois chama outra e assim vai... 
 * conforme a necessidade
 */

namespace Estudando.Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            /* - A forma mais básica de criar thread em C# é utilizando a classe Thread
             * - Pertence ao namespace System.Ththreading
             * - A primeira coisa é criar um obj do tipo Thread e passar um delegate no construtor que vai definir
             * o método a ser executado. No caso o ThreadStart()
             * - Ps: No C# você SEMPRE pode substituir o delegate por uma expressão lambda
             * - Depois da chamada ao método Start(), a thread principal vai continuar executando o método Main(), 
             * enquanto a nova thread executa o método Run() em paralelo. Quando o método Run() termina, a thread 
             * termina também e é finalizada
             */

            Thread t = new Thread(new ThreadStart(Run)); // Passando o nome do método
            // OU
            t = new Thread(Run);
            // Ou com lambda. No C# você SEMPRE pode substituir o delegate por uma expressão lambda
            t = new Thread( () => Run() );

            t.Start(); // Start() é quem inicia a thread

            /* Passando parametro para a thread. 
             * Eu só posso passar 1 parâmetro e ele tem que ser de Object
             */
            t = new Thread(new ParameterizedThreadStart(Run2));
            t.Start("Renan");

            // Posso pegar a thread atual e dar um nome para ela
            t = Thread.CurrentThread;
            t.Name = "Minha Thread";

            // Fazer a thread dormir/pausar por x tempo
            Thread.Sleep(2000);




            Console.ReadKey();
        }

        static void Run() 
        { 
            Console.WriteLine("Eai"); 

        }

        static void Run2(object obj) 
        {
            string nome = (string)obj;
            Console.WriteLine("Eai " + nome); 
        }
    }
}
