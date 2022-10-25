using System.Text.RegularExpressions;
using SA2_EncRemoto2.Interfaces;
namespace SA2_EncRemoto2.Classes
{
    // : apos classe PessoaJuridica indica herança de Pessoa para PessoaJuridica
    public class PessoaJuridica: Pessoa, IPessoaJuridica
    {
        public string? RazaoSocial {get; set;}
        public string? Cnpj {get; set;}
        public string Caminho {get; private set;} = "Database/PessoaJuridica.csv";
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
        // 00.000.000/0001-00 : 18 caracteres
        // 00000000000100 : 14 caracteres
        public bool ValidarCnpj(string cnpj)
        {
            if(Regex.IsMatch(cnpj, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)"))
            {
                if(cnpj.Length == 18)
                {
                    if(cnpj.Substring(11, 4) == "0001")
                    {
                        return true;
                    }
                }
                else if(cnpj.Length == 14) 
                {        
                    if(cnpj.Substring(8, 4) == "0001") 
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public void Inserir(PessoaJuridica pj)
        {
            Utils.VerificarPastaArquivo(Caminho);
            string[] pjStrings = {$"{pj.Nome},{pj.Cnpj},{pj.RazaoSocial},{pj.Endereco},{pj.Rendimento}"};
            File.AppendAllLines(Caminho, pjStrings);
        }
        public List<PessoaJuridica> LerArquivo()
        {
            //criado uma lista para armazenar os itens lidos no csv
            List<PessoaJuridica> listaPj = new List<PessoaJuridica>();

            //criado um array de strings onde será armazenados os itens dentro do csv
            string[] linhas = File.ReadAllLines(Caminho);

            //criado um foreach para leitura de cada item do array "linhas"
            foreach (string cadaLinha in linhas)
            {
                //array para armazenar os atributos do objeto, ou seja, vamos pegar o padrão e separar onde tem uma vírgula
                string[] atributos = cadaLinha.Split(",");

                //criamos um objeto para atribuir os valores lidos nele
                PessoaJuridica cadaPj = new PessoaJuridica();

                cadaPj.Nome = atributos[0];
                cadaPj.Cnpj = atributos[1];
                cadaPj.RazaoSocial = atributos[2];

                listaPj.Add(cadaPj);
            }
            return listaPj;
        }
        
    }
}
//-Pessoa juridica
//		rendimentos até 3000, 3%
//		rendimentos entre 3001 e 6000, 5%
//		rendimentos entre 6001 e 10000, 7%
//		rendimentos acima de 10000, 9%