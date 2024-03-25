using ChallengeSubmission.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChallengeSubmission.Controllers
{
    public class CurrentTimeController : Controller
    {
        public IActionResult Index()
        {
            CurrentTimeModel v = new CurrentTimeModel();
            v.CurrentDateTime = DateTime.Now;
            return View(v);
        }
    }
}
