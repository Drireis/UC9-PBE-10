using System.Globalization;
// using instanciando a pasta onde estão as classes que vão ser usadas
using SA2_EncRemoto2.Classes;
// criando objeto 
//Tipo NomeDoObjeto = MetodoConstrutor();

// instaciando objeto do tipo pessoa fisica
PessoaFisica novaPessoaFisica = new PessoaFisica();

//atribuimos um valor as propriedades
novaPessoaFisica.Nome = "Adriano";
novaPessoaFisica.Cpf = "12345678912";
novaPessoaFisica.DataNascimento = new DateTime(2000, 10, 10);
novaPessoaFisica.Rendimento = 1500.15f;

//imiprimindo os valores do objeto
Console.WriteLine("Nome: " + novaPessoaFisica.Nome);
Console.WriteLine("CPF: " + novaPessoaFisica.Cpf);
Console.WriteLine("Data de nascimento:" + novaPessoaFisica.DataNascimento);
Console.WriteLine("Rendimento: " + novaPessoaFisica.Rendimento);

// interpolação iniciada com $ e atributo entre colchetes
Console.WriteLine($"Nome: {novaPessoaFisica.Nome}");
Console.WriteLine($"Nome: {novaPessoaFisica.Cpf}");
Console.WriteLine($"Nome: {novaPessoaFisica.DataNascimento}");
Console.WriteLine($"Nome: {novaPessoaFisica.Rendimento}");

//@ para quebra de linha antes do $ utilizando interpolação
Console.WriteLine(@$"
Pessoa fisica
Nome: {novaPessoaFisica.Nome}
Cpf: {novaPessoaFisica.Cpf}
Data de Nascimento: {novaPessoaFisica.DataNascimento}
Rendimento: {novaPessoaFisica.Rendimento}");

//instanciar PessoaJuridica
PessoaJuridica novaPessoaJuridica = new PessoaJuridica();

//instanciamos um objeto do tipo endereço,atribuimos valores para os atributos
Endereco novoEndereco = new Endereco();
novoEndereco.Logradouro = "Quadra";
novoEndereco.Numero = 50;
novoEndereco.Complemento = "Conjunto A";
novoEndereco.Comercial = true;

//atribuimos valores para os atributos do objeto pessoa juridica
novaPessoaJuridica.Nome = "Curso Senai";
novaPessoaJuridica.RazaoSocial = "Escola Senai de Programação";
novaPessoaJuridica.Cnpj = "123456789321654";
novaPessoaJuridica.Rendimento = 30000.99f;
novaPessoaJuridica.Endereco = novoEndereco;

//instanciar um objeto pessoa juridica para manipularmos os métodos
PessoaJuridica metodosPj = new PessoaJuridica();

// Impressão de valores
Console.WriteLine(@$"
Pessoa juridica
Nome fantasia: {novaPessoaJuridica.Nome}
Razão social: {novaPessoaJuridica.RazaoSocial}
CNPJ: {novaPessoaJuridica.Cnpj}
Rendimento: {novaPessoaJuridica.Rendimento}
Endereço : {novaPessoaJuridica.Endereco.Logradouro}, {novaPessoaJuridica.Endereco.Numero}, {novaPessoaJuridica.Endereco.Complemento}, {novaPessoaJuridica.Endereco.Comercial}
Imposto á pagar : {metodosPj.PagarImposto(novaPessoaJuridica.Rendimento).ToString("C", new CultureInfo("en-US"))}
");

