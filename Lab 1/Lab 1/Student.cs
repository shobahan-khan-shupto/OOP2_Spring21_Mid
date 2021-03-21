using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Student
    {
        private string id;
        private string name;
        private double cgpa;
        private string dept;

        public string GetId()
        {
            return this.id;
        }

        public void SetId(string id)
        {
            this.id = id;
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public double GetCgpa()
        {
            return this.cgpa;
        }

        public void SetCgpa(double cgpa)
        {
            this.cgpa = cgpa;
        }

        public string GetDept()
        {
            return this.dept;
        }

        public void setDept()
        {
            this.dept = dept;
        }
        public Student(string id, string name, double cgpa, string dept)
        {
            this.id = id;
            this.name = name;
            this.cgpa = cgpa;
            this.dept = dept;
        }

        public void ShowStudentInfo()
        {
            Console.WriteLine("Student Info:");
            Console.WriteLine("Id: {0}", this.GetId());
            Console.WriteLine("Name: {0}", this.GetName());
            Console.WriteLine("CGPA: {0}", this.GetCgpa());
            Console.WriteLine("Blood Group: {0}\n", this.GetDept());
        }
    }
}