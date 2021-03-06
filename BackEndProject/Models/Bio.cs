﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndProject.Models
{
	public class Bio
	{
		[Required]
		public int Id { get; set; }
		[Required]
		public string LogoPath { get; set; }
		[Required]
		public string AboutPath { get; set; }
		[Required]
		public string About { get; set; }
		[Required]
		public string Video { get; set; }
		public string PhoneNumber { get; set; }
		public string PhoneNumber2 { get; set; }
		public string Address { get; set; }
		public string Email { get; set; }
		public string Link { get; set; }
		[NotMapped]
		public IFormFile LogoPhoto { get; set; }
		[NotMapped]
		public IFormFile AboutPhoto { get; set; }
	}
}
