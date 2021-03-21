using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Course
    {
        private string courseName;
        private string courseCode;
        private int courseCredit;

        public string GetCourseName()
        {
            return this.courseName;
        }

        public void SetCourseName(string courseName)
        {
            this.courseName = courseName;
        }

        public string GetCourseCode()
        {
            return this.courseCode;
        }

        public void SetCourseCode(string courseCode)
        {
            this.courseCode = courseCode;
        }

        public double GetCourseCredit()
        {
            return this.courseCredit;
        }

        public void SetCourseCredit(int courseCredit)
        {
            this.courseCredit = courseCredit;
        }



        public Course(string courseName, string courseCreditCode, int courseCredit)
        {
            this.courseName = courseName;
            this.courseCode = courseCode;
            this.courseCredit = courseCredit;
        }

        public void ShowCourseInfo()
        {
            Console.WriteLine("Course Info:");
            Console.WriteLine("Course Name: {0}", this.GetCourseName());
            Console.WriteLine("Course Code: {0}", this.GetCourseCode());
            Console.WriteLine("Course Credit: {0}", this.GetCourseCredit());
        }
    }