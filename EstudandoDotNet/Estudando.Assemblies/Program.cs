using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Assemblies
 * É um conceito que faz parte da plataforma .net no geral e não só ao C# apenas, toda aplicação
 * .net é composta por uma série de assemblies, ele é como se fosse uma unidade de compilação, ao
 * compilar o código, ele é posto dentro de um assemblie, e você pode compor vários assemblies para
 * montar uma aplicação. Esses assemblies que você monta podem serem de dois tipos. 
 * EXE = Que pode ser executado pela CLR, quando você compila o código de um projeto
 * DLL = É utilizado por outros assemblies, não foi feito para ser executado pela CLR
 * 
 * Ex: Eu tenho uma aplicação que referencia várias DLL(assemblies), e compilo tudo, tenho um 
 * assemblie utilizando outros assemblies
 * 
 * Toda api básica do .net referencia pelo menos uma assemblie, toda aplicação referencia o assemblie
 * mscorlib.DLL que compõe os tipos como Object, int, string... sem ela você não faz nada em uma
 * aplicação .net
 * 
 * Tem códigos separados em assemblies facilita a manutenção e equipes diferente podem usar o mesmo
 * assemblie(código), e com isso criamos o conceito de biblioteca de classes que é você criar um
 * assemblie com algum propósito que é composta por classes, delegates, estruturas, e ela fica 
 * disponível para multiplos projetos
 * 
 * Quando eu crio uma biblioteca com código C# e complilo ela, ela é um código IL (código intermediário)
 * que a plataforma .net reconhece, então eu posso usar essa biblioteca tanto em outra aplicação C# como
 * em uma aplicação VB.net
 * 
 * A plataforma .net define dois tipos de assemblies
 * 
 * private = Usados apenas por uma aplicação, o arquivo do assemblie fica loclaizado dentro do 
 * diretório da aplicação, é um projeto do tipo Class Library em que uma Class Library
 * nunca é compilada e executada, ela só serve para ser referenciada por outro projeto
 * e neste projeto executável, você add a referência dela, e pode importar ela no using
 * ou usar o nome completo com o namespace junto, ao executar está aplicação executável
 * será copiado o assemblie DLL da library para a pasta bin do seu projeto executável
 * 
 * shared = compartilhados, usado por várias aplicações, o arquico do assemblie fica localizado em um 
 * local conhecido, chamado GAC (Global Assembly Cache) 
 * 
 * GAC = que é um repositório de assemblies, ficam em dois locais
 * 
 * C:\Windows\assembly = Aqui ficma os assemblies complilados em versões do .net anteriores à 4.0
 * é a pasta legada
 * 
 * C:\Windows\Microsoft.NET\assembly\GAC_MSIL = Aqui ficam os assemblies complicados em versões do
 * .net na 4.0 ou superioes
 */
 
namespace Estudando.Assemblies
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
