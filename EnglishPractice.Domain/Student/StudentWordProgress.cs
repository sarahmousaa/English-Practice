using EnglishPractice.Domain.WordJourney.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishPractice.Domain.Student
{
    //“This particular student is learning this particular curriculum target.”

    public class StudentWordProgress
    {
        public Student Student { get; private set; }

        public WordLearningTarget LearningTarget { get; private set; }

        public StudentWordProgress(
            Student student,
            WordLearningTarget learningTarget)
        {
            if (student is null)
            {
                throw new ArgumentNullException(nameof(student));
            }

            if (learningTarget is null)
            {
                throw new ArgumentNullException(nameof(learningTarget));
            }

            Student = student;
            LearningTarget = learningTarget;
        }
    }
}
