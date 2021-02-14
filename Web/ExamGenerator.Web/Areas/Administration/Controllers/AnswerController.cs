using ExamGenerator.Services.Data;
using ExamGenerator.Web.InputModels.Answer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamGenerator.Web.Areas.Administration.Controllers
{
    public class AnswerController : AdministrationController
    {
        private readonly IAnswerService answerService;

        public AnswerController(IAnswerService answerService)
        {
            this.answerService = answerService;
        }

        public IActionResult Create() => View();

        public async Task<IActionResult> Create(AnswerInputModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await answerService.Add(model);
            return RedirectToAction("Index", "Home");
        }
    }
}
