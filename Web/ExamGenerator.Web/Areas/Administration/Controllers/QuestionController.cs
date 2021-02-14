using ExamGenerator.Services.Data;
using ExamGenerator.Web.InputModels.Question;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamGenerator.Web.Areas.Administration.Controllers
{
    public class QuestionController : AdministrationController
    {
        private readonly IQuestionService questionService;

        public QuestionController(IQuestionService questionService)
        {
            this.questionService = questionService;
        }

        public IActionResult Create() => View();

        public async Task<IActionResult> Create(QuestionInputModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await questionService.Add(model);
            return RedirectToAction("Index", "Home");
        }
    }
}
