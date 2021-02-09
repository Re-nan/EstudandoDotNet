using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Manipulção de arquivos com C#
 * 
 * É muito comum que aplicações precisem manipular arquivos, ler ou guardar dados
 * 
 * O arquivos podems erem de 2 tipos: 
 * Binários = que são entendidos pelo computador, você não consegue ler ele
 * Texto = que são entendidos por você, você consegue ler eles
 * 
 * Existem 4 classes que podems erem utilizadas para realizar operações em arquivos
 * e diretórios. Para arquivos: "File" e "FileInfo" e para diretórios: "Directory" e 
 * "DirectoryInfo", essas classes possuem a mesma funcionalidade, a diferença é que a
 * classe File e Directory, só possuem métodos estáticos, ou seja, métodos da classe
 * e as classes FileInfo e DirectoryInfo, precisam serem estânciadas, todas essas classes
 * pertencem ao namespace System.IO
 * 
 * A classe FileInfo tem algumas propriedades que a classe File não tem
 * Extension = Extensão do arquivo
 * FullName = Caminho completo do arquivo
 * Name = Nome doa rquivo(sem diretórios)
 * Length = Tamanho do arquivo
 * CreationTime = Data/Hora de criação do arquivo
 * LastAccesTime = Data/Hora do último acesso ao arquivo
 * LastWriteTime = Data/Hora da útima gravação no arquivo
 * Directory = Diretório onde o arquivo está contido
 * 
 * A classe DirectoryInfo tem algumas propriedades que a classe Directory não tem
 * Exit = Checa existência do diretório
 * FullName = Caminho completo do diretório
 * Name = Nome do diretório
 * CreationTime = Data/Hora de criação di diretório
 * LastAccessTime = Data/Hora do último acesso ao diretório
 * LastWriteTime =  Data/Hora da última gravação no diretório
 * Parent = Diretório anterior na hierarquia
 * 
 * Outra classe para trabalharmos com diretórios é a classe Path e ela possuí métodos
 * estáticos com alguns utilitários que facilitam o trabalho com caminhos de arquivos
 * e diretórios
 * 
 * Combine() = Combina duas ou mais strings em um caminho de arquivo ou diretório
 * GetDirectoryName() = Obtém o nome do diretório a partir de um caminho
 * GetFileNameWithoutExtension() = Retorna o nome do arquivo sem a extensão
 * ChangeExtension() = Muda a Extensão de um arquivo
 * 
 * A classe DriveInfo nos permite obter informações sobre os drives, 
 * ex drive C:, D: e etc.., e ela possui algumas propriedades para nos ajudar
 * Name = Nome do Drive
 * AvailableFreeSpace = Espaço disponível no drive
 * IsReady = Indica se o drive está pronto
 * DriveFormat = Formato do sistema de arquivos do drive
 * TotalSize = Tamanho total do drive
 * VolumeLabel = Çabel associada ao drive
 * 
 * Stream
 * É um conceito de I/O (input/Output), é um canal por onde trafegam bytes, esses bytes
 * saiem de uma origem e vão até um destino. A stream é o canal por onde esses bytes trafegam
 * É utilizada seja para envidar dados para um arquivo ou ler dados de um arquivo
 * 
 * A classe FileSTream é utilizad apara ler ou escrever dados em um arquivo, ela é utilizada
 * normalmente com arquivos binários
 * 
 * O C# tem classes feitas para leitura e escrita de binários: BinaryReader e BynaryWriter,
 * são utilizadas para se trabalhar com arquivos com números
 * 
 * O C# tem classes feitas para trabalhar com arquivos de texto, StreamReader e StreamWriter
 */

namespace Estudando.ArquivosDiretorios
{
    class Program
    {
        static void Main(string[] args)
        {
            // === FileInfo ===

            // Criando um novo arquivo
            FileInfo fi = new FileInfo(@"C:\Temp\file.txt");
            fi.Create();

            // Copiando um arquivo para outro local
            fi.CopyTo(@"C:\Temp\file2.txt");

            // Verificando a existência de um arquivo
            bool b1 = fi.Exists;


            // Criando um diretório
            DirectoryInfo di = new DirectoryInfo(@"C:Temp\Curso");
            di.Create();

            // Movendo um deretório para outro local
            di.MoveTo(@"C:Temp\Curso2");

            // Obtendo os arquivos do diretório
            FileInfo[] files1 = di.GetFiles("*.txt");




            // === File ===

            // Criando um novo arquivo
            File.Create(@"C:\Temp\file.txt");

            // Copiando um arquivo para outro local
            File.Copy(@"C:\Temp\file.txt", @"C:\Temp\file2.txt");

            // Verificando a existência de um arquivo
            bool b2 = File.Exists(@"C:\Temp\file.txt");



            // Criando um diretório
            Directory.CreateDirectory(@"C:Temp\Curso");

            // Movendo um deretório para outro local
            Directory.Move(@"C:Temp\Curso", @"C:Temp\Curso2");

            // Obtendo os arquivos do diretório
            string[] files2 = Directory.GetFiles(@"C:Temp\Curso", "*.txt");



            // Ler bytes de um arquivo
            byte[] bytes2 = File.ReadAllBytes(@"C:\Temp\file.bin");

            // Let todas as linhas de um arquivo, cada elemento é uma linha do arquivo
            string[] lines2 = File.ReadAllLines(@"C:\Temp\file.txt");

            // Ler todas as linhas do arquivo, em uma string só
            string lines3 = File.ReadAllText(@"C:\Temp\file.txt");



            // Escreve bytes em um arquivo
            //byte[] bytes3 = ...;
            //File.WriteAllBytes(@"C:\Temp\file.bin", bytes);

            // Escrever linhas no arquivo
            //string[] lines4 = ...;
            //File.WriteAllLines(@"C:\Temp\file.bin", lines4);

            //Escrever uma string no arquivo
            string text = "...";
            File.WriteAllText(@"C:\Temp\file.bin", text);



            // === Drive ===

            //Obter nome do drive
            DriveInfo drive = new DriveInfo(@"C:\");

            // Obter lista de drives no meu computador
            DriveInfo[] drives = DriveInfo.GetDrives();



            // === FileStream ====
            /* Parametros para criar um obj FileStream
             * nome do arquivo, Enumeration do tipo FileMode, Enumeration do tipo FileAccess
             * 
             * A Enumeration FileMode possui algumas propriedades
             * Append, Create, CreateNew, Open, OpenOrCreate, Truncate
             * 
             * A Enumeration FileAccess possui algumas propriedades
             * Read, ReadWrite, Write
             */
            FileStream fd = new FileStream(@"C:\Temp\file.bin",
                FileMode.Create,
                FileAccess.Write);

            // Criando um obj FileStream a partir de um obj FileInfo
            // Arquivo aberto para leitura
            FileStream fs1 = fi.OpenRead();

            // Arquivo aberto para escrita
            FileStream fs2 = fi.OpenWrite();

            /* Depois de utilizar oa rquivo é importante chamar o método Close()
             * para liberar os recursos utilizados
             * Tanfo faz usar .Close() ou .Dispose()
             * 
             * Para forçar que sempre irá ser fechada é uma boa prática utilizar
             * um bloco try finally ou um bloco using
             */

            try
            {
                //...
            }
            finally
            {
                fs1.Close();
                fs2.Dispose();
            }

            // implicitamente o C# vai chamar o Dispose() no obj FileStream
            using (FileStream fs3 = fi.OpenRead())
            {
                //..
            }

            /* Ler e escrever 1 byte, toda operação de leitura e escrita avança 
             * para a próxima posição
             */
            int i1 = fs1.ReadByte();
            fs1.WriteByte(new byte());

            /* Ler e escrever mais de 1 byte
             * Retorna o número de bytes lidos
             */
            //byte[] bytes4 = ...;
            //int i = fs1.Read(bytes4, 0, bytes4.Length);
        }
    }
}