using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* SINGLETON
 * - É um pattern que ensina como podemos fazer para que uma classe tenha somente
 * uma instancia na aplicação
 * 
 * - Um singleton não pode permitir que uma instancia dele seja criada fora da classe
 * Ex. não posso ter uma Classe Main instanciando minha classe, e para isso eu defino
 * um Construtor privado garantido que ele só possa ser intanciado dentro da própria
 * classe
 * 
 * - Quem chama a classe nunca tem acesso ao operador new, e sim somente chamada
 * direta a classe através de um elemento static, isso garante que você não terá
 * mais de uma instancia da sua classe na sua aplicação
 */

namespace Estudando.DesignPattern.Singleton
{
    class Gerenciador
    {
        /* Crio uma instancia privada do tipo static para ser somente da class e 
         * do tipo readonly para não poder ter seu valor alterado após setado e 
         * do mesmo tipo da class, e já chamo seu construtor dentro da própria 
         * classe OU SEJA o único local onde eu construo um obj/crio uma instancia
         * da classe, é aqui.
         */ 
        private static readonly Gerenciador instance = new Gerenciador();

        /* Crio uma property/field static para ser somente da class e
         * somente do modo leitura tendo somente o GET, essa property
         * é quem irá manipular o obj instance acima e não permitirá
         * que eu crie mais de uma instancia, por ela ser estática sendo
         * da classe e não poder ter sue valor substituido após setado
         */ 
        public static Gerenciador Instance { get; }


        //Construtor
        private Gerenciador()
        {
            Console.WriteLine("Criando obj uma única vez");
        }

        //Método Gerenciar
        public void Gerenciar()
        {

        }

    }
}
