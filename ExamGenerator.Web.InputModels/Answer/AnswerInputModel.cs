using ExamGenerator.Services.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ExamGenerator.Web.InputModels.Answer
{
    public class AnswerInputModel : IMapTo<Data.Models.Answer>
    {
        [Required]
        public string Content { get; set; }

        [Required]
        public bool IsCorrect { get; set; }
    }
}
