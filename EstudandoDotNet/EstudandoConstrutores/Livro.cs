using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudandoConstrutores
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
        public Livro() { }

        //Sobrecarga de Construtor
        public Livro(string titulo) 
        {
            numPaginas = 100;
        }

        //Construtor Sobrecarregado
        public Livro(string titulo, string autor) : this(titulo)
        {
            this.titulo = titulo;
            this.autor = autor;
        }

    }
}
