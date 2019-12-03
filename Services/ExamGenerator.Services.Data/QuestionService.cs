using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ExamGenerator.Data.Common.Repositories;
using ExamGenerator.Data.Models;
using ExamGenerator.Services.Mapping;
using ExamGenerator.Web.InputModels.Question;

namespace ExamGenerator.Services.Data
{
    public class QuestionService : IQuestionService
    {
        private readonly IDeletableEntityRepository<Question> repository;

        public QuestionService(IDeletableEntityRepository<Question> repository)
        {
            this.repository = repository;
        }

        public async Task Add(QuestionInputModel model)
        {
            Question question = model.To<Question>();
            await repository.AddAsync(question);
            await repository.SaveChangesAsync();
        }
    }
}
