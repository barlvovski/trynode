using System;
using System.Collections.Generic;

namespace trynode
{

    class grade
    {
        int course;
        int gradevalue;

        public grade(int mycourse , int mygradevalue)
        {
            course = mycourse;
            gradevalue = mygradevalue;

        }

    }

    class student
    {
        int shnatl;
        int tz;
        string name;
        Node<grade> grades;

        public student(int myshnat , int mytz , string myname)
        {
            
            shnatl = myshnat;
            tz = mytz;
            name = myname;
            //
            grade g = new grade(10, 15);
            grades  = new Node<grade>(g,null);
            

        }

    }

    class Program
    {



        static void Main(string[] args)
        {
            Node<int> pos;
            


        }

    }
}
