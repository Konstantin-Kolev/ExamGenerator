using ExamGenerator.Web.InputModels.Question;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExamGenerator.Services.Data
{
    public interface IQuestionService
    {
        public Task Add(QuestionInputModel model);
    }
}
