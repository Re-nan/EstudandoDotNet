using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* BinararyReader e BinaryWriter
 * Quando os dados que você precisa trabalhar são bytes, você pode usar a classe FileStream, e para
 * strings ou caracteres você pode utilizar as classes StreamReader ou StreamWriter, e para outra
 * situações que você quer armazenar outros tipos de dados como boleanos, int, double.. nesse caso
 * as classes BinaryReader e BinaryWriter são as que mais irão te ajudar
 */

namespace Estudando.ArquivosDiretorios4
{
    class Program
    {
        static void Main(string[] args)
        {
            // === Criando Escrita ===

            // Criando stream em modo CREATE para criar este arquivo dados.bin em acesso Escrita
            FileStream fs;
            fs = new FileStream(@"C:\Users\rsanchez\Desktop\dados.bin", 
                FileMode.Create, FileAccess.Write);

            // Criando obj para escrita
            BinaryWriter bw = new BinaryWriter(fs);

            // Esses dados serão gravados em formato binário no arquivo
            bw.Write(true);
            bw.Write(20);
            bw.Write(10.5);
            bw.Write("Eaí");

            bw.Close();


            // === Criando Leitura ===

            // Criando stream em modo ABRIR este arquivo dados.bin em acesso Leitura
            fs = new FileStream(@"C:\Users\rsanchez\Desktop\dados.bin",
                FileMode.Open, FileAccess.Read);

            // Criando obj para leitura
            BinaryReader br = new BinaryReader(fs);

            // É preciso ler os dados na ordem em que foram escritos
            bool b = br.ReadBoolean();
            int i = br.ReadInt32();
            double d = br.ReadDouble();
            string s = br.ReadString();

            Console.WriteLine(b);
            Console.WriteLine(i);
            Console.WriteLine(d);
            Console.WriteLine(s);


            Console.ReadKey();

        }
    }
}
