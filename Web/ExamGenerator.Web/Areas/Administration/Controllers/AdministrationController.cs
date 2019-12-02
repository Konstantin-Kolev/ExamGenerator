using ExamGenerator.Common;
using ExamGenerator.Web.Controllers;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ExamGenerator.Web.Areas.Administration.Controllers
{
    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area(GlobalConstants.AdministrationArea)]
    public class AdministrationController : BaseController
    {
    }
}
