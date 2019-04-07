using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroducaoNetFramework
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Em ambiente do .Net Framework, não importa a linguagem que estamos
             * utilizando, seja C#, VB, C++. entre outras.... todo o nosso código
             * é compilado para o que chamamos de MSIL(Microsoft Intermediate Language)
             * Ps: Alguns documentos chamam a "MSIL" de "CIL", mas continua a mesma coisa
             * 
             * MSIL = é uma linguagem universal, e quem interpreta essa linguagem universal
             * é a Máquina Virtual chamada CLR(Common Language Runtime)
             * 
             * CLR = é uma Máquina virtual que está instalada no SO, cada SO tem sua uma 
             * implementação da máquina virtual, no nosso caso, existe uma máquina virtual 
             * .net para o Windows.
             * 
             * ----- Entendo com mais detalhes -----
             * 
             * Você escreve seu código em C#
             * Console.WriteLine("Olá Mundo!")
             * 
             * E a MSIL converte seu código que um humano entende para para uma linguagem 
             * intermediária que só a CLR(máquina virtual) entende
             * nop
             * ldstr "Olá Mundo!"
             * call Console.WriteLine
             * nop
             * ret
             * 
             * E a CLR pega esse código acima e converte para linguagem de máquina para que 
             * o seu processador Intel ou AMD possa entender e executar sua aplicação
             */

        }
    }
}
