// using instanciando a pasta onde estão as classes que vão ser usadas
using SA2_EncRemoto2.Interfaces;
namespace SA2_EncRemoto2.Classes
{
    // apos " : " classe PessoaFisica indica herança de Pessoa para PessoaFisica
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string? Cpf {get; set;}
        public DateTime DataNascimento {get; set;}
        public override float PagarImposto(float rendimento)
        {
            if(rendimento <= 1500){            
                return 0;
            }
            else if(rendimento >= 1501 && rendimento <= 3500){
                return rendimento * 0.02f;
            }
            else if(rendimento >= 3501 && rendimento <=6000){
                return rendimento * 0.035f;
            }       
            else {
                 return rendimento * 0.05f;
            }    
        }
        public bool ValidarDataNascimento(DateTime datanascimento){
            
            DateTime dataAtual = DateTime.Today;

            double anos = (dataAtual - datanascimento).TotalDays / 365;
            if (anos >= 18) {
                return true;
            }
            return false;
        }
        public bool ValidarDataNascimento(string dataNascimento){
            DateTime dataConvertida;

            if(DateTime.TryParse(dataNascimento, out dataConvertida)){
                DateTime dataAtual = DateTime.Today;

                double anos = (dataAtual - dataConvertida).TotalDays / 365;

                if (anos >= 18){
                    return true;
                }
                return false;
            }
            return false;
        }
    }
}
//-Pessoa física
//		rendimentos até 1500, isento
//		rendimentos entre 1501 e 3500, 2%
//		rendimentos entre 3501 e 6000, 3.5%
//		rendimentos acima de 6000, 5%
//
