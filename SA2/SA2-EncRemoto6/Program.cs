using System.Globalization;
using System.Text.RegularExpressions;
// using instanciando a pasta onde estão as classes que vão ser usadas
using SA2_EncRemoto2.Classes;


// desenvolvendo menu
Console.WriteLine(@$"
================================================
|      Bem vindo ao sistema de cadastro        |
|      de Pessooas Fisicas e Juridicas         |
================================================
");

Utils.BarraCarregar("Iniciando", 1000, 5);

String? opcao;
do{
Console.WriteLine(@$"
================================================
|      Escolha uma da opções abaixo:
|-----------------------------------------------
|         1 - Pessoa Fisica                    |
|         2 - Pessoa Juridica                  |
|                                              |
|         0 - Sair                             |
================================================
");
Console.WriteLine($"Escolha uma opção:");

opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            PessoaFisica novaPessoaFisica = new PessoaFisica();
            novaPessoaFisica.Nome = "Adriano";
            novaPessoaFisica.Cpf = "12345678912";
            novaPessoaFisica.DataNascimento = new DateTime(2000, 10, 10);
            novaPessoaFisica.Rendimento = 1500.15f;

            PessoaFisica metodosPf = new PessoaFisica();
            //@ para quebra de linha antes do $ utilizando interpolação
            Console.WriteLine(@$"
Pessoa fisica
Nome: {novaPessoaFisica.Nome}
Data de nascimento: {novaPessoaFisica.DataNascimento}
Cpf: {novaPessoaFisica.Cpf}
Rendimento: {novaPessoaFisica.Rendimento}
Imposto á pagar: {metodosPf.PagarImposto(novaPessoaFisica.Rendimento).ToString("c", new CultureInfo("pt-BR"))}
Maior de idade - datetime: {metodosPf.ValidarDataNascimento(novaPessoaFisica.DataNascimento)}
Maior de idade - datetime: {(metodosPf.ValidarDataNascimento(novaPessoaFisica.DataNascimento) ? "Sim" : "Não")}
Maior de idade - string: {metodosPf.ValidarDataNascimento("01/05/1998")}
");
            Console.WriteLine($"Aperte ENTER para continuar");
            Console.ReadLine();
            break;
        case "2":
            PessoaJuridica novaPessoaJuridica = new PessoaJuridica();
            PessoaJuridica metodosPj = new PessoaJuridica();
            Endereco novoEndereco = new Endereco();
            novoEndereco.Logradouro = "Quadra";
            novoEndereco.Numero = 50;
            novoEndereco.Complemento = "Conjunto A";
            novoEndereco.Comercial = true;
            novaPessoaJuridica.Nome = "Curso Senai";
            novaPessoaJuridica.RazaoSocial = "Escola Senai de Programação";
            novaPessoaJuridica.Cnpj = "00.000.000/0001-00";
            novaPessoaJuridica.Rendimento = 30000.99f;
            novaPessoaJuridica.Endereco = novoEndereco;
            Console.WriteLine(@$"
Pessoa juridica
Nome fantasia: {novaPessoaJuridica.Nome}
Razão social: {novaPessoaJuridica.RazaoSocial}
CNPJ: {novaPessoaJuridica.Cnpj}
CNPJ válido: {(metodosPj.ValidarCnpj(novaPessoaJuridica.Cnpj) ? "Cnpj no formato válido!" : "Cnpj no formato invalido!")} 
Rendimento: {novaPessoaJuridica.Rendimento}
Endereço : {novaPessoaJuridica.Endereco.Logradouro}, {novaPessoaJuridica.Endereco.Numero}, {novaPessoaJuridica.Endereco.Complemento}, {novaPessoaJuridica.Endereco.Comercial}
Imposto á pagar : {metodosPj.PagarImposto(novaPessoaJuridica.Rendimento).ToString("C", new CultureInfo("en-US"))}
");
            Console.WriteLine($"Aperte ENTER para continuar");
            Console.ReadLine();    
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

Utils.BarraCarregar("Finalizando", 1000, 5);


// metodos
// Console.ForegroundColor = ConsoleColor.Black;
// Console.BackgroundColor = ConsoleColor.DarkCyan;
// Console.Write("Inicio do sistema");
// for (var cont = 0; cont < 5; cont++)
// {
//     Console.Write(".");
//     Thread.Sleep(1000);
    
// }
// Console.ResetColor();

// static void BarraCarregar(String texto, int tempo,int quantidade){
//     Console.BackgroundColor = ConsoleColor.DarkCyan;
//     Console.Write(texto);
    
//     for (var i = 0; i < quantidade; i++)
//     {
//         Console.Write(".");
//         Thread.Sleep(tempo);
//     }
// }
// Console.ResetColor();


































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
