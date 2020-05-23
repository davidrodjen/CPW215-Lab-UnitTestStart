using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class Course
    {
        private string courseName;
        private int maxCredits = 30;
        private byte numberOfCredits;

        public Course(string courseName)
        {
            CourseName = courseName;
            InstructorName = "STAFF";
        }

        /// <summary>
        /// The instructor teaching the course
        /// </summary>
        public string InstructorName { 
            
            get => InstructorName;
            set => InstructorName = value;
        }

        /// <summary>
        /// The name of the course
        /// </summary>
        public string CourseName
        {
            get => courseName;
            set
            {
                if (value is null)
                    throw new ArgumentNullException("CourseName is null");

                courseName = value;
            }
        }

        /// <summary>
        /// Number of credits for the course
        /// </summary>
        public byte NumberOfCredits 
        {
            get => numberOfCredits;
            set
            {
                if (value == maxCredits || value > maxCredits)
                    throw new ArgumentException("Credits over maximum value");
                if (value == 0)
                    throw new ArgumentException("Credits are of zero value");

                numberOfCredits = value;
            }
        }
    }
}
