using ExamGenerator.Services.Data;
using ExamGenerator.Web.InputModels.Subject;
using ExamGenerator.Web.ViewModels.Subject;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ExamGenerator.Web.Areas.Administration.Controllers
{
    public class SubjectController:AdministrationController
    {
        private readonly ISubjectService subjectService;

        public SubjectController(ISubjectService subjectService)
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
        public IActionResult Edit(int id)
        {
            SubjectEditModel subject = subjectService.GetById<SubjectEditModel>(id);
            return View(subject);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(SubjectEditModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await subjectService.Update(model);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Delete(int id)
        {
            SubjectViewModel subject = subjectService.GetById<SubjectViewModel>(id);
            return View(subject);
        }

        [HttpPost]
        [ActionName(nameof(Delete))]
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            await subjectService.Delete(id);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> GetAllSubjects()
        {
            await subjectService.GetAllSubjects();
            return RedirectToAction("Index", "Home");
        }
    }
}
