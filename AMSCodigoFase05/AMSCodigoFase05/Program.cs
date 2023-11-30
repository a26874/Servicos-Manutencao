using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMSCodigoFase05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = "teste";
            string password = "123teste";
            bool teste = false;
            Console.WriteLine("Bem-Vindo à plataforma de Serviços de Manutenção");
            Console.Write("Insira o seu username:");
            if (username == Console.ReadLine())
                teste = true;
            else
                teste = false;
            Console.Write("Insira a sua password:");
            if (password == Console.ReadLine())
                teste = true;
            else
                teste = false;

            if (teste)
                Console.WriteLine("Login realizado com sucesso.");
            else
                Console.WriteLine("Username ou password errados.");


            Console.WriteLine("Serviços disponíveis:");
            Console.WriteLine("1 - Jardinagem");
            Console.WriteLine("2 - Pintura");
            Console.WriteLine("3 - Limpeza");
            int escolha;
            Console.WriteLine("Qual serviço deseja requisitar?");
            Console.Write("Escolha:");
            escolha = Convert.ToInt32(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Console.WriteLine("Escolheu o serviço de Jardinagem.");
                    break;
                case 2:
                    Console.WriteLine("Escolheu o serviço de Pintura.");
                    break;
                case 3:
                    Console.WriteLine("Escolheu o serviço de Limpeza.");
                    break;
                default:
                    Console.WriteLine("Serviço não existe.");
                    break;
            }

            Console.WriteLine("Registo de serviços.");
            Console.WriteLine("Qual o serviço que pretende registar?");
            Console.Write("Introduza aqui:");
            string serviço = Console.ReadLine();
            Console.WriteLine("Serviço {0} introduzido com sucesso!", serviço);
        }
    }
}
