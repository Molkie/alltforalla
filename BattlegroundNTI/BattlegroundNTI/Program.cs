using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattlegroundNTI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skapar en instans av klassen TeStudent.
            TeStudent student1 = new TeStudent();
            //Kallar metoden Svenska i student1 och skriver ut svaret.
            Console.WriteLine(student1.Svenska());
            Console.ReadLine();
        }
    }
}
