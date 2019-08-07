using System;

namespace Module_One_Assignment
{
    class Person
    {
        string firstName = "";
        string lastName = "";
        DateTime birthDate;
        string adressLine1 = "";
        string adressLine2 = "";
        string city = "";
        string state = "";
        int zip = 0;
        string country = "";

        public void escreva()
        {
            Console.Clear();
            Console.WriteLine("{0} {1}", firstName, lastName);
            Console.WriteLine($"Born in {birthDate}" + 
                " live in " + state + "-" + city + " of " + country);
            Console.WriteLine(adressLine1 + " " + adressLine2);
            Console.WriteLine(zip);
        }

        public void guarde()
        {
            Console.WriteLine("First Name: ");
            firstName = Console.ReadLine();

            Console.WriteLine("Last Name: ");
            lastName = Console.ReadLine();

            Console.WriteLine("Year of Born: ");
            int ano = int.Parse(Console.ReadLine());
            Console.WriteLine("Month of Born: ");
            int mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Day of Born: ");
            int dia = int.Parse(Console.ReadLine());
            birthDate = new DateTime(ano, mes, dia);

            Console.WriteLine("Your public place: ");
            adressLine1 = Console.ReadLine();

            Console.WriteLine("Complement: ");
            adressLine2 = Console.ReadLine();

            Console.WriteLine("City: ");
            city = Console.ReadLine();

            Console.WriteLine("State: ");
            state = Console.ReadLine();

            Console.WriteLine("ZIP code: ");
            zip = int.Parse(Console.ReadLine());

            Console.WriteLine("Country: ");
            country = Console.ReadLine();
        }
    }

    class UProgram
    {
        string name = "";
        string departmentHead = "";
        string degrees = "";

        public void escreva()
        {
            /*Método para mostrar dados dessa classe*/
        }

        public void guarde()
        {
            /*Método para fazer o set dos dados*/
        }
    }

    class Degree
    {
        string name = "";
        short creditsRequired = 0;

        public void escreva()
        {
            /*Método para mostrar dados dessa classe*/
        }

        public void guarde()
        {
            /*Método para fazer o set dos dados*/
        }
    }

    class Course
    {
        string name = "";
        short credits = 0;
        byte durationWeeks = 0;
        Person teacher;

        public void escreva()
        {
            /*Método para mostrar dados dessa classe*/
        }

        public void guarde()
        {
            /*Método para fazer o set dos dados*/
        }
    }

    class Program
    {
        public static void Main()
        {
            Person aluno = new Person();
            aluno.guarde();

            aluno.escreva();
        }
    }
}
