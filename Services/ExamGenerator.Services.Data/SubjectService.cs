using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamGenerator.Data.Common.Repositories;
using ExamGenerator.Data.Models;
using ExamGenerator.Services.Mapping;
using ExamGenerator.Web.InputModels.Subject;
using ExamGenerator.Web.ViewModels.Subject;

namespace ExamGenerator.Services.Data
{
    public class SubjectService : ISubjectService
    {
        private readonly IDeletableEntityRepository<Subject> repository;

        public SubjectService(IDeletableEntityRepository<Subject> repository)
        {
            this.repository = repository;
        }

        public async Task Add(SubjectInputModel model)
        {
            Subject subject = model.To<Subject>();
            await repository.AddAsync(subject);
            await repository.SaveChangesAsync();
        }

        public async Task Update(SubjectEditModel model)
        {
            Subject subject = repository.All().Where(x => x.Id == model.Id).FirstOrDefault();
            subject.Name = model.Name;

            repository.Update(subject);
        }

        public TDestination GetById<TDestination>(int subjectId)
        {
            TDestination subject = repository.All().Where(x => x.Id == subjectId).To<TDestination>().FirstOrDefault();
            return subject;
        }
        public async Task<SubjectViewModel> Delete(int id)
        {
            Subject subject = repository.All().Where(x => x.Id == id).FirstOrDefault();
            repository.Delete(subject);
            return subject.To<SubjectViewModel>();
        }

        public async Task<List<SubjectViewModel>> GetAllSubjects()
        {
            List<SubjectViewModel> subjects = new List<SubjectViewModel>();
            foreach (var subject in repository.All())
            {
                subjects.Add(subject.To<SubjectViewModel>());
            }
            return subjects;
        }
    }
}
