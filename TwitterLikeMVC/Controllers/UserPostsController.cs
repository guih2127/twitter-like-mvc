﻿using Microsoft.AspNetCore.Mvc;
using TwitterLikeMVC.Services;
using TwitterLikeMVC.Models;
using Microsoft.AspNetCore.Authorization;

namespace TwitterLikeMVC.Controllers
{
    public class UserFriendsController : Controller
    {
		private readonly UserFriendsService _userFriendsService;

		public UserFriendsController(UserFriendsService userFriendsService)
		{
			_userFriendsService = userFriendsService;
		}

		[Authorize]
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult AddFriendToList(string friendEmail)
		{
			UserFriends userFriends = new UserFriends { };
			userFriends.UserEmail = User.Identity.Name;
			userFriends.Friends.Add(friendEmail);

			return RedirectToAction("UserFriends", new { email = userFriends.UserEmail });
		}
    }
}