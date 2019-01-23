using System.ComponentModel.DataAnnotations;

namespace TwitterLikeMVC.Models
{
	public class Posts
	{
		public int Id { get; set; }
		public string UserEmail { get; set; }

		[StringLength(300)]
		[Required]
		public string Post { get; set; }
	}
}
