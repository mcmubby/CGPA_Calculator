using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CGPA_Calculator
{
    /// <summary>
    /// An mock of singleton design pattern
    /// </summary>
    public class Db
    {
        private List<Course> CourseTable;

        private Db()
        {
            this.CourseTable = new List<Course>();
        }

        public static Db Initialize()
        {
            return new Db();
        }

        public void AddCourse(Course c)
        {
            this.CourseTable.Add(c);
        }

        
        public void RemoveCourse(string courseCode)
        {
            Course c = this.CourseTable.FirstOrDefault(c => c.CourseCode.ToLower() == courseCode.ToLower());
            this.CourseTable.Remove(c);
        }


        public IEnumerable<Course> getAllCourses()
        {
            return this.CourseTable;
        }

        //getAllBySemesterId
    }
}
