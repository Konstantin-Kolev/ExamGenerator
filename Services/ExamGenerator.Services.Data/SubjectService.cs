using System.Threading.Tasks;
using ExamGenerator.Data.Common.Repositories;
using ExamGenerator.Data.Models;
using ExamGenerator.Services.Mapping;
using ExamGenerator.Web.InputModels.Subject;

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
    }
}
