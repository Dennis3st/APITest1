using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using APITest1.Models;
using RestSharp;
using Newtonsoft.Json;
using System.IO;


namespace APITest1.Controllers
{
    public class HomeController : Controller
    {

       
        public IActionResult Index()
        {

            return View();

        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            //var key = "Authorization";
            //var password = "565ec012251f932ea4000001d6578ace24c6409a64699d054cc0d4e4";
            //var baseUrl = "http://api.football-api.com/2.0/";
            //var tag = "team/9002";



            //var rClient = new RestClient(baseUrl + tag + "?" + key + "=" + password);
            //var rRequest = new RestRequest(Method.GET);

            //IRestResponse rResponse = rClient.Execute(rRequest);

            //var content = rResponse.Content;

            //rClient.ExecuteAsync<List<RootObject>>(rRequest, response =>
            //{
            //    response.Data.ForEach(squad =>
            //    {
            //        List <T>() = new List(squad.name);
            //        lvi.Tag = squad;
            //        listViewName.BeginInvoke((Action)delegate { listViewName.Items.Add(lvi); });
            //    });
            //    listViewName.BeginInvoke((Action)delegate { listViewName.Enabled = true; });
            //});

           return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        const string apiKey = "5fa7531326154d49baa40543e595da31";
    }
}
