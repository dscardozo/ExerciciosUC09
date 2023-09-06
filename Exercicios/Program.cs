namespace Algoritimos
{
    internal class Program
    {
        static void Main(string[] args)
        {    
            string lista;
            string exercicio;

            Console.WriteLine("Informe a Lista : ");
            lista = Console.ReadLine();
            Console.WriteLine("Informe o exercicio desejado: ");
            exercicio = Console.ReadLine();

            if (lista == "1")
            {
                switch (exercicio)
                {
                    case "1":
                        Algoritimos.Lista1.Exercicio1.Executar();
                        break;
                    case "2":
                        Algoritimos.Lista1.Exercicio2.Executar();
                        break;
                    case "3":
                        Algoritimos.Lista1.Exercicio3.Executar();
                        break;
                    case "4":
                        Algoritimos.Lista1.Exercicio4.Executar();
                        break;
                    case "5":
                        Algoritimos.Lista1.Exercicio5.Executar();
                        break;
                    case "6":
                        Algoritimos.Lista1.Exercicio6.Executar();
                        break;
                    case "7":
                        Algoritimos.Lista1.Exercicio7.Executar();
                        break;
                    default:
                        Console.WriteLine("Exercicio Inexistente");
                        break;
                }
            }
            else if (lista == "2")
            {
                switch (exercicio)
                {
                    case "1":
                        Algoritimos.Lista2.Exercicio1.Executar();
                        break;
                    case "2":
                        Algoritimos.Lista2.Exercicio2.Executar();
                        break;
                    case "3":
                        Algoritimos.Lista2.Exercicio3.Executar();
                        break;
                    case "4":
                        Algoritimos.Lista2.Exercicio4.Executar();
                        break;
                    case "5":
                        Algoritimos.Lista2.Exercicio5.Executar();
                        break;
                    case "6":
                        Algoritimos.Lista2.Exercicio6.Executar();
                        break;
                    case "7":
                        Algoritimos.Lista2.Exercicio7.Executar();
                        break;
                    case "8":
                        Algoritimos.Lista2.Exercicio8.Executar();
                        break;
                    default:
                        Console.WriteLine("Exercicio Inexistente");
                        break;
                }
            }
            else if (lista == "3")
            {
                switch (exercicio)
                {
                    case "1":
                        Algoritimos.Lista3.Exercicio1.Executar();
                        break;
                    case "2":
                        Algoritimos.Lista3.Exercicio2.Executar();
                        break;
                    case "3":
                        Algoritimos.Lista3.Exercicio3.Executar();
                        break;
                    case "4":
                        Algoritimos.Lista3.Exercicio4.Executar();
                        break;
                    case "5":
                        Algoritimos.Lista3.Exercicio5.Executar();
                        break;
                    case "d1":
                        Algoritimos.Lista3.Desafio1.Executar();
                        break;
                    default:
                        Console.WriteLine("Exercicio Inexistente");
                        break;
                }
            }
            else if (lista == "4")
            {
                switch (exercicio)
                {
                    case "1":
                        Algoritimos.Lista4.Exercicio1.Executar();
                        break;
                    case "2":
                        Algoritimos.Lista4.Exercicio2.Executar();
                        break;
                    case "3":
                        Algoritimos.Lista4.Exercicio3.Executar();
                        break;
                    case "4":
                        Algoritimos.Lista4.Exercicio4.Executar();
                        break;
                    case "5":
                        Algoritimos.Lista4.Exercicio5.Executar();
                        break;
                    case "6":
                        Algoritimos.Lista4.Exercicio6.Executar();
                        break;
                    default:
                        Console.WriteLine("Exercicio Inexistente");
                        break;
                }
            }
            else if (lista == "5")
            {
                switch (exercicio)
                {
                    case "1":
                        Algoritimos.Lista5.Exercicio1.Executar();
                        break;
                    case "2":
                        Algoritimos.Lista5.Exercicio2.Executar();
                        break;
                    case "3":
                        Algoritimos.Lista5.Exercicio3.Executar();
                        break;

                    default:
                        Console.WriteLine("Exercicio Inexistente");
                        break;
                }
            }
            else if (lista == "6")
            {
                switch (exercicio)
                {
                    case "1":
                        Algoritimos.Lista6.Exercicio1.Executar();
                        break;
                    case "2":
                        Algoritimos.Lista6.Exercicio2.Executar();
                        break;
                    case "3":
                        Algoritimos.Lista6.Exercicio3.Executar();
                        break;
                    case "4":
                        Algoritimos.Lista6.Exercicio4.Executar();
                        break;
                    case "5":
                        Algoritimos.Lista6.Exercicio5.Executar();
                        break;
                    default:
                        Console.WriteLine("Exercicio Inexistente");
                        break;
                }
            }
            else if (lista == "Testes")
            {
                switch (exercicio)
                {
                    case "1":
                        Algoritimos.Testes.Testes.Executar();
                        break;
                    case "2":
                        Algoritimos.Testes.Testes2.Principal();
                        break;
                    case "3":
                        Algoritimos.Testes.Testes3.Executar();
                        break;

                    default:
                        Console.WriteLine("Exercicio Inexistente");
                        break;
                    
                }
            }
            else if (lista == "Ex")
            {
                switch (exercicio.ToLower())
                {
                    case "Cotacao":
                        Algoritmos.Ex.Cotacao.Principal();
                        break;
                    case "MaiorDeIdade":
                        Algoritimos.Ex.MaiorDeIdade.Executar();
                        break;
                    case "Cep":
                        Algoritimos.Ex.Cep.Principal();
                        break;
                    case "Foreach":
                        Algoritimos.Ex.Foreach.Executar();
                        break;
                    case "l":
                        Algoritimos.Ex.LetrasDasPalavras.Executar();
                        break;

                    default:
                        Console.WriteLine("Exercicio Inexistente");
                        break;
                }
            }
            else if (lista == "V".ToLower())
            {
                switch (exercicio.ToUpper())
                {
                    case "1":
                        Algoritimos.Vetor.Exercicio1.Executar();
                        break;
                    case "2":
                        Algoritimos.Vetor.Exercicio2.Executar();
                        break;
                    case "3":
                        Algoritimos.Vetor.Exercicio3.Executar();
                        break;
                    case "4":
                        Algoritimos.Vetor.Exercicio4.Executar();
                        break;
                    case "5":
                        Algoritimos.Vetor.Exercicio5.Executar();
                        break;
                    case "6":
                        Algoritimos.Vetor.Exercicio6.Executar();
                        break;
                    case "7":
                        Algoritimos.Vetor.Exercicio7.Executar();
                        break;
                    case "D":
                        Algoritimos.Vetor.Desafio1.Executar();
                        break;
                    default:
                        Console.WriteLine("Exercicio Inexistente");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}

