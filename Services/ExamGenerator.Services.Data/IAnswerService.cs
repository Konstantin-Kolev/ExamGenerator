using ExamGenerator.Web.InputModels.Answer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExamGenerator.Services.Data
{
    public interface IAnswerService
    {
        public Task Add(AnswerInputModel model);
    }
}
