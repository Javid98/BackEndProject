﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEndProject.DAL;
using BackEndProject.Models;
using BackEndProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEndProject.Controllers
{
    public class BlogController : Controller
    {
        public readonly AppDbContext _db;
        public BlogController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index(int page=1)
        {
            ViewBag.Page = page;
            ViewBag.PageCount = Math.Ceiling((decimal)_db.Blogs.Count() / 6);
            List<Blog> blogs = _db.Blogs.Include(b=>b.AppUser).Skip((page-1)*6).Take(6).ToList();
            BlogVM model = new BlogVM
            {
                BestTheme = _db.Blogs.OrderByDescending(b => b.Id).FirstOrDefault(),
                Blogs = blogs,
                LatestPosts = _db.Blogs.Include(b => b.AppUser).OrderByDescending(b => b.Id).Take(3).ToList()
            };
            return View(model);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            Blog blog = await _db.Blogs.Include(b => b.AppUser).FirstOrDefaultAsync(b=>b.Id==id);
            if (blog == null) return NotFound();
            BlogVM model = new BlogVM
            {
                Blog=blog,
                BestTheme = _db.Blogs.OrderByDescending(b => b.Id).FirstOrDefault(),
                LatestPosts = _db.Blogs.Include(b => b.AppUser).OrderByDescending(b => b.Id).Take(3).ToList()
            };
            return View(model);
        }
        public IActionResult Search(string search)
        {
            List<Blog> model = _db.Blogs.Include(c=>c.AppUser).Where(c => c.Title.Contains(search)||c.AppUser.UserName.Contains(search)).OrderByDescending(c=>c.Id).Take(5).ToList();
            return PartialView("_SearchBlogPartialView", model);
        }
        public IActionResult SearchBtn(string search,int page = 1)
        {
            ViewBag.Page = page;
            ViewBag.SearchText = search;

            ViewBag.PageCount = Math.Ceiling((decimal)_db.Blogs.Include(b => b.AppUser).Where(b=>b.AppUser.UserName.Contains(search)||b.Title.Contains(search)).Count() / 6);

            List<Blog> model = _db.Blogs.Include(b => b.AppUser).Where(b => b.AppUser.UserName.Contains(search)||b.Title.Contains(search)).OrderByDescending(b=>b.Id).Skip((page - 1) * 6).Take(6).ToList();

            if (model.Count == 0) return Content("null");

            return PartialView("_SearchBlogBtnPartialView", model);
        }
    }
}