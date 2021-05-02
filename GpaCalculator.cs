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
            double cummulativeGradePointAverage = 0;

            foreach (var course in courseList)
            {
               cummulativeGradePointAverage += course.GradePointAverage;
               cummulativeGradePointObtained += course.GradePoint;
               cummulativeGradePointObtainable += (course.NumberOfUnits * (int)GradePointValue.A);
            }

            
        }
    }
}