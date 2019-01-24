using System.Collections.Generic;
using System.Linq;
using TwitterLikeMVC.Models;

namespace TwitterLikeMVC.Services
{
	public class UserFriendsService
	{
		private readonly ApplicationDbContext _context;

		public UserFriendsService(ApplicationDbContext context)
		{
			_context = context;
		}

		public void AddToFriendList(UserFriends userFriends)
		{
			_context.Add(userFriends);
		}

		public void RemoveFromFriendList(UserFriends userFriends)
		{
			_context.Add(userFriends);
		}

		public List<UserFriends> AllUserFriends(string userEmail)
		{
			return _context.UserFriends.Where(u => u.UserEmail == userEmail).ToList();
		}
	}
}
