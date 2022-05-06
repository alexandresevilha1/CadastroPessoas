using PFS_UC12___EncontroRemoto2.classes;

Console.WriteLine(@$"
=================================================
|   Bem vindo ao sistema de cadastro de         |
|       Pessoas Físicas e Juridicas             |
=================================================
");

BarraCarregamento("Carregando", 500);

List<PessoaFisica> listaPf = new List<PessoaFisica>();

string? opcao;
do{
    Console.Clear();

    Console.WriteLine(@$"
=======================================
|     Escolha uma das opções abaixo   |
---------------------------------------
|      1 - Pessoa Física              |
|      2 - Pessoa Jurídica            |
|                                     |
|      0 - Sair                       |
=======================================
");

opcao = Console.ReadLine();

switch (opcao)
{
    case "1":

         PessoaFisica metodoPf = new PessoaFisica();

        string? opcaoPf;

        do
        {

            Console.Clear();

            Console.WriteLine(@$"

=======================================
|     Escolha uma das opções abaixo   |
---------------------------------------
|      1 - Cadastrar Pessoa Física    |
|      2 - Listar Pessoa Física       |
|                                     |
|      0 - Voltar ao menu anterior    |
=======================================
");

        opcaoPf = Console.ReadLine();

        switch (opcaoPf)
        {
            case "1":

                    PessoaFisica novaPf = new PessoaFisica();
                    Endereco novoEnd = new Endereco();

                    Console.WriteLine($"Digite o nome da pessoa que deseja cadastrar");
                    novaPf.Nome = Console.ReadLine();

                    bool dataValida;

                    do
                    {

                        Console.WriteLine($"Digite a data de nascimento Ex:DD/MM/AAAA");
                        string? dataNasc = Console.ReadLine();

                    dataValida = metodoPf.ValidarDataNasc(dataNasc);
                    
                    if (dataValida)
                    {

                        novaPf.dataNasc = dataNasc;

                    }
                    else
                    {

                        Console.WriteLine($"Data digitada invalida, por favor digite uma nova data valida");
                        
                    }

                    } while (!dataValida);

                    Console.WriteLine($"Digite o numero do CPF");
                    novaPf.Cpf = Console.ReadLine();

                    Console.WriteLine($"Digite o rendimento mensal(digite somente numeros)");
                    novaPf.rendimento = float.Parse(Console.ReadLine());

                    Console.WriteLine($"Digite o logradouro");
                    novoEnd.logradouro = Console.ReadLine();

                    Console.WriteLine($"Digite o numero");
                    novoEnd.numero = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Digite o complemento (aperte ENTER para vazio)");
                    novoEnd.complemento = Console.ReadLine();

                    Console.WriteLine($"Este endereço é comercial? S/N");
                    string endCom = Console.ReadLine().ToUpper();

                    if (endCom == "S")
                    {

                       novoEnd.endComercial = true; 

                    }
                    else
                    {

                        novoEnd.endComercial = false; 
                        
                    }

                    novaPf.Endereco = novoEnd;

                    listaPf.Add(novaPf);

                    Console.WriteLine($"Cadastro realizado com sucesso");
                    Thread.Sleep(3000);
                    

                break;

            case "2":

                    Console.Clear();

                    if (listaPf.Count > 0)
                    {

                        foreach (PessoaFisica cadaPessoa in listaPf)
                        {
                            
                            Console.WriteLine(@$"
                            Nome: {cadaPessoa.Nome}
                            CPF: {cadaPessoa.Cpf}
                            Endereço: {cadaPessoa.Endereco.logradouro}, {cadaPessoa.Endereco.numero}
                            Rendimento: {cadaPessoa.rendimento.ToString("C")}
                            Taxa de imposto a ser pago é: {metodoPf.PagarImposto(cadaPessoa.rendimento).ToString("C")}
                            ");

                    Console.WriteLine($"Aperte 'Enter' para continuar");
                    Console.ReadLine();


                        }
                        
                    }
                    else
                    {

                        Console.WriteLine($"Lista vazia!");
                        Thread.Sleep(3000);
                
                    }

                    
                break;

            case "0":
                break;

            default:
                Console.Clear();
                Console.WriteLine($"Opção Invalida, por favor digite outra opção");
                Thread.Sleep(2000);
                break;
        }
            
        } while (opcaoPf != "0");

        break;

    case "2":

PessoaJuridica metodoPJ = new PessoaJuridica();
PessoaJuridica novaPJ = new PessoaJuridica();
Endereco endPJ = new Endereco();

novaPJ.Nome = "Nome PJ";
novaPJ.razaoSocial = "Razão social Pj";
novaPJ.Cnpj = "00.000.000/0001-00";
novaPJ.rendimento = 10000.5f;

endPJ.logradouro = "Endereço qualquer";
endPJ.numero = 157;
endPJ.complemento = "rua qualquer";
endPJ.endComercial = true;

novaPJ.Endereco = endPJ;

Console.Clear();

Console.WriteLine(@$"
Nome: {novaPJ.Nome}
Razão Social: {novaPJ.razaoSocial}
CNPJ: {novaPJ.Cnpj}
CNPJ Válido: {metodoPJ.ValidarCnpj(novaPJ.Cnpj)}

");

Console.WriteLine($"Aperte 'Enter' para continuar");
Console.ReadLine();

Console.WriteLine(metodoPJ.ValidarCnpj("00.000.000/00001-00"));

        break;

    case "0":

        Console.WriteLine($"Obrigado por utilizar nosso sistema!");

        BarraCarregamento("Finalizando", 300);

        break;

    default:
        Console.Clear();
        Console.WriteLine($"Opção Invalida, por favor digite outra opção");
        Thread.Sleep(2000);
        
        break;             
}

} while (opcao != "0");

static void BarraCarregamento(string texto, int tempo) {
    Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.DarkCyan;

        Console.Write(texto);

        for (var i = 0; i < 6; i++)
        {
        Console.Write(".");
        Thread.Sleep(tempo);
        }
        Console.ResetColor();
};









