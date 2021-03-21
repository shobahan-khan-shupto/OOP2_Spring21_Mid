using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Program
    {
        static void Main(string[] args)
        {
            Depertment de1 = new Depertment("Computer science", "CS");
            Depertment de2 = new Depertment("Electrical Eng.", "EEE");
            Student s1 = new Student("Shupto khan", "1733511", 3.10f);
            Student s2 = new Student("Hridoy Ahmed", "1614382", 3.05f);
            s1.Depertment = de1;
            s2.Depertment = de2;
            s1.show();
            s2.show();


        }
    }
}