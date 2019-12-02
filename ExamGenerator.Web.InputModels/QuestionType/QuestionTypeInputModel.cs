using ExamGenerator.Services.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ExamGenerator.Web.InputModels.QuestionType
{
    public class QuestionTypeInputModel:IMapFrom<Data.Models.QuestionType>
    {
        [Required]
        public string Type { get; set; }
    }
}
