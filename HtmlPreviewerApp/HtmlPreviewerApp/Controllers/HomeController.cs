using HtmlPreviewerApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HtmlPreviewerApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ConnectionStringClass _cc;
        public HomeController(ConnectionStringClass cc)
        {
            _cc = cc;
        }

        public IActionResult Index()
        {            
            return View();
        }
        [HttpPost]
        public IActionResult Index(string html, int? editId)
        {
            if(editId != null)
            {
                var itemToUpdate = _cc.HtmlSamples.Where(model => model.SampleID == editId);
                itemToUpdate.First().HtmlSample = html;
                itemToUpdate.First().LastEditDate = DateTime.UtcNow;
                _cc.SaveChanges();
            }

            else 
            {
                var id = _cc.HtmlSamples.Count();
                var model = new HtmlModel()
                {
                    HtmlSample = html,
                    CreateDate = DateTime.UtcNow,
                    LastEditDate = DateTime.UtcNow,
                    SampleID = ++id,
                    Title = "Html Sample #" + id

                };
                _cc.Add(model);
                _cc.SaveChanges();
            }
            
            return View();
        }
   
        public IActionResult Read()
        {
            var data = _cc.HtmlSamples.ToList();
            return Json(data);
        }


        public IActionResult GetHtml(int id)
        {
            
            var sample = _cc.HtmlSamples.Where(model => model.SampleID == id).ToList();
            return Json(sample);
        }

        public bool CheckOriginal(string value)
        {
            var result = _cc.HtmlSamples.Where(model => model.HtmlSample == value).Count() == 0;
            return result;
        }
    }
}
