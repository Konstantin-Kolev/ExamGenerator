using ExamGenerator.Web.InputModels.Subject;
using ExamGenerator.Web.ViewModels.Subject;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExamGenerator.Services.Data
{
    public interface ISubjectService
    {
        Task Add(SubjectInputModel model);

        TDestination GetById<TDestination>(int subjectId);

        Task Update(SubjectEditModel model);

        Task Delete(int id);

        Task<List<SubjectViewModel>> GetAll();
    }
}
