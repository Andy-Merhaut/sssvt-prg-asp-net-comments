using CommentsSection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CommentsSection.Models.Comments;

namespace CommentsSection.Controllers
{
    public class HomeController : Controller
    {
        private CommentRepository _repository = new CommentRepository();
        
        public IActionResult Index()
        {
            this.ViewBag.Comments = this._repository.SelectComments();
            this.ViewBag.SubComments = this._repository.SelectSubComments();
            return View();
        }

        [HttpGet]
        public IActionResult Create(int parent)
        {
            this.ViewBag.Parent = parent;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Comment comment)
        {
            comment.Date = DateTime.Now;

            if (this.ModelState.IsValid)
            {
                this._repository.Insert(comment);
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
