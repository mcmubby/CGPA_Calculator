using System.Collections.Generic;
namespace CGPA_Calculator
{
    public class GpaCalculator
    {

        public static double[] GradePointAverage(IEnumerable<Course> courseList)
        {
            double cummulativeGradePointObtained = 0;
            double totalNumberOfUnits = 0;

            foreach (var course in courseList)
            {
               cummulativeGradePointObtained += (course.NumberOfUnits * (double)course.Grade);
               totalNumberOfUnits += course.NumberOfUnits;
            }

            double gpa = cummulativeGradePointObtained / totalNumberOfUnits;

            double[] result = {cummulativeGradePointObtained, totalNumberOfUnits, gpa}; //Array might not be the best choice
            return result;
        }
    }
}