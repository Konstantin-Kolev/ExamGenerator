using ExamGenerator.Data.Common.Models;
using System.Collections.Generic;

namespace ExamGenerator.Data.Models
{
    public class Question : BaseDeletableModel<int>
    {
        public Question()
        {
            Answers = new HashSet<Answer>();
        }

        public string Content { get; set; }

        public Subject Subject { get; set; }
        public int SubjectId { get; set; }

        public int Score { get; set; }

        public int QuestionTypeId { get; set; }
        public QuestionType QuestionType { get; set; }

        public ICollection<Answer> Answers { get; set; }
    }
}
