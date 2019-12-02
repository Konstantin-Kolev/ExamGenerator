using ExamGenerator.Data.Common.Repositories;
using ExamGenerator.Data.Models;
using ExamGenerator.Web.InputModels.QuestionType;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExamGenerator.Services.Data
{
    public class QuestionTypeService : IQuestionTypeService
    {
        private readonly IDeletableEntityRepository<QuestionType> repository;

        public QuestionTypeService(IDeletableEntityRepository<QuestionType> repository)
        {
            this.repository = repository;
        }

        public async Task Add(QuestionTypeInputModel model)
        {
            QuestionType questionType = model.To<QuestionType>();
            await repository.AddAsync(questionType);
            await repository.SaveChangesAsync();
        }
    }
}
