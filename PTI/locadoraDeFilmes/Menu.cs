public class Menu
{
    private Locadora locadora; // Campo privado para Locadora

    // Construtor que inicializa o campo locadora
    public Menu(Locadora locadora)
    {
        this.locadora = locadora ?? throw new ArgumentNullException(nameof(locadora)); // Garante que locadora não seja nulo
    }

    // Método principal para exibir o menu
    public void exMenu()
    {
        int opcao;
        do
        {
            System.Console.WriteLine("----------------------------------------");
            System.Console.WriteLine("LOCADORA DE FILMES - CONTROLE DE ESTOQUE");
            System.Console.WriteLine("[1] Adicionar Filme");
            System.Console.WriteLine("[2] Listar Filmes");
            System.Console.WriteLine("[3] Remover Filme");
            System.Console.WriteLine("[4] Entrada de Estoque");
            System.Console.WriteLine("[5] Saída de Estoque");
            System.Console.WriteLine("[0] Sair");
            System.Console.WriteLine("-----------------------------------------");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    addNew();
                    break;
                case 2:
                    locadora.lista();
                    break;
                case 3:
                    rmFlm();
                    break;
                case 4:
                    entStk();
                    break;
                case 5:
                    saiStk();
                    break;
                case 0:
                    locadora.sair("Saindo...    ");
                    break;
                default:
                    System.Console.WriteLine("Opção inválida!");
                    break;
            }
        } while (opcao != 0);
    }

    // Método para saída de estoque
    private void saiStk()
    {
        System.Console.WriteLine("Nome do filme: ");
        string nome = System.Console.ReadLine();
        System.Console.WriteLine("Quantidade: ");
        int quantidade = int.Parse(System.Console.ReadLine());
        locadora.SaidaEstoque(nome, quantidade);
        System.Console.WriteLine("Saída de estoque realizada com sucesso!");
    }

    // Método para entrada de estoque
    private void entStk()
    {
        System.Console.WriteLine("Nome do filme: ");
        string nome = System.Console.ReadLine();
        System.Console.WriteLine("Quantidade: ");
        int quantidade = int.Parse(System.Console.ReadLine());
        locadora.entStk(nome, quantidade); // Corrigido para corresponder ao método na classe Locadora
        System.Console.WriteLine("Entrada de estoque realizada com sucesso!");
    }

    // Método para remover filme
    private void rmFlm()
    {
        System.Console.WriteLine("Nome do filme a ser removido: ");
        string nome = System.Console.ReadLine();
        locadora.Remover(nome);
        System.Console.WriteLine("Filme removido com sucesso!");
    }

    // Método para adicionar filme
    private void addNew()
    {
        System.Console.WriteLine("Nome do filme: ");
        string nome = System.Console.ReadLine();
        System.Console.WriteLine("Preço do filme:");
        double preco = double.Parse(System.Console.ReadLine());
        System.Console.WriteLine("Diretor(a) do filme: ");
        string autor = System.Console.ReadLine();
        System.Console.WriteLine("Gênero do filme: ");
        string genero = System.Console.ReadLine();

        Filme filme = new Filme { nome = nome, preco = preco, autor = autor, genero = genero, estoque = 0 };
        locadora.Add(filme);
        System.Console.WriteLine("Filme adicionado com sucesso!");
    }
}
