using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/* Async e Await
 * - O uso dessas duas palavras chaves eleva a programação multhread a outro nível. Pois você deixa tudo a cargo da CLR
 * fazer o trabalho para você. o Dev apenas indica onde a execução será assíncrona e o CLR cuida do resto.
 * 
 * - O Async e Await trabalham em conjunto
 * Async = Define que um método poderá ser executado de forma assícrona
 * Await = Bloqueia a thread até que a tarefa seja terminada
 */

namespace Estudando.Threads.AsyncWait
{
    class Program
    {
        static void Main(string[] args)
        {
            

        }




        /* Suponha que eu tenha um método comum CreateTask(), a função dele é colocar uma Task para executar e
         * isso é feita através do método Task.Run() que irá executar uma expressão lambda que põe a thread para
         * esperar por 3 segundos. Esse método retorna um tipo Task.
         */ 
        Task CreateTask()
        {
            return Task.Run(() => Thread.Sleep(3000));
        }


        /* Agora suponha que você tenha um método ProcessAsync em que você definiu que ele tenha que ser chamado de
         * forma assíncrona, ou seja, ter um processamento assíncrono. Para isso você add o modificador async nele
         * isso indica que o método será executado de forma assíncrona.
         * ATENÇÃO: métodos que usam o modificador async possuem por convenção o sufixo "Async" no final do nome do
         * método.
         * 
         * Durante a execução do seu método assíncrono, chega o momento em que ele precisa executar uma tarefa dentro
         * dele e então você usa o await. Nisso a thread que chamou o ProcessAsync() quando encontra o await ela
         * sai do método e continua executando o que ela tinha para executar, uma nova thread é criada para executar
         * essa task no lugar da thread anterior que saiu, e essa thread nova fica bloqueada nesse ponto do await
         * aguardando a tarefa terminar. Quando a tarefa terminar ela continua executando o que tinha depois do await
         * mas repare que agora quem está executando essa Task não é mais aquela thread principal e sim outra, com
         * isso usando asyn e await eu consigo ter um comportamente assíncrono sem me preocupar com os detalhes do
         * assíncronismo pois a CLR é quem cuida de tudo.
         */ 
        async Task ProcessAsync()
        {
            // ...

            await CreateTask(); // Usei meu próprio método que retorna uma Task, mas poderia ter uma expressão lambda

            // ...
        }
    }
}
