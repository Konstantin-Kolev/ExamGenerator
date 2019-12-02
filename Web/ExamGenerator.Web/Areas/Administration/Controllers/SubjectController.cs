using ExamGenerator.Services.Data;
using ExamGenerator.Web.InputModels.Subject;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamGenerator.Web.Areas.Administration.Controllers
{
    public class SubjectController:AdministrationController
    {
        private readonly SubjectService subjectService;

        public SubjectController(SubjectService subjectService)
        {
            this.subjectService = subjectService;
        }

        public IActionResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create(SubjectInputModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }
            await subjectService.Add(model);
            return RedirectToAction("Index", "Home");
        }
    }
}
