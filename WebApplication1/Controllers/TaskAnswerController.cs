using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [Produces("application/json")]
    [Route("api/answers")]
    public class TaskAnswerController : Controller
    {
        private IStorageService _storageService;

        public TaskAnswerController(IStorageService storageService)
        {
            _storageService = storageService;
        }

        // GET api/answers
        [HttpGet]
        public ActionResult Get()
        {
            // получаем объекты из бд
            var taskAnswers = _storageService.GetAllTaskAnswers();
            return Ok(taskAnswers);
        }

        // POST api/answers
        [HttpPost]
        public ActionResult Add([FromBody]TaskAnswer taskAnswer)
        {
            if (ModelState.IsValid)
            {
                _storageService.StoreTaskAnswer(taskAnswer);
                return Ok("Success");
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

    }
}