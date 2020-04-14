using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ABSTRACT
 * Classe abstract não pode ser instanciada, somente herdada, mas pode ser usada 
 * como referência que aponte para um instância de uma classe concreta
 * Ex. Animal a = new Cachorro()
 * 
 * Podem conter métodos abstratos e não abstratos, quando uma classe herda de uma 
 * classe abstract ela é obrigada a sobreescrever os métodos definidos como abstract,
 * todos os métodos abstratos são virtual por padrão
 * 
 * Usamos métodos abstract quando faz sentido o método ter várias formas de se comportar
 * Métodos abstract funcionam como métodos de uma Interface, porém um método abstract
 * só pode ser declarado em uma classe abstract
 * 
 * A classe abstract é uma relação do tipo "É UM" portando seu objetivo é servir de base
 * para ser herdada
 */

namespace Estudando.POO.Polimorfismo
{
    abstract class Animal
    {
        public abstract void Falar();

        public void Andar()
        {
            Console.WriteLine("Animal andando");
        }
    }
}
