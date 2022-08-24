using LendoTxtEPegandoCertosDados;

class Program
{
    static void Main(string[] args)
    {
        Intro();

        Console.WriteLine(@"Pra começar, digite ou cole o caminho do arquivo .txt (ex. C:\Users\MeuPC\email.txt)");
        Console.WriteLine("");

        string meuArquivo = Console.ReadLine();
        Console.WriteLine("");
        if (!meuArquivo.Any())
        {
            Console.WriteLine("Opa, arquivo vazio ou inexistente!");
        }

        Console.WriteLine("Agora, digite parte do nome que deseja filtrar. Ex: @hotmail -> para só pegar e-mails.");
        Console.WriteLine("");
        string parteDoNomeDesejado = Console.ReadLine();
        var listaDeDados = LerArquivo.LendoArquivo(meuArquivo, parteDoNomeDesejado);

        Console.WriteLine("Abaixo está a lista de dados selecionada: ");
        Console.WriteLine("                    |                     ");
        Console.WriteLine("                    v                     ");

        foreach (var linha in listaDeDados)
        {
            Console.WriteLine($"{linha.Nome}");
        }

        Console.WriteLine("");
        Console.WriteLine("Deseja criar um novo arquivo só com os dados que filtrou? Digite 'Sim' ou 'Nao' (sem acentos).");
        Console.WriteLine("");
        string decisao = Console.ReadLine();
        _ = decisao.ToLower();
        using StreamWriter novoArquivo = new("NovoArquivo.txt");

        switch (decisao)
        {
            case "sim":
                foreach (var linha in listaDeDados)
                {
                    novoArquivo.WriteLineAsync(linha.Nome);
                }
                break;

            case "nao":
                Console.WriteLine("Obrigado por usar a aplicação!");
                break;
            default:
                Console.WriteLine("Fail");
                break;
        }
    }

    private static void Intro()
    {
        Console.WriteLine("################## Olá, bem vindo ao leitor de txt ##################");
        Console.WriteLine("");
        Thread.Sleep(3000);
        Console.WriteLine("Esse simples programa lê arquivos .txt e filtra só as palavras que contenham determinados caracteres.");
        Thread.Sleep(3000);
        Console.WriteLine(".");
        Thread.Sleep(1000);
        Console.WriteLine(".");
        Thread.Sleep(1000);
        Console.WriteLine(".");
        Thread.Sleep(1000);
        Console.WriteLine(".");
        Thread.Sleep(1000);
        Console.WriteLine(".");
        Thread.Sleep(1000);
        Console.WriteLine("Uma ideia de uso da ferramenta, é quando você salva vários dados mas só quer pegar aqueles que são e-mail, por exemplo.");
        Thread.Sleep(3000);
        Console.WriteLine("##########################################################");
        Thread.Sleep(1000);
        Console.WriteLine(".");
        Thread.Sleep(1000);
        Console.WriteLine(".");
        Thread.Sleep(2000);
    }
}