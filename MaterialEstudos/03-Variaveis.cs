using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialEstudos
{
    internal class Variaveis
    {
        // Variaveis são nomes sibolicos para valores. Elas são uma parte importante de programação.
        // A variavel é escrita no formato <Tipo nomeDaVariavel = valor> como nos exemplos abaixo
        int umNumero = 1;
        char umCaracter = 'A';
        float umNumeroDecimal = 1000.05f;

        // uma maneira simplificada de escrever variaveis é utilizando a palavra chave var
        // isso cria uma variavel dinamica, que pode variar o seu Tipo, mas ela precisa ser 
        // declarada com um valor e dentre de um escopo/contexto.
        void TesteDeVar()
        {
            var testeNumero = 1;
            var umCaracter = 'A';
            var umNumeroDecimal = 1000.05f;
        }
    }
}
