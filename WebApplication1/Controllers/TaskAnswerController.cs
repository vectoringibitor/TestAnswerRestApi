using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Produces("application/json")]
    [Route("api/answers")]
    public class TaskAnswerController : Controller
    {
        private ApplicationContext db;
        public TaskAnswerController(ApplicationContext context)
        {
            db = context;
        }

        // GET api/answers
        [HttpGet]
        public ActionResult Get()
        {
            // получаем объекты из бд
            var taskAnswers = db.TaskAnswers.ToList();
            return Ok(taskAnswers);
        }

        // POST api/answers
        [HttpPost]
        public ActionResult Add([FromBody]TaskAnswer taskAnswer)
        {
            if (ModelState.IsValid)
            {
                db.TaskAnswers.Add(taskAnswer);
                db.SaveChanges();
                return Ok("Success");
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

    }
}