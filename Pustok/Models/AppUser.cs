using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pustok.Models
{
	public class AppUser : IdentityUser
	{
		public string Name { get; set; }	
		public string Surname { get; set; }
		[NotMapped]
		public string FullName { get => $"{Name} {Surname}"; }
	}
}
