using ExamGenerator.Web.InputModels.Subject;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExamGenerator.Services.Data
{
    public interface ISubjectService
    {
        public Task Add(SubjectInputModel model);
    }
}
