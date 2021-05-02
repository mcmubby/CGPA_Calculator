using System;
using System.Net.Mail;
namespace CGPA_Calculator
{
    public class CgpaCalculator
    {
        public CgpaCalculator(Db db)
        {
            CummulativeGradePointAverage(db);
        }

        private void CummulativeGradePointAverage(Db db)
        {
            var courseList = db.getAllCourses();
            double cummulativeGradePointObtained = 0;
            double cummulativeGradePointObtainable = 0;
            double count = 0;
            double cummulativeGradePointAverage = 0;
            Console.WriteLine($"\n{"Course Code",10} || {"Course Score",10} || {"Grade",10} || {"GPA",10}");

            foreach (var course in courseList)
            {
               cummulativeGradePointAverage += course.GradePointAverage;
               cummulativeGradePointObtained += course.GradePoint;
               cummulativeGradePointObtainable += (course.NumberOfUnits * (double)GradePointValue.A);
               Console.WriteLine($"{course.CourseCode,10} {course.CourseScore,10} {course.Grade,10} {course.GradePointAverage,10}");
               count++;
            }

            Console.WriteLine($"Total Obtainable Points : {cummulativeGradePointObtainable} \nTotal Points Obtained : {cummulativeGradePointObtained} \nCummulative Grade Point Average (CGPA) : {cummulativeGradePointAverage/count, 0:F2}\n");

        }
    }
}