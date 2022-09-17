using SA2_EncRemoto2.Interfaces;
namespace SA2_EncRemoto2.Classes
{
    // Superclasse pessoa, classe abstrata
    public abstract class Pessoa : IPessoa
    {
        // Atributos da classe pessoa.
        public string? Nome {get; set;}
        //instanciando da classe endereço
        public Endereco? Endereco {get; set;}
        public float Rendimento {get; set;}
        public abstract float PagarImposto(float rendimento);
    }
}
    // metodos acessores
    // get: leitura e set:editar por padrão esses metodos vem como public
 