namespace SA2_EncRemoto2.Classes
{
    // : apos classe PessoaJuridica indica herança de Pessoa para PessoaJuridica
    public class PessoaJuridica: Pessoa
    {
        public string? RazaoSocial {get; set;}
        public string? Cnpj {get; set;}

    }
}