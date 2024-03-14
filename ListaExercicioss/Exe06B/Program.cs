namespace Exe06B;

class Program
{
    static void Main(string[] args)
    {
        int[] vetor = new int[1000];

        //numero randomico

        Random aleatorio = new Random();

        //preencher vetor com valores aleatorios
        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = aleatorio.Next(100);
        }

        //colocar em ordem

        Array.Sort(vetor);

        //imprimir vetor
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write(vetor[i] + " ");
        }
    }
}
