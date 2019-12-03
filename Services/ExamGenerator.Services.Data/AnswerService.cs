using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ExamGenerator.Data.Common.Repositories;
using ExamGenerator.Data.Models;
using ExamGenerator.Services.Mapping;
using ExamGenerator.Web.InputModels.Answer;

namespace ExamGenerator.Services.Data
{
    public class AnswerService : IAnswerService
    {
        private readonly IDeletableEntityRepository<Answer> repository;

        public AnswerService(IDeletableEntityRepository<Answer> repository)
        {
            this.repository = repository;
        }

        public async Task Add(AnswerInputModel model)
        {
            Answer answer = model.To<Answer>();
            await repository.AddAsync(answer);
            await repository.SaveChangesAsync();
        }
    }
}
