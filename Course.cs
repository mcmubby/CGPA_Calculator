using System.Globalization;
using System;
using System.Collections.Generic;
using System.Text;

namespace CGPA_Calculator
{
    public class Course
    {
        public string CourseCode {  get; private set; }
        public double CourseScore { get; private set; }
        public int NumberOfUnits { get; private set; }
        public GradePointValue Grade { get; private set; }
        public int GradePoint { get; private set; }
        public double GradePointAverage { get; private set; }

        public Course(string code , double score , int numberOfUnits)
        {
            this.CourseCode = code;
            this.CourseScore = score;
            this.NumberOfUnits = numberOfUnits;
            AssignGrade(this.CourseScore);
            this.GradePoint = (int)this.Grade * this.NumberOfUnits;
            this.GradePointAverage = ((this.GradePoint) / (this.NumberOfUnits * (int)GradePointValue.A)) * 5;
        }

        private GradePointValue AssignGrade(double score)
        {
           if (score > 70)
           {
               this.Grade = GradePointValue.A;
           }
           else if (score < 70 && score > 59)
           {
               this.Grade = GradePointValue.B;
           }
           else if (score < 60 && score > 49)
           {
               this.Grade = GradePointValue.C;
           }
           else if (score < 50 && score > 44)
           {
               this.Grade = GradePointValue.D;
           }
           else if (score < 45 && score > 39)
           {
               this.Grade = GradePointValue.E;
           }
           else
           {
               this.Grade = GradePointValue.F;
           }

           return this.Grade;
        }
    }
}
