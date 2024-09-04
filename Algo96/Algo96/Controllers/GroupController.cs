﻿using Algo96.EF;
using Microsoft.AspNetCore.Mvc;

namespace Algo96.Controllers
{
    public class GroupController : Controller
    {
        private ApplicationDbContext db;
        public GroupController(ApplicationDbContext db)
        {
            this.db = db;
        }

        [HttpGet]
        [Route("/group")]
        public async Task<IActionResult> GetGroups()
        {
            return Ok(db.Groups.ToList());
        }

        [HttpGet]
        [Route("/group/{id}")]
    }
}
