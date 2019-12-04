using ExamGenerator.Services.Mapping;
using System.ComponentModel.DataAnnotations;

namespace ExamGenerator.Web.InputModels.Subject
{
    public class SubjectInputModel : IMapTo<Data.Models.Subject>
    {
        [Required]
        public string Name { get; set; }
    }
}
