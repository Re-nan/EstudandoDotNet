using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudandoConstrutor
{
    class Aluno
    {
        //Construtor
        public Aluno(string nome)
        {
            Console.WriteLine("Criando o objeto");
            this.nome = nome;
        }

        //Encapsulando os atributos
        string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        //O que acontece com o atributo idade é o mesmo que acontece acima com o atributo nome, um é explicito e o outro implicito
        public int Idade { get; set; } //isso foi implentado no c# 3.0


        //Destrutor não possui tipo de retorno pq sempre é privado
        ~Aluno()
        {
            Console.WriteLine("Destruindo o objeto");
            Console.ReadKey();
        }
    }
}
