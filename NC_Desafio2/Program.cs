class program
{
    static void Main(string[] args)
    {
        string[] sistemasOperacionais = { "Windows", "Unix", "Linux", "Netware", "Mac OS", "Outro" };
        int[] votos = new int[6];
        int votosTotais = 0;
        int opcaoEscolhida = 0;

        do
        {
            Console.WriteLine("Digite o número correspondente ao Sistema Operacional (ou 0 para sair):");
            Console.WriteLine("1- Windows\n2- Unix\n3- Linux\n4- Netware\n5- Mac OS\n6- Outro");

            opcaoEscolhida = int.Parse(Console.ReadLine());

            if (opcaoEscolhida >= 0 && opcaoEscolhida <= 6)
            {
                if (opcaoEscolhida > 0)
                {
                    votos[opcaoEscolhida - 1]++;
                    votosTotais++;
                }
            }
            else
            {
                Console.WriteLine("Opção inválida. Por favor, escolha uma opção de 1 a 6.");
            }

        } while (opcaoEscolhida != 0);

        Console.WriteLine("\nQual o melhor Sistema Operacional para uso em servidores?");
        Console.WriteLine("Sistema Operacional\tVotos\t%");

        int maiorVoto = 0;
        int indiceVencedor = 0;

        for (int i = 0; i < sistemasOperacionais.Length; i++)
        {
            double percentualVoto = (double)votos[i] / votosTotais * 100;
            Console.WriteLine($"{sistemasOperacionais[i]}\t\t{votos[i]}\t{percentualVoto:F2}%");

            if (votos[i] > maiorVoto)
            {
                maiorVoto = votos[i];
                indiceVencedor = i;
            }
        }

        Console.WriteLine($"\nO Sistema Operacional mais votado foi o {sistemasOperacionais[indiceVencedor]}, com {maiorVoto} votos, correspondendo a {((double)maiorVoto / votosTotais * 100):F2}% dos votos.");
    }
}
