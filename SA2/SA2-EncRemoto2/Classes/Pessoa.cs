namespace SA2_EncRemoto2.Classes
{
    // Superclasse pessoa, classe abstrata
    public abstract class Pessoa
    {
        // Atributos da classe pessoa.
        public string? Nome {get; set;}
        public string? Endereco {get; set;}
        public float Rendimento {get; set;}
    }
}
    // metodos acessores
    // get: leitura e set:editar por padrão esses metodos vem como public