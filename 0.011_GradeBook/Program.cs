using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._011_GradeBook
{  

    // class decoration is similar to a cookie cuttter.. can create objects of certian shapes.. and then work with thoes objecsts.. instead of dough its objecst a class will stamp out objects from the memory of the computer. 
        // creating the class alone dosent create anything of use to us. we need to say new..  
        // Gradebook book = new Gradebook(); <---- this is where we are building the actual book 
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);


        }
    }
}
