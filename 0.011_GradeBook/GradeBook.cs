using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._011_GradeBook
{
    class GradeBook
    {
        // everything inside of this is called members of this class 
        // class members define 1 state 2 behavior 
        public void AddGrade(float grade) 
        {
            // we can use grade as a variable inside the brckets 
            grades.Add(grade);
        }

        // have to tell the list the type of data its going to hold.
        List<float> grades = new List<float>(); // this is afield 
    }
}
