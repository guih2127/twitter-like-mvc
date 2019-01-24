using System.Collections.Generic;

namespace TwitterLikeMVC.Models
{
	public class UserFriends
	{
		public string UserEmail { get; set; }
		public List<string> Friends { get; set; }
	}
}
