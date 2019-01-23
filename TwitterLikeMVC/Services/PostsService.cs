using System.Collections.Generic;
using System.Linq;
using TwitterLikeMVC.Models;

namespace TwitterLikeMVC.Services
{
	public class PostsService
	{
		private readonly ApplicationDbContext _context;

		public PostsService(ApplicationDbContext context)
		{
			_context = context;
		}

		public void Insert(Posts post)
		{
			_context.Add(post);
			_context.SaveChanges();
		}

		public List<Posts> UserPosts(string userEmail)
		{
			return _context.Posts.Where(p => p.UserEmail == userEmail).ToList();
		}
	}
}
