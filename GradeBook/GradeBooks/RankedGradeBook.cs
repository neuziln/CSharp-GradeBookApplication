using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
   public class RankedGradeBook: BaseGradeBook 
   {
        public RankedGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (base.Students.Count < 5)
                throw new InvalidOperationException();
            if (averageGrade >= .8)
                return 'A';
            else if (averageGrade >= .6 && averageGrade < .8)
                return 'B';
            else if (averageGrade >= .4 && averageGrade < .6)
                return 'C';
            else if (averageGrade >= .2 && averageGrade < .4)
                return 'D';
            return 'F';
        }
    }
}
