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
             * Console.WriteLine("Olá Mundo!");
             * 
             * E a MSIL converte seu código que um humano entende para uma linguagem 
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



            /* O .Net Framework vem por padrão instalado no Windows, cada Windows a partir do
             * "Windows XP" já vem com uma versão do .Net Framework instalada
             * 
             * E ele fica na pasta C:\Windows\Microsoft.NET e dentro desse diretório eu tenho
             * os diretórios "Framework" que representa o 32x e o diretório "Framework64" que 
             * representa o 64x, essa escolha depende da aplicação que eu quero executar
             * 
             * Dentro do diretório Framework/Framework64 eu tenho outros diretórios que 
             * representam a versão do .net framework e cada diretório de versão possui os
             * arquivos necessários para a execução de uma aplicação feita para a plataforma do
             * .net framework, que vão de bibliotecas e arquivos usados pela CLR, um desses arquivos
             * é o "csc.exe" que é compilador do C#
             * 
             * Com isso é possível escrever C# em uma sistema Windows sem precisar ter uma IDE
             * como o Visual Studio, basta escrever nosso código em um bloco de notas e salvarmos
             * ele como txt mesmo
             * 
             * Abrir o cmd e navegar até o diretório C:\Windows\Microsoft.NET\Framework\v4.0.30319
             * e executar o csc.exe seguindo do nome do arquivo a ser compilado
             * C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe MeuPrograma.txt
             * 
             * O C# irá gerar na mesma pasta do MeuPrograma.txt um arquivo MeuPrograma.exe que ao
             * exercutarmos rodará nosso programa para a plataforma .Net Framework em ambiente Windows
             * 
             */



            /* Entendo a árvore de diretórios do .Net Framework
             * 
             * - Dentro do diretório do projeto eu tenho:
             * .vs = é um diretório com arquivos temporários do VS
             * 
             * NomeDaSolution.sln = essa é a extensão usada pelo VS
             * para representar uma Solução/Solution
             * 
             * Outro diretório com o nome do projeto, esse é o diretório onde
             * é armazenado os arquivos daquele projeto
             * 
             * E dentro dele temos alguns arquivos como:
             * 
             * NomeDoProjeto.csproj = é um xml defindo lingação com outros arquivos
             * e diretório, ele define quem compõe o nosso projeto como o arquivo
             * 
             * Program.cs = arquivo de código
             * 
             * 
             * App.config = arquivo de configurações daquele projeto
             * 
             * Diretório Properties 
             * assemblyInfo.cd = informações do projeto como versões do projeto e etc
             * 
             * Diretório obj = guarda arquivos temporários utilizados em processos de
             * compilação, quando do ctrl + espaço retornando o intellisense no VS 
             * 
             * Diretório bin = Guarda o executável do programa
             */

        }
    }
}
