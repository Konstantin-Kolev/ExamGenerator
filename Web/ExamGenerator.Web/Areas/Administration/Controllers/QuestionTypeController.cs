using ExamGenerator.Services.Data;
using ExamGenerator.Web.InputModels.QuestionType;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamGenerator.Web.Areas.Administration.Controllers
{
    public class QuestionTypeController : AdministrationController
    {
        private readonly IQuestionTypeService questionTypeService;

        public QuestionTypeController(IQuestionTypeService questionTypeService)
        {
            this.questionTypeService = questionTypeService;
        }

        public IActionResult Create() => View();

        public async Task<IActionResult> Create(QuestionTypeInputModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await questionTypeService.Add(model);
            return RedirectToAction("Index", "Home");
        }
    }
}
