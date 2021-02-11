using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudando.PassagemParametro2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Criado uma variável "num" que é uma referência para o objeto na memória do tipo "Numero"
             * num está na memória stack, que aponta para um endereço de memória do tipo Numero, que está no heap
             */
            Numero num = new Numero();
            num.n = 5; // inicializado com 5

            Trocar(num);

            Console.WriteLine(num.n); // exbido com 10

            Console.ReadKey();
        }

        /* É copiado o mesmo valor do endereço de memória que está na stack que é apenas a referência 
         * que é MUITO DIFERENTE do valor do endereço de memória que está no heap
         */
        static void Trocar(Numero x) // é copiado a referência para o obj Numero
        {
            /* ATENÇÃO
             * Apesar da passagem por parâmetro ser por VALOR
             * 
             * é copiado o valor de num para x, que referencia um obj na memória do tipo Numero
             * portanto tanto num como x apontam pro mesmo endereço de memória
             * 
             * se num e x apontam pro mesmo endereço de memória, então apartir do momento em que
             * eu mudo o valor de n em um dos dois, eu reflito esse alteração tanto para um como
             * para o outro
             */
            x.n = 10;

            /* Se eu comentar o código acima e fazer o que está abaixo o valor exibido será 5 pois
             * x aponta para um novo endereço de memória, e num continua apontando para o mesmo de antes
             * 
             * porém se eu forçar esse método receber passagem pro referência com o prefixo "ref" antes do
             * parametro, então eu vou exibir 50 poi aí de fato estaria sendo feito a cópia do endereço
             * de memória heap do obj Numero
             */
            //x = new Numero(); 
            //x.n = 50;
        }
    }

    class Numero
    {
        public int n;
    }

}