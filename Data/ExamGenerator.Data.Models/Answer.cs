using ExamGenerator.Data.Common.Models;

namespace ExamGenerator.Data.Models
{
    public class Answer : BaseDeletableModel<int>
    {
        public string Content { get; set; }

        public bool IsCorrect { get; set; }

        public int QuestionId { get; set; }
        public Question Question { get; set; }
    }
}
