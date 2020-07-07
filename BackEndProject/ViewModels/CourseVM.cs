﻿using BackEndProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndProject.ViewModels
{
	public class CourseVM
	{
		public Course Course { get; set; }
		public Blog BestTheme { get; set; }
		public IEnumerable<Blog> LatestPosts { get; set; }

	}
}
