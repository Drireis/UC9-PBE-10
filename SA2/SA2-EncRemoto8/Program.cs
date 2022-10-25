using System.Globalization;
// using instanciando a pasta onde estão as classes que vão ser usadas
using SA2_EncRemoto2.Classes;


// desenvolvendo menu
Console.Clear();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine(@$"
================================================
|      Bem vindo ao sistema de cadastro        |
|      de Pessooas Fisicas e Juridicas         |
================================================
");
Console.ResetColor();

Utils.BarraCarregar("Iniciando", 1000, 5);
// Lista de pessoas físicas cadastradas
List<PessoaFisica> listapf = new List<PessoaFisica>();

String? opcao;

do{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine(@$"
================================================
|      Escolha uma da opções abaixo:           |
|----------------------------------------------|
|         1 - Pessoa Fisica                    |
|         2 - Pessoa Juridica                  |
|                                              |
|         0 - Sair                             |
================================================
");
    Console.ResetColor();
    Console.Write($"Escolha uma opção:");
    opcao = Console.ReadLine();
    
    switch (opcao)
    {
        case "1":
            string? opcaoPf;
            
            do
            {   
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;             
                Console.WriteLine(@$"
================================================
|      Escolha uma da opções abaixo:           |
|----------------------------------------------|
|         1 - Cadastrar Pessoa Física          |
|         2 - Listar Pessoa Física             |
|                                              |
|         0 - Voltar ao menu anterior          |
================================================
                ");
                Console.ResetColor();
                Console.Write($"Escolha uma opção: ");
                opcaoPf = Console.ReadLine();
                PessoaFisica metodoPf = new PessoaFisica();                
                switch (opcaoPf)
                {
                    case "1":
                        PessoaFisica novaPessoaFisica = new PessoaFisica();
                        Endereco novoEnderecoPf = new Endereco();
                        Console.Write(@$"Digite o nome: ");
                        novaPessoaFisica.Nome = Console.ReadLine();
                        Console.Write($"Digite o CPF: ");
                        novaPessoaFisica.Cpf = Console.ReadLine();
                        bool dataValida;
                        do
                        {
                            Console.Write($"Digite a data de nascimento: ex:DD/MM/AAAA: ");
                            string? dataNascimento = Console.ReadLine()!;
                            dataValida = metodoPf.ValidarDataNascimento(dataNascimento);
                            if (dataValida)
                            {   
                                DateTime dataConvertida;
                                DateTime.TryParse(dataNascimento, out dataConvertida);
                                novaPessoaFisica.DataNascimento = dataConvertida;    
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"Data inválida, por favor digite uma data válida");
                                Console.ResetColor();
                            }                            
                        } while (dataValida == false);

                        Console.Write($"Informe seu rendimento mensal: ");                        
                        novaPessoaFisica.Rendimento = float.Parse(Console.ReadLine()!);
                        Console.Write($"Digite o Logradouro: ");
                        novoEnderecoPf.Logradouro = Console.ReadLine();
                        Console.Write($"Digite o número: ");
                        novoEnderecoPf.Numero = int.Parse(Console.ReadLine()!);
                        Console.Write($"Informe o complemento: ");
                        novoEnderecoPf.Complemento = Console.ReadLine();
                        Console.Write("Endereço comercial? 'S' ou 'N': ");
                        string endCom1 = Console.ReadLine()!.ToUpper();
                        if (endCom1 == "S")
                        {
                            novoEnderecoPf.Comercial = true;    
                        }
                        else
                        {
                            novoEnderecoPf.Comercial = false;    
                        }
                        novaPessoaFisica.Endereco = novoEnderecoPf;

                        listapf.Add(novaPessoaFisica);

                        // StreamWriter sw = new StreamWriter($"{novaPessoaFisica.Nome}.txt"); // exemplo: Adriano.txt
                        // sw.WriteLine(novaPessoaFisica.Nome); // Exemplo: Carlos
                        // sw.Close(); 

                        using(StreamWriter sw = new StreamWriter($"{novaPessoaFisica.Nome}.txt"))
                        {
                            sw.WriteLine(novaPessoaFisica.Nome);
                        } 



                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine($"Cadastro realizado com sucesso!");
                        Thread.Sleep(3000);                        
                        Console.ResetColor();                                                
                        break;
                    case "2":                        
                        using(StreamReader sr = new StreamReader("Adriano.txt"))
                        {
                            string? linha;

                            while((linha = sr.ReadLine()) != null)
                            {
                                Console.WriteLine($"{linha}");
                            }
                        }
                        Console.WriteLine($"Aperte 'Enter' para continuar");
                        Console.ReadLine();

                        break;
                    case "0":
                        break;        
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Digite uma opção valida!");
                        Console.ResetColor();
                        Thread.Sleep(3000);
                        break;
                }
                 
            } while (opcaoPf != "0");

            break;
        case "2":
            PessoaJuridica novaPessoaJuridica = new PessoaJuridica();

            Endereco novoEndereco = new Endereco();
            novoEndereco.Logradouro = "Rua Niterói";
            novoEndereco.Numero = 180;
            novoEndereco.Complemento = "São Caetano do Sul - SP";
            novoEndereco.Comercial = true;


            novaPessoaJuridica.Nome = "Senai";
            novaPessoaJuridica.RazaoSocial = "Escola Senai de Informática Ltda";
            novaPessoaJuridica.Cnpj = "58352125000149";
            novaPessoaJuridica.Rendimento = 100000.99f;
            novaPessoaJuridica.Endereco = novoEndereco;

            PessoaJuridica metodosPj = new PessoaJuridica();

            metodosPj.Inserir(novaPessoaJuridica);
            
            List<PessoaJuridica> listaPj = metodosPj.LerArquivo();

            foreach (PessoaJuridica cadaItem in listaPj)
            {
                Console.WriteLine(@$"
                Nome Fantasia: {cadaItem.Nome}
                Cnpj: {cadaItem.Cnpj}
                Razão Social: {cadaItem.RazaoSocial}
                ");
                Console.WriteLine($"Aperte 'Enter' para continuar");
                Console.ReadLine();               
            }
            break;            
        case "0":
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Agradecemos por usar o nosso sistema!");
            Console.ResetColor();
            Thread.Sleep(3000);
            break;

        default:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Digite um número valido!");
            Console.ResetColor();
            Thread.Sleep(3000);
            break;
    }
}while (opcao != "0");

Utils.BarraCarregar("Finalizando", 500, 5);

//@ para quebra de linha antes do $ utilizando interpolação
//             Console.WriteLine(@$"
// Pessoa fisica
// Nome: {novaPessoaFisica.Nome}
// Data de nascimento: {novaPessoaFisica.DataNascimento}
// Cpf: {novaPessoaFisica.Cpf}
// Rendimento: {novaPessoaFisica.Rendimento}
// Imposto á pagar: {metodosPf.PagarImposto(novaPessoaFisica.Rendimento).ToString("c", new CultureInfo("pt-BR"))}
// Maior de idade - datetime: {metodosPf.ValidarDataNascimento(novaPessoaFisica.DataNascimento)}
// Maior de idade - datetime: {(metodosPf.ValidarDataNascimento(novaPessoaFisica.DataNascimento) ? "Sim" : "Não")}
// Maior de idade - string: {metodosPf.ValidarDataNascimento("01/05/1998")}
// ");


































// criando objeto 
//Tipo NomeDoObjeto = MetodoConstrutor();

// instaciando objeto do tipo pessoa fisica
// PessoaFisica novaPessoaFisica = new PessoaFisica();

// //atribuimos um valor as propriedades
// novaPessoaFisica.Nome = "Adriano";
// novaPessoaFisica.Cpf = "12345678912";
// novaPessoaFisica.DataNascimento = new DateTime(2000, 10, 10);
// novaPessoaFisica.Rendimento = 1500.15f;

//imiprimindo os valores do objeto
// Console.WriteLine("Nome: " + novaPessoaFisica.Nome);
// Console.WriteLine("CPF: " + novaPessoaFisica.Cpf);
// Console.WriteLine("Data de nascimento:" + novaPessoaFisica.DataNascimento);
// Console.WriteLine("Rendimento: " + novaPessoaFisica.Rendimento);

// // interpolação iniciada com $ e atributo entre colchetes
// Console.WriteLine($"Nome: {novaPessoaFisica.Nome}");
// Console.WriteLine($"Nome: {novaPessoaFisica.Cpf}");
// Console.WriteLine($"Nome: {novaPessoaFisica.DataNascimento}");
// Console.WriteLine($"Nome: {novaPessoaFisica.Rendimento}");

// PessoaFisica metodosPf = new PessoaFisica();
// //@ para quebra de linha antes do $ utilizando interpolação
// Console.WriteLine(@$"
// Pessoa fisica
// Nome: {novaPessoaFisica.Nome}
// Data de nascimento: {novaPessoaFisica.DataNascimento}
// Cpf: {novaPessoaFisica.Cpf}
// Rendimento: {novaPessoaFisica.Rendimento}
// Imposto á pagar: {metodosPf.PagarImposto(novaPessoaFisica.Rendimento).ToString("c", new CultureInfo("pt-BR"))}
// Maior de idade - datetime: {metodosPf.ValidarDataNascimento(novaPessoaFisica.DataNascimento)}
// Maior de idade - datetime: {(metodosPf.ValidarDataNascimento(novaPessoaFisica.DataNascimento) ? "Sim" : "Não")}
// Maior de idade - string: {metodosPf.ValidarDataNascimento("01/05/1998")}
// ");


//instanciar PessoaJuridica
//PessoaJuridica novaPessoaJuridica = new PessoaJuridica();

//instanciamos um objeto do tipo endereço,atribuimos valores para os atributos
// Endereco novoEndereco = new Endereco();
// novoEndereco.Logradouro = "Quadra";
// novoEndereco.Numero = 50;
// novoEndereco.Complemento = "Conjunto A";
// novoEndereco.Comercial = true;

// //atribuimos valores para os atributos do objeto pessoa juridica
// novaPessoaJuridica.Nome = "Curso Senai";
// novaPessoaJuridica.RazaoSocial = "Escola Senai de Programação";
// novaPessoaJuridica.Cnpj = "00.000.000/0001-00";
// novaPessoaJuridica.Rendimento = 30000.99f;
// novaPessoaJuridica.Endereco = novoEndereco;

// //instanciar um objeto pessoa juridica para manipularmos os métodos
// PessoaJuridica metodosPj = new PessoaJuridica();

// // Impressão de valores
// Console.WriteLine(@$"
// Pessoa juridica
// Nome fantasia: {novaPessoaJuridica.Nome}
// Razão social: {novaPessoaJuridica.RazaoSocial}
// CNPJ: {novaPessoaJuridica.Cnpj}
// CNPJ válido: {(metodosPj.ValidarCnpj(novaPessoaJuridica.Cnpj) ? "Cnpj no formato válido!" : "Cnpj no formato invalido!")} 
// Rendimento: {novaPessoaJuridica.Rendimento}
// Endereço : {novaPessoaJuridica.Endereco.Logradouro}, {novaPessoaJuridica.Endereco.Numero}, {novaPessoaJuridica.Endereco.Complemento}, {novaPessoaJuridica.Endereco.Comercial}
// Imposto á pagar : {metodosPj.PagarImposto(novaPessoaJuridica.Rendimento).ToString("C", new CultureInfo("en-US"))}
// ");


// //Exemplo de expressão regular(Regex) para validar um formato de data
// string data = "26/09/2022";
// bool valido = Regex.IsMatch(data, @"^\d{2}/\d{2}/\d{4}$");
// Console.WriteLine(valido? "Dentro do padrão!" : "Fora do padrão, insira novamente uma data!");

// // Exemplo de Substring com dois argumentos
// // startIndex : da inde vamos partir
// // Length: quantos caracteres vamos obter
// string nome = "Lamborguini";
// string substring = nome.Substring(3, 5);
// Console.WriteLine(substring);
