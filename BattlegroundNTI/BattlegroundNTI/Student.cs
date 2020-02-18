using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattlegroundNTI
{
    class Student
    {
        //Atribut för alla studenter
        protected string name;
        protected int sve;
        protected int eng;
        protected int mat;

        //Metod för svenska ämnet
        public string Svenska()
        {
            //Skapar en array med betyg
            string[] grades = {"F", "E", "D", "C", "B", "A"};
            //returnerar betyget som motsvarar studentens kunskap.
            //(I det här fallet int sve)
            return (grades[sve]);
        }
    }
}
