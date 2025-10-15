using FilaExemplo;

class Program
{
    static void Main(string[] args)
    {
        Fila fila = new Fila();
        int num = 0;

        do
        {
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1 - Inserir Pessoa");
            Console.WriteLine("2 - Remover Pessoa");
            Console.WriteLine("3 - Exibir Fila");
            Console.WriteLine("4 - Sair");

            int opcao = int.Parse(Console.ReadLine()!);

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Digite o nome:");
                    Pessoa novaPessoa = new Pessoa();
                    novaPessoa.Nome = Console.ReadLine()!;
                    fila.InserirPessoa(novaPessoa);
                    break;
                case 2:
                    fila.RemoverPessoa();
                    break;
                case 3:
                    fila.ImprimirFila();
                    break;
                case 4:
                    Console.WriteLine("Saindo...");
                    num = 4;
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

        } while (num != 4);
    }
}
