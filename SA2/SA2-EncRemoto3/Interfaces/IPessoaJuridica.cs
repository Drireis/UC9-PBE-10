using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SA2_EncRemoto2.Interfaces
{
    public interface IPessoaJuridica
    {
        bool ValidarCnpj(string cnpf);
    }
}
        /// <summary>
        /// método para validar cnpj
        /// </summary>
        /// <param name="cnpj">cnpj da pessoa juridica</param>
        /// <returns>verdadeiro ou falso</returns>