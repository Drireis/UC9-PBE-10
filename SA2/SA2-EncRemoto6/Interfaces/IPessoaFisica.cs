using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SA2_EncRemoto2.Interfaces
{
    public interface IPessoaFisica
    {
        bool ValidarDataNascimento(DateTime datanascimento);

    }
    
}
        /// <summary>
        /// método para validar data de nascimento
        /// </summary>
        /// <param name="datanascimento">data de nascimento</param>
        /// <returns>verdadeiro ou falso</returns>