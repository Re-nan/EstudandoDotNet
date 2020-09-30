using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudando.POO.Construtores
{
    class Livro
    {
        public int numPaginas;
        public string titulo;
        public string autor;

        /* Um construtor pode chamar outro através do operador this
         * Quando você chamar Livro(titulo, autor), primeiro será chamado
         * o Livro(titulo) e só depois o compilador irá retornar
         * e chamar o Livro(titulo, autor)
         */

        //Costrutor Padrão
        public Livro() 
        {
            Console.WriteLine("Chamando... Construtor Padrão/Vazio");
        }

        //Sobrecarga de Construtor
        public Livro(string titulo) 
        {
            Console.WriteLine("Chamando... Construtor1");
            numPaginas = 100;
        }

        //Construtor Sobrecarregado
        public Livro(string titulo, string autor) : this(titulo)
        {
            Console.WriteLine("Chamando... Construtor2");
            this.titulo = titulo;
            this.autor = autor;
        }

    }
}
