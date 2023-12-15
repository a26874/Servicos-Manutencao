using System;
using System.Collections.Generic;
using System.Text;

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

            string nomeServico = string.Empty;
            string metodoPagamento = string.Empty;
            double precoJardinagem = 250.50;
            double precoPintura = 399.99;
            double montante = 0;
            bool pagamentoValido = false;
            List<string> metodosPagamento = new List<string>();
            string nomeCliente = "Nuno";
            metodosPagamento.Add("MBWAY");
            metodosPagamento.Add("MULTIBANCO");
            metodosPagamento.Add("TRANSFBANCARIA");
            metodosPagamento.Add("PAYPAL");
            Console.WriteLine("Tem os seguintes serviços para pagar:");
            Console.WriteLine("1-Jardinagem no valor de:{0}", precoJardinagem);
            Console.WriteLine("2-Pintura no valor de:{0}", precoPintura);
            Console.Write("Sua escolha:");
            escolha = Convert.ToInt32(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                    Console.WriteLine("Insira o tipo de pagamento e a quantia a pagar para o serviço de jardinagem.");
                    Console.Write("Tipo Pagamento:");
                    metodoPagamento = Console.ReadLine();
                    metodoPagamento = metodoPagamento.ToUpper();
                    Console.Write("Valor:");
                    montante = Convert.ToDouble(Console.ReadLine());

                    if (metodosPagamento.Contains(metodoPagamento) && montante == precoJardinagem)
                    {
                        Console.WriteLine("Pagamento realizado com sucesso.");
                        pagamentoValido = true;
                        nomeServico = "Jardinagem";
                    }
                    else
                        Console.WriteLine("Metodo pagamento ou montante inválidos.");
                    break;
                case 2:
                    Console.WriteLine("Insira o tipo de pagamento e a quantia a pagar para o serviço de pintura.");
                    Console.Write("Tipo Pagamento:");
                    metodoPagamento = Console.ReadLine();
                    metodoPagamento = metodoPagamento.ToUpper();
                    Console.Write("Valor:");
                    montante = Convert.ToDouble(Console.ReadLine());

                    if (metodosPagamento.Contains(metodoPagamento) && montante == precoPintura)
                    {
                        Console.WriteLine("Pagamento realizado com sucesso.");
                        pagamentoValido = true;
                        nomeServico = "Pintura";
                    }
                    else
                        Console.WriteLine("Metodo pagamento ou montante inválidos.");
                    break;
            }
            if (pagamentoValido)
            {
                string fatura = GerarFatura();

                if (nomeServico == "Jardinagem")
                    Console.WriteLine("Nome do cliente:{0} Serviço:{1} IDFatura:{2}", nomeCliente, nomeServico, fatura);
                else if (nomeServico == "Pintura")
                    Console.WriteLine("Nome do cliente:{0} Serviço:{1} IDFatura:{2}", nomeCliente, nomeServico, fatura);
            }


            string GerarFatura()
            {
                const string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

                const int tamanhoIdFatura = 15;

                Random idFaturaRandom = new Random();

                StringBuilder idFaturaBuilder = new StringBuilder();

                for(int i = 0; i < tamanhoIdFatura; i++)
                {
                    char charRandom = caracteres[idFaturaRandom.Next(caracteres.Length)];
                    idFaturaBuilder.Append(charRandom);
                }

                return idFaturaBuilder.ToString();
            }
        }
    }
}
