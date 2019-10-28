using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Operadores_logicos03
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;


            /*  
             //IF and Else
            if (a == 1)
            {
                Console.WriteLine("entrou na condição do if");             
            }
            else if (a == 2)
            {
                Console.WriteLine("Caiu no bloco do senão se a = 2");
            }
            else
            {
                Console.WriteLine("Caiu no bloco do else");
            }

            
            //switch
            switch (a)
            {
                case 1:
                    Console.WriteLine("Caso 1");
                    break;
                case 2:
                    Console.WriteLine("Caso 2");
                    break;
                case 3:
                    Console.WriteLine("Caso Padrão");
                    break;
            }
            */
            //Isso em ternário depois

            // Cod anterior em ternário
            // Então pode ser representado por ? e o senão pode ser representado por :
           
            string teste = (a == 1 ? "O valor de a" : "mais um");
            Console.WriteLine("Olá pessoal" + teste);

            //Console.Read ele mantem a execução do códico onde foi apresentado o texto e não continua a execução
            Console.Read();
             
        }
    }
}
