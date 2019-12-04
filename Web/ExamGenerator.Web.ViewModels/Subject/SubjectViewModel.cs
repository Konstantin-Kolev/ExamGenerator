using ExamGenerator.Services.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamGenerator.Web.ViewModels.Subject
{
    public class SubjectViewModel : IMapFrom<Data.Models.Subject>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
