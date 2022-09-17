using SA2_EncRemoto2.Interfaces;
namespace SA2_EncRemoto2.Classes
{
    // : apos classe PessoaJuridica indica herança de Pessoa para PessoaJuridica
    public class PessoaJuridica: Pessoa, IPessoaJuridica
    {
        public string? RazaoSocial {get; set;}
        public string? Cnpj {get; set;}
        public override float PagarImposto(float rendimento){
            if(rendimento <= 3000){
                return rendimento * 0.03f;
            }
            else if(rendimento >= 3001 && rendimento <= 6000){
                return rendimento * 0.05f;
            }
            else if(rendimento >= 6001 && rendimento >= 10000){
                return rendimento * 0.07f;
            }
            else{
                return rendimento * 0.09f;
            } 
        }
        public bool ValidarCnpj(string cnpj){
            throw new NotImplementedException();
        }
        
    }
}
//-Pessoa juridica
//		rendimentos até 3000, 3%
//		rendimentos entre 3001 e 6000, 5%
//		rendimentos entre 6001 e 10000, 7%
//		rendimentos acima de 10000, 9%