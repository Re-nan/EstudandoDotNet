using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* No C# temos 5 tipos de modificadores
 * 
 * private = visível apenas a classe/estrutura que declarou o elemento
 * 
 * public = sem restrição de acesso
 * 
 * protected = Visível a classe que declarou e suas subclasses que a herdaram
 * 
 * internal = Visível apenas dentro do próprio assembly, ou seja visível naquele
 * namespace em que foi declarado, e todas as classes que compartilham do mesmo namespace
 *
 * internal protected = Visível a classe que declarou, subclasses que herdaram e dentro
 * do próprio assembly/namespace
 */

/* Se você não especificar um modificador de visibilidade os C# irá assumir o padrão
 * Por padrão toda classe é internal e todo field e método é private
 */ 

namespace Estudando.Modificador.Visibilidade
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
