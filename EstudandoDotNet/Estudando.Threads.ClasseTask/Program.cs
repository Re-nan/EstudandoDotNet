using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Programação Assíncrona
 * É baseada em métodos que retorno antes de terminar a execução. É comum estarmos acostumado ao Modelo Síncrono
 * onde a thread entra no método e só sai quando o método terminar. Já no Modelo Assíncrono a thread entra no código
 * porém ao entrar é criado uma nova thread e depois da criação dessa nova thread ela é quem executará o método 
 * enquanto a thread anterior continua executando de forma simultânea. Com isso você tem muitas tarefas sendo executadas
 * ao mesmo tempo ao invés de uma de cada vez.
 */

 /* A Programação Paralela 
  * É usada para dividir uma tarefa em diversas partes e executar estas partes de forma simultânea. A programação 
  * Assíncrona permite gerenciar as threads dos processos de forma eficiente evitando que uma thread seja bloqueada 
  * enquanto aguarda o processamento de outra thread
 */

/* Programação Assíncrona X Paralela 
 * Nada mais é que uma especialização do conceito de Programação multthread que é justamente você ter várias thread
 * para executar sua aplicação
 */ 

/* A classe Task e Task<T> fazem parte da TPL(Task Parallel Library), a TPL contém um conjunto de tipos que fazem 
 * parte da programação paralela. Task também é a base para algumas construções da linguagem voltadas à programação 
 * assíncrona. O namespace dessas classes é o System.Threading.Tasks, a classe Task substitui os delegates assíncronos, 
 * trazendo algumas vantagens. Os delegates assíncronos já não são mais tão usados pois depois que surgiu a classe Task
 * você consegue fazer a mesma coisa só que d euma forma mais fácil, intuítiva e poderosa.
 * 
 * A classe Task representa uma tarefa, uma tarefa nada mais é um código que deve ser executado por uma thread
 */

namespace Estudando.Threads.ClasseTask
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Existem formas de você iniciar uma Task, uma tarefa em uma thread a parte
             * O StartNew sempre retorna um obj do tipo Task, se Run() for void então StartNew() retorna um Task
             * já se Run() tivesse um tipo como int, então StartNew() retorna um tipo Task parametrizado, Task<T>
             */

            Task.Factory.StartNew(Run); // O StartNew inicia outra thread

            // ou separando a criação da execução

            Task minhaTask = new Task(Run);
            minhaTask.Start();

            // Retornando uma Task de int, o retorno é a soma de 5 + 9
            Task<int> soma = Task.Factory.StartNew(() => 5 + 9);

            // ou utilizando construtor
            Task<double> divisao = new Task<double>(() => 4 / 2);
            divisao.Start();


            /* Em tarefas que retornam algum valor, a property Result obtém o valor retornado
             * Se a tarefa ainda não terminou, a thread que fez a chamada ao Result fica bloqueada
             * Ou seja, sempre garante que terá o resultado na var r
             */
            double r = divisao.Result;

            /* Outra opção se você desejar aguardar o término de uma tarefa é utilizar o método Wait(), 
             * basta que você o chame e a thread ficará bloqeuada esperando o método terminar
             * O método Wait retorna void. É recomendado que você use o Wait para Tasks que não retornam nada
             */
            divisao.Wait(); // É recomendado usar wait para eu garantir o retorno da minha task

            /* ainda é possível fornecer um timeout para ele, assim sua thread vai ficar bloqueada
             * esperando ela terminar por no máximo o x de tempo que você passou
             * Ex: A thread vai ficar bloqueada esperando a task terminar por no máx 1 segundo
             * O resultado indica se a task terminou durante a espera(true) ou não(false)
             */
            bool finished = divisao.Wait(10000);

            /* Se uma task lançar uma Exception, está Exception é propagada até o código que está
             * aguardando o término da tarefa. Existe uma thread que inicia a tarefa e existe outra
             * thread que executa o código da tarefa, se a thread que está executando o código da
             * tarefa lançar uma exceção, essa exceção não tem como chegar na thread que iniciou
             * a tarefa por serem linhas de código diferente
             * A não ser que a thread que iniciou a Task, esteja esperando a resposta da tarefa
             * A exceção propagada é do tipo AggregateException, a qual contém a exceção original 
             * dentro dela podendo ser acessada através de um try catch em quem inicia a task
             * e no catch(AggregateException e) { e.InnerException;}
             * É importante você ler o rsultado da tarefa através de um Wait ou um Result, pois só dessa
             * forma você vai ficar sabendo que ocorreu uma Exceção.
             */

            /* Quando uma tarefa tem por objetivo uma execução com um longo intervalo de tempo, é melhor definila 
             * como uma "Tarefa de longa duração", ao invés de usar uma thread já existente no pool de threads, já
             * que as threads do pool são limitadas. Para isso adc um novo parametro que é um enum do tipo LongRunning
             * Consulte a documentação para mais informações
             */
            Task.Factory.StartNew(Run, TaskCreationOptions.LongRunning);



            Console.ReadKey();
        }

        static void Run() { }

    }
}
