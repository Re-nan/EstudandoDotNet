using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Os FileStream são bastante interessantes mas são voltados mais para os tipos bytes,
 * em situações em que você precisa trabalhar com texto, é recomendado que você utilize
 * as classes StreamReader e StreamWriter, essas duas classes abstraem os dados e permitem
 * que você trabalhe diretamente com strings do que com bytes, o que é muito melhor.
 * StreamReader faz a leitura de texto e StreamWriter faz a escrita de texto, para trabalhar
 * com elas precisamos de um FileStream, pois StreamReader e StreamWriter não são Streams
 * propriamente dita, mas sim emcapsulam uma stream existem, no caso uma FileStream
 */

namespace Estudando.ArquivosDiretorios3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando o FileSTream
            FileStream fs = new FileStream(@"C:\Users\rsanchez\Desktop\texto.txt", FileMode.Create, FileAccess.Write);

            // Criando StreamWriter para gravar dados no arquivo
            StreamWriter sw = new StreamWriter(fs);

            // Criando StreamWriter para ler dados do arquivo
            sw.WriteLine("Olá este é um texto de exemplo.");
            sw.Close();


            // Criando com FileInfo e escrevendo nele
            FileInfo fi = new FileInfo(@"C:\Users\rsanchez\Desktop\texto2.txt");
            //StreamWriter sw2 = fi.CreateText();
            //sw2.WriteLine("Olá novamente este é um texto de exemplo.");
            //sw2.WriteLine("Linha 2");
            //sw2.WriteLine("Linha 3");
            //sw2.Close();


            // Lendo os dados

            // Criando StreamReader
            StreamReader sr = fi.OpenText();
            string line;
            
            // Lendo a linha e comprando se é diferente de null
            while((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine();

            // ou lendo o conteudo todo do arquivo
            // antes é preciso comentar o while acima
            string conteudo = sr.ReadToEnd();
            Console.WriteLine(conteudo);

            sr.Close();


            Console.ReadKey();
        }
    }
}
