using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _411019286.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Music(string name,float? music)
        {
            var result = "";
            if (music.HasValue)
            {
                if (music.Value == 1)
                {
                result = "do";
                }
                if (music.Value == 2)
                {
                    result = "re";
                }
                if (music.Value == 3)
                {
                    result = "mi";
                }
                if (music.Value == 4)
                {
                    result = "fa";
                }
                if (music.Value == 5)
                {
                    result = "so";
                }
                if (music.Value == 6)
                {
                    result = "la";
                }
                if (music.Value == 7)
                {
                    result = "xi";
                }
                if (music.Value <=0)
                {
                    result = "錯誤";
                }

            }

            ViewBag.Music = result;
            ViewBag.Name = name;
            return View();
        }
    }
}