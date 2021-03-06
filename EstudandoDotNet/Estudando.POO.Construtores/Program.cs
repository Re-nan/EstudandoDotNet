﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Valor padrão assúmido dos tipos primitivos
 * 
 * int, short, byte, long, float, double = 0
 * bool = false
 * char = '\0' (Reprezenta nada)
 * 
 * Value types assumem o valor padrão
 * Reference types(Class Pessoa) assumem = null
 */

/* Construtor
 * - é um método da POO que é chamado no momento da inicialização/instanciação
 * daquele obj, é o momento que você tem para inicializar seus Fields antes de
 * usar aquele obj
 * 
 * - Possuem o mesmo nome do método
 * - Não possuem tipo de retorno
 * - podem conter ou não parâmetros
 * - Assim como método podem conter sobrecarga de construtores
 * 
 * Uma classe sempre deve te rum construtor definido na classe
 * se você não criar esse construtor o compilador cria o construtor
 * padrão de forma implícita
 * 
 * Porém se você cria um construtor com parâmetros, o contrutor padrão que antes
 * criado sozinho pelo compilador deixa de existir. Sendo assim sendo necessário
 * criar o construtor padrão caso queira que suas propriedades sejam inicializadas
 * com valores valores padrão
 * 
 * Ps: em Structs o compilador sempre define um construtor padrão, independente de
 * existirem outros ou não, ele não pode ser redefinido, já vem por padrão em uma struct
 */
 
namespace Estudando.POO.Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Este Contrutor inicializou os fields da classe
             * com valores padrões 
             * titulo = ""
             * autor = ""
             * numPaginas = 0
             */
            Livro livro1 = new Livro();

            Console.WriteLine("Título: " + livro1.titulo);
            Console.WriteLine("Autor: " + livro1.autor);
            Console.WriteLine("Num Páginas: " + livro1.numPaginas);

            Console.WriteLine();
            
            /* Este Contrutor inicializou os fields da classe com valores
             * definidos no momento de sua criação
             */ 
            Livro livro2 = new Livro("Game Of Thrones", "George R. R. Martin");

            Console.WriteLine("Título: " + livro2.titulo);
            Console.WriteLine("Autor: " + livro2.autor);
            Console.WriteLine("Num Páginas: " + livro2.numPaginas);

            Console.ReadKey();
        }
    }
}
