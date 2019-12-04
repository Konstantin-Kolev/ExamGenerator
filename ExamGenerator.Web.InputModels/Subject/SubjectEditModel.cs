using ExamGenerator.Services.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ExamGenerator.Web.InputModels.Subject
{
    public class SubjectEditModel : IMapTo<Data.Models.Subject>, IMapFrom<Data.Models.Subject>
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
