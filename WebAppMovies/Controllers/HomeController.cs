﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppMovies.db;
using WebAppMovies.Models;

namespace WebAppMovies.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            var db = new MoviesEntities2();
            ViewBag.toListMovie= db.Movies.ToList();
            return View();
        }

       public ActionResult FilmDetay(int id)
        {
          var db = new MoviesEntities2();
          var movie = db.Movies.Find(id);
          Movie mymovie = new WebAppMovies.Models.Movie(movie);
          ViewBag.commentList = db.Comments.Where(c=>c.Movies_Id==id).ToList();
          HttpContext.Session["sessionmovieid"] = id;
          return View(mymovie);
        }

        [HttpPost]
        public ActionResult YorumEkleme(WebAppMovies.Models.Movie mymovieModel)
        {
            var db = new MoviesEntities2();
            var newComment = new  WebAppMovies.db.Comment();
            newComment.MemberName = mymovieModel.myMovie.MemberName;
            newComment.Text = mymovieModel.myMovie.Text;
            newComment.AddedDate = DateTime.Now;
            newComment.Movies_Id = Convert.ToInt32(HttpContext.Session["sessionmovieid"]);
            var getid = Convert.ToInt32(HttpContext.Session["sessionmovieid"]);
            db.Entry(newComment).State = EntityState.Added;
            db.SaveChanges();
            return  RedirectToAction("FilmDetay","Home", new { id = getid });
        }
        

      
    }
}