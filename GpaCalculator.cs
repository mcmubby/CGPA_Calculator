using System.Collections.Generic;
using System;
namespace CGPA_Calculator
{
    public class GpaCalculator
    {
        public GpaCalculator(IEnumerable<Course> courseList)
        {
            GradePointAverage(courseList);
        }

        private void GradePointAverage(IEnumerable<Course> courseList)
        {
            double cummulativeGradePointObtained = 0;
            double totalNumberOfUnits = 0;
            Console.WriteLine($"\n{"Course Code",10} || {"Unit(s)",10} || {"Course Score",10} || {"Grade",5}");

            foreach (var course in courseList)
            {
               cummulativeGradePointObtained += (course.NumberOfUnits * (double)course.Grade);
               totalNumberOfUnits += course.NumberOfUnits;
               Console.WriteLine($"{course.CourseCode,10} {course.NumberOfUnits,10} {course.CourseScore,10} {course.Grade,15}");
            }

            Console.WriteLine($"Total Points Obtained : {cummulativeGradePointObtained} \nTotal Number of Units : {totalNumberOfUnits} \nGrade Point Average (GPA) : {cummulativeGradePointObtained/totalNumberOfUnits, 0:F2}\n");

        }
    }
}