namespace Algoritimos.Vetor
{
    internal static class Exercicio5
    {
        internal static void Executar()
        {
            int tamanhoDoVetor = 10;
            string[] letras = new string[tamanhoDoVetor];
            

            for (int i = 0; i < tamanhoDoVetor; i++)
            {
                Console.Write($"Digite a letra {i + 1}: ");
                letras[i] = Console.ReadLine().ToLower();
            }

            bool temB = false;
            bool temR = false;
            bool temA = false;
            bool temS = false;
            bool temI = false;
            bool temL = false;
            
            foreach (string letra in letras)
            {
                if (letra == "b")   
                    temB = true;
                else if (letra == "r")
                    temR = true;
                else if (letra == "a")
                    temA = true;
                else if (letra == "s")
                    temS = true;
                else if (letra == "i")
                    temI = true;
                else if (letra == "l")
                    temL = true;
            }            
            
            if (temB && temR && temA && temS && temI && temL)
            {
                Console.WriteLine("Brasil encontrado no vetor");
            }
            else
            {
                Console.WriteLine("Brasil não encontrado no vetor");
            }
            
        }

    }
}
