using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis_02
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 1;
            //i = "S";

            char t = 'B';
            string t2 = "B";

            var x = 2;

            //x = "5";

            //string s = "Quintiliano";
            var s2 = "Quintiliano2";

            var d = 1.5;
            double d2 = 1.5;


            var bo = true;
            var bo2 = false;

            bool bol = true;
            bool bol2 = false;

            bool boolean = bool.Parse ("false");
            bool boolean2 = Convert.ToBoolean(d);


            Animal a = new Animal();
            Leao l = new Leao();




            Console.WriteLine(t);
            Console.WriteLine(t2);    
            

        }
    }
    public class Animal
    {

    }


    public class Leao : Animal {
        
    }
}
