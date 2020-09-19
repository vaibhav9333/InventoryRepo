using Inventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;


namespace Inventory.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            IEnumerable<Item> Items = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:53624/api/");
                var Responcetask = client.GetAsync("Items");
                Responcetask.Wait();
                var Result = Responcetask.Result;
                if (Result.IsSuccessStatusCode)
                {
                    var readtask = Result.Content.ReadAsAsync<IList<Item>>();
                    readtask.Wait();
                   Items= readtask.Result;
                }

            }
            return View(Items);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Item Items)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:53624/api/Items");
                var posttask = client.PostAsJsonAsync<Item>("Items", Items);
                posttask.Wait();
                var result = posttask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }
            ModelState.AddModelError(string.Empty, "Server error");


            return View(Items);
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Item Items = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:53624/api/");
                var Responcetask = client.GetAsync("Items?id=" + id.ToString());
                Responcetask.Wait();
                var Result = Responcetask.Result;
                if (Result.IsSuccessStatusCode)
                {
                    var readtask = Result.Content.ReadAsAsync<Item>();
                    readtask.Wait();
                    Items = readtask.Result;
                }

            }



            return View(Items);
            
        }

        [ActionName("Delete")]
        [HttpPost]
        public ActionResult Deleteconfirm(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:53624/api/");
                var responce = client.DeleteAsync("Items/" + id.ToString());
                responce.Wait();
                var result = responce.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }

            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult details(int id)
        {
            Item Items = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:53624/api/");
                var Responcetask = client.GetAsync("Items?id=" + id.ToString());
                Responcetask.Wait();
                var Result = Responcetask.Result;
                if (Result.IsSuccessStatusCode)
                {
                    var readtask = Result.Content.ReadAsAsync<Item>();
                    readtask.Wait();
                    Items = readtask.Result;
                }

            }



            return View(Items);
        }

        }
    }