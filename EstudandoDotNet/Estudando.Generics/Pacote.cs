using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Quando a classe usa Generics, o tipo parametrizado deve ser fornecido no momento
 * da criação do objeto
 */

namespace Estudando.Generics
{
    class Pacote<T>
    {
        public T Elem1 { get; set; }
    }

    class Propriedade<TChave, TValor>
    {
        private TChave Chave;
        private TValor Valor;

        public Propriedade(TChave chave, TValor valor)
        {
            Chave = chave;
            Valor = valor;
        }

    }
}
