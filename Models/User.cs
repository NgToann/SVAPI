using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SVAPI.Models
{
	public class User
	{
		[Key]
		public int UserId { get; set; }
		[Required]
		public string UserName { get; set; }
		[Required]
		public string FullName { get; set; }
		[Required]
		public string Password { get; set; }
		[Required]
		public string Remarks { get; set; }
		[Required]
		public string UserProfilePath { get; set; }
		[Required]
		public string UserLevel { get; set; }
		[Required]
		public string SectionName { get; set; }
		[Required]
		public bool CurrentStatus { get; set; }
	}
}
