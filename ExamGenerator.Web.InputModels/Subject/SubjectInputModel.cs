using ExamGenerator.Data.Models;
using ExamGenerator.Services.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ExamGenerator.Web.InputModels.Subject
{
    public class SubjectInputModel : IMapFrom<Data.Models.Subject>
    {
        [Required]
        public string Name { get; set; }
    }
}
