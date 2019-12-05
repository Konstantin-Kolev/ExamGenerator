using ExamGenerator.Web.InputModels.QuestionType;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExamGenerator.Services.Data
{
    public interface IQuestionTypeService
    {
        Task Add(QuestionTypeInputModel model);
    }
}
