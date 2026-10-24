using Microsoft.AspNetCore.Mvc;
using Lab_7.Models;

namespace Lab_7.Controllers
{
  public class FeedbackController : Controller
  {
    public static List<Feedback> feedbacks = new List<Feedback>();

    public ActionResult Index()
    {
      return View();
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Feedback feedback)
    {
      feedbacks.Add(feedback);
      return RedirectToAction("Create");
    }

    public ActionResult List()
    {
      return View(feedbacks);
    }
  }
}
