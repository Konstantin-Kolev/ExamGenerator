using ExamGenerator.Data.Common.Models;
using System.Collections.Generic;

namespace ExamGenerator.Data.Models
{
    public class QuestionType : BaseDeletableModel<int>
    {
        public QuestionType()
        {
            Questions = new HashSet<Question>();
        }

        public string Type { get; set; }

        public Subject Subject { get; set; }
        public int SubjectId { get; set; }

        public ICollection<Question> Questions { get; set; }
    }
}
