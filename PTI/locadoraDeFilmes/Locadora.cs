public class Locadora
{
    Filme[] filmes = new Filme[0];

    public void Add(Filme filme)
    {
        Filme[] novo = new Filme[filmes.Length + 1];

        // Copiar filmes existentes para o novo array
        for (int cont = 0; cont < filmes.Length; cont++)
        {
            novo[cont] = filmes[cont];
        }

        // Adicionar o novo filme ao array
        novo[filmes.Length] = filme;
        filmes = novo;
    }

    public void lista()
    {
        if (filmes.Length == 0)
        {
            System.Console.WriteLine("Nenhum filme cadastrado.");
            return;
        }

        // Exibir detalhes de cada filme, incluindo estoque
        foreach (Filme lista in filmes)
        {
            System.Console.WriteLine($"Nome: {lista.nome}, Preço: {lista.preco}, Autor(a): {lista.autor}, Gênero: {lista.genero} - {lista.estoque} estoque");
        }
    }

    public void Remover(string nome)
    {
        int index = -1;
        for (int i = 0; i < filmes.Length; i++)
        {
            if (filmes[i].nome == nome)
            {
                index = i;
                break;
            }
        }

        if (index == -1)
        {
            System.Console.WriteLine("Filme não encontrado!");
            return;
        }

        Filme[] novo = new Filme[filmes.Length - 1];
        for (int i = 0, j = 0; i < filmes.Length; i++)
        {
            if (i != index)
            {
                novo[j++] = filmes[i];
            }
        }

        filmes = novo;
    }

    public void entStk(string nome, int quantidade)
    {
        foreach (Filme filme in filmes)
        {
            if (filme.nome == nome)
            {
                filme.estoque += quantidade;
                return;
            }
        }
        System.Console.WriteLine("  " + nome);
    }

    public void SaidaEstoque(string nome, int quantidade)
    {
        foreach (Filme lista in filmes)
        {
            if (lista.nome == nome)
            {
                if (lista.estoque >= quantidade)
                {
                    lista.estoque -= quantidade;
                }
                else
                {
                    System.Console.WriteLine("Estoque insuficiente!");
                }
                return;
            }
        }
        System.Console.WriteLine("Filme não encontrado!");
          
    }

    public void sair(string text)
    {
        System.Console.WriteLine(text);
        Environment.Exit(0);
    }
}
