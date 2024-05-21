using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialEstudos
{
    public class TipoDeDados
    {
        // Tipos de Dados:
        // Toda Variavel ou Constante em C# tem um Tipo, determinando os valores que ela pode armazenar e as operações que pode realizar.
        
        // Tipo Valor:
        // São variaveis que armazenam dados diretamente. Uma vez que recebem um valor, vão mante-lo até que seja alterado
        int umNumero = 1;
        char umCaracter = 'A';
        float umNumeroDecimal = 1000.05f;

        // Tipo Refencia:
        // Armazena um endereço de memória, apontando para o valor armazenado.
        string umTexto = "Loren Ipsum";
        class classeTeste {int testeNumero = 1; char testeCaracter = 'A'; float testeNumeroDecimal = 1000.05f; }
        int[] umArray = { 1, 2, 3, 4, 5, 6, };

    }
}
