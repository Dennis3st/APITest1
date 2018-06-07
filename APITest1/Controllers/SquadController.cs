using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APITest1.Models;
using System.Net;
using System.Web;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Web.Http;

namespace APITest1.Controllers
{
    
    public class SquadController : ApiController
    {
        Squad[] squads = new Squad[]
        {
            new Squad { id = "1", name = "Mario Götze", age = "25", position = "Mittelfeld"},
            new Squad { id = "2", name = "Marco Reus", age = "27", position = "Linksaußen"},
            new Squad { id = "3", name = "Jaden Sancho", age ="21", position = "Mittelfeld"}
        };

        public IEnumerable<Squad> GetSquads()
        {
            return squads;
        }

        public IHttpActionResult GetSquad(string id)
        {
            var squad = squads.FirstOrDefault((s) => s.id == id);
            if (squads== null)
            {
                return NotFound();
            }
            return Ok(squads);
        }
    }
}