using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SA2_EncRemoto2.Interfaces
{
    public interface IPessoa
    {
        float PagarImposto (float rendimento);
    }
}
    // <summary>
    // método para calcular imposto
    // </summary>
    // <param name="rendimento">rendimento para basear o calculo de imposto</param>
    // <returns>valor do imposto a ser pago</returns>
    //atributo : letra inicial maiuscula
    //classe : letras iniciais maiusculas
    //interfaces: primeira letra I + nome da classe com letra maiuscula ex: IPessoa
    //metodo: iniciais maiusculas e parâmetros(argumentos) em letras minusculas