// Nesta aula vamos aplicar o seguinte projeto para gerenciamento de 10 produtos pelo console:

// Os produtos terão os seguintes atributos:
// string Nome
// float Preco
// bool Promocao (se está em promoção ou não)

// O sistema deverá ter as seguintes funcionalidades:
// CadastrarProduto
// ListarProdutos
// MostrarMenu

using System.Globalization;

string[] nome = new string[1000];
float[] preco = new float[1000];
bool[] promocao = new bool[1000];

string estaEmPromocao;
string escolhaListagem;
bool loopBreak = true;

do
{
    menuComeco:
    Console.Clear();
Console.WriteLine(@$"
        GERENCIAMENTO DE PRODUTOS v1.0
    
    Digite um número correspondente do serviço
            que deseja utilizar:
    
            1 - Cadastrar Produtos
            2 - Listrar Produtos

            0 - Encerrar programa        
");
string escolhaMenu = Console.ReadLine();

switch (escolhaMenu)
{
    case "1":
    for (var i = 0; i < preco.Length; i++)
    {
        Console.Clear();
    Console.WriteLine(@$"
        CADASTRO DE PRODUTOS

    Informe os dados do produto que
    deseja cadastrar em nosso sistema:

    ");

Console.WriteLine($"Digite o nome do produto:");
nome[i] = Console.ReadLine();

Console.WriteLine($"Digite o preço do produto;");
preco[i] = float.Parse(Console.ReadLine());

Console.WriteLine($"O produto está em promoção? 's' para sim ou 'n' para não.");
escolhaUser:
string promocaoCadastro = Console.ReadLine().ToLower();

    if(promocaoCadastro == "s"){
        promocao[i] = true;
    } 
    else if(promocaoCadastro == "n"){
        promocao[i] = false;
    }
    else{
        Console.WriteLine($"Opção inválida, por favor digite 's' para sim e 'n' para não.");
        goto escolhaUser;
    }

    Console.WriteLine($"Produto Cadastrado! Deseja cadastrar outro produto? 's' para sim ou 'n' para não.");
    escolhaUser1:
    string cadastrarOutro = Console.ReadLine().ToLower();

    if(cadastrarOutro == "s"){
        
    } 
    else if(cadastrarOutro == "n"){
        Console.Clear();
        goto menuComeco;
    }
    else{
        Console.WriteLine($"Opção inválida, por favor digite 's' para sim e 'n' para não.");
        goto escolhaUser1;
    }
    }
        break;

    case "2":
    Console.Clear();
    Console.WriteLine($"Esses são os produtos cadastrados em nosso sistema!");
    Console.WriteLine($"");
    
    for (var i = 0; i < preco.Length; i++)
    {

        if(nome[i] == null){
            Console.WriteLine();
            Console.WriteLine($"Esses foram os produtos cadastrados");
            goto endOfList;
        }
        Console.WriteLine($"------------------------------------------------");
        Console.WriteLine($"");
        
        
        Console.WriteLine($"Nome do produto: {nome[i]}");
        Console.WriteLine(@$"O produto custa: {Math.Round(preco[i], 2).ToString("C", new CultureInfo("pt-BR"))}");
        if(promocao[i]){
            Console.WriteLine($"O produto está em promoção!");
    
        }
        else{
            Console.WriteLine($"O produto não está em promoção");
        }
        Console.WriteLine($"");
        Console.WriteLine($"------------------------------------------------");
    }

    endOfList:
        do
        {
            Console.WriteLine($"O que deseja fazer?");
            Console.WriteLine($"[1] - retornar ao menu");
            Console.WriteLine($"[2] - sair");
            escolhaListagem = Console.ReadLine();

            if (escolhaListagem == "1")
            {
                goto menuComeco;
            }
            else if (escolhaListagem == "2")
            {
                Console.WriteLine($"Encerrando programa...");
                Thread.Sleep(3000);
                loopBreak = false;
                break;
            }
            else{
                Console.WriteLine($"Numero inválido, Por favor digite um número correto");
            }
            
        } while (escolhaListagem != "2" || escolhaListagem != "1");

    break;

    case "0":
    Console.Clear();
        Console.WriteLine($"Encerrando programa...");
        Thread.Sleep(3000);
        loopBreak = false;
        break;
    default:
    Console.WriteLine($"Digite um número válido");
    goto menuComeco;

    
}
} while (loopBreak);


