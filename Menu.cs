using System;
using System.Collections.Generic;
using System.Text;

namespace CGPA_Calculator
{
   public class Menu
   {
        // a property/variable that represents the current stage the user is in.
        private int currentStage;
       
        
        /// <summary>
        /// this is the constructor.
        /// </summary>
        public Menu()
        {

        }
       
        public Menu(int initialStage)
        {
            this.currentStage = initialStage;
        }
        
        
        
        public static void PromptUser(string prompt)
        {
            Console.WriteLine(prompt);
        }

        public int getCurrentStage()
        {
            return this.currentStage;
        }

        public void setCurrentStage(int stage)
        {
            this.currentStage = stage;

        }

        public void PrintSemesterResult(IEnumerable<Course> courseList, double[] gpa)
        {
            PromptUser($"\n{"Course Code",10} || {"Unit(s)",10} || {"Course Score",10} || {"Grade",5}");

            foreach (var course in courseList)
            {
                PromptUser($"{course.CourseCode,10} {course.NumberOfUnits,10} {course.CourseScore,10} {course.Grade,15}");
            }

            Console.WriteLine($"\nTotal Points Obtained : {gpa[0]} \nTotal Number of Units : {gpa[1]} \nGrade Point Average (GPA) : {gpa[2], 0:F2}\n");
        }

   }
}
