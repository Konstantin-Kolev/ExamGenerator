using ExamGenerator.Services.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ExamGenerator.Web.InputModels.Question
{
    public class QuestionInputModel : IMapTo<Data.Models.Question>
    {
        [Required]
        public string Content { get; set; }

        [Required]
        public int Score { get; set; }

        [Required]
        public int QuestionTypeId { get; set; }

        [Required]
        public ICollection<Data.Models.Answer> Answers { get; set; }
    }
}
