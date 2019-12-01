using ExamGenerator.Data.Common.Models;
using System.Collections.Generic;

namespace ExamGenerator.Data.Models
{
    public class Subject : BaseDeletableModel<int>
    {
        public Subject()
        {
            QuestionTypes = new HashSet<QuestionType>();
        }

        public string Name { get; set; }

        public ICollection<QuestionType> QuestionTypes { get; set; }
    }
}
