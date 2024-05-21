using System; // 'using' permite acessar facilmente outros recursos de diferentes pacotes ou bibliotecas.

namespace SeuNameSpace // Os Namespaces auxiliam a organização do codigo e evitam conflitos entre multiplos nomes iguais.
{
    public class ClasseBasica // uma Classe define um modelo para objetos, como uma abstração
    {
        public void MetodoBasico() // Um Método não retorna valor algum, apenas executa comandos.
        {
            Console.WriteLine("Hello, World!"); // Displays text in the console.
        }

        public int FuncaoBasica() // Uma função pode ou não realizar multiplas operações,
                           // mas sempre retorna valores ao fim de sua execução.
        {
            return 0;
        }
    }
}