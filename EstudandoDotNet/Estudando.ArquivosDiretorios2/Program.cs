using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Streams são canais por onde trafegam bytes, de uma origem até um destino.
 * Quando queremos trabalhar com streams de forma que a origem ou o destino são arquivos,
 * nós podemos utilizar a classe FileStream de System.IO
 */ 

namespace Estudando.ArquivosDiretorios2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Criando uma stream e dizendo com qual arquivo eu vou trabalhar seja na
             * forma de escrever bytes neste arquivo ou ler bytes neste arquivo
             * 
             * Passando o Modo Create de FileMode, que é uma Enumerate(Enum)
             * 
             * Passando acesso de Escrita neste arquivo, atravé do FileAccess com o enum Write
             */

            FileStream fs = new FileStream(@"C:\Users\rsanchez\Desktop\arq.txt", FileMode.Create, FileAccess.Write);

            try
            {
                fs.WriteByte((byte)'A');
                fs.WriteByte((byte)'B');
                fs.WriteByte((byte)'C');
            }
            finally
            {
                // Sempre fechando stream
                fs.Close();
            }
            

            

            /* Criando um obj FileStream através de um FileInfo
             */
            FileInfo fi = new FileInfo(@"C:\Users\rsanchez\Desktop\arq.txt");

            //FileStream fs2 = fi.Create();

            /* Criando FileSTream em modo de adc texto na sequencia do texto 
             * que já tem no arquivo
             * 
             * Ao final do bloco o using Chama o Dispose()(Ou Close()) implicitamente
             */ 

            using (FileStream fs2 = fi.Open(FileMode.Append, FileAccess.Write))
            {
                fs2.WriteByte((byte)'A');
                fs2.WriteByte((byte)'B');
                fs2.WriteByte((byte)'C');
            }

            /* Criando FileSTream de leitura
             */
            using (FileStream fs3 = fi.Open(FileMode.Open, FileAccess.Read))
            {
                while(fs3.Position < fs3.Length)
                {
                    char c = (char)fs3.ReadByte();
                    Console.WriteLine(c);
                }

            }

            /* Esses métodos ReadByte() e WriteByte() funcionam, mas não é a forma mais usual
             * de trabalharmos com streams pois esses métodos trabalham apenas com 1 byte 
             * por vez, o que por sua vez os tornam inviáveis quando trabalhamos com streams
             * com muitos dados, para trabalhar com dados em conjuntos usamos os métodos
             * Read e Write que trabalham com buffer de dados, buffer que nada mais é que uma
             * área de dados temporária de memória onde podemos por esses dados que vamos ler
             * ou escrever, em um arquivo.
             */

            // Salve uma foto com o nome teste.img na área de trabalho
            // Transferindo os bytes de img1 para img2
            FileInfo fiSource = new FileInfo(@"C:\Users\rsanchez\Desktop\img1.png");
            FileInfo fiTarget = new FileInfo(@"C:\Users\rsanchez\Desktop\img2.png");

            using(FileStream fsSource = fiSource.OpenRead(), fsTarget = fiTarget.OpenWrite())
            {
                byte[] buffer = new byte[1024];

                while(true)
                {
                    int bytesRead = fsSource.Read(buffer, 0, buffer.Length);

                    if(bytesRead == 0)
                    {
                        break;
                    }

                    fsTarget.Write(buffer, 0, bytesRead);
                }
                

                
            }


            Console.ReadKey();
                
        }
    }
}
