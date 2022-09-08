namespace SA2_EncRemoto2.Classes
{
    // : apos classe PessoaFisica indica herança de Pessoa para PessoaFisica
    public class PessoaFisica : Pessoa
    {
        public string? Cpf { get; set; }
        public DateTime DataNascimento { get; set; }

    }
}