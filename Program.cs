using System;

namespace Mod1_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            string primeiroNome = "";
            string ultimoNome = "";
            int idade = 0;
            string rua = "";
            string cidade = "";
            string patria = "";
            DateTime dataNascimento;

            primeiroNome = "Iuri";
            ultimoNome = "Cesar Caliman";
            idade = 22;
            rua = "Rua 14";
            cidade = "Goiania";
            patria = "Brasil";
            dataNascimento = new DateTime(1996, 9, 17);

            Console.WriteLine(primeiroNome);
            Console.WriteLine(ultimoNome);

            Console.WriteLine("{0} anos de idade", idade);

            Console.WriteLine(rua + "," + cidade + "," + patria);

            Console.WriteLine($"Nascido em: {dataNascimento}");
        }
    }
}
