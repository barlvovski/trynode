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

        public string getCourseStr()
        {
            return (course.ToString() + " " + gradevalue.ToString()) ;
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
            Random myRandom = new Random();
            int courses = myRandom.Next(4, 6);
            Node<grade> currg = null;
            Node<grade> nextg = null;
            for (int i = 0; i < courses; i++)
            {
          
                grade g = new grade(myRandom.Next(10,20), myRandom.Next(60,100 ));
                nextg = new Node<grade>(g, null);
                            
               
               if (currg != null)    
                currg.SetNext(nextg);
                    
               
                currg = nextg;
                if (i == 0)
                {

                    grades = currg;
                }


            }
            
        }
        public string getName()
        {
            return name;
        }

        public void printGrades()
        {
            Node<grade> gd = this.grades; 
            while (gd != null)
            {
                                
                grade gd1 = gd.GetValue();
                Console.WriteLine(gd1.getCourseStr());
                gd = gd.GetNext();
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            const int MAXST = 19;
            
            student [] st;
            st = new student[MAXST];
            for (int i = 0; i < MAXST; i++)
            {
                st[i] = new student(2004, 3090 + i, "name" + i.ToString());
            }

            for (int i = 0; i < MAXST; i++)
            {
                
                Console.WriteLine("=================");
                Console.WriteLine(st[i].getName());
                st[i].printGrades();
            }
        }


    }
}
