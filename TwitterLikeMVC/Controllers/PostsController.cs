using Microsoft.AspNetCore.Mvc;
using TwitterLikeMVC.Services;
using TwitterLikeMVC.Models;
using Microsoft.AspNetCore.Authorization;

namespace TwitterLikeMVC.Controllers
{
    public class PostsController : Controller
    {
		private readonly PostsService _postService;

		public PostsController(PostsService postService)
		{
			_postService = postService;
		}

		public IActionResult Create()
		{
			return View();
		}

		public IActionResult UserPosts(string email)
		{
			var userPostsList = _postService.UserPosts(email);
			return View(userPostsList);
		}

		[Authorize]
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create(Posts posts)
		{
			posts.UserEmail = User.Identity.Name;
			_postService.Insert(posts);
			return RedirectToAction("UserPosts", new { email=posts.UserEmail });
		}
    }
}