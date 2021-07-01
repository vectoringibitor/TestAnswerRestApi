using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class StorageService : IStorageService
    {
        private ApplicationContext db;

        public StorageService(ApplicationContext context)
        {
            db = context;
        }

        public List<TaskAnswer> GetAllTaskAnswers()
        {
            return db.TaskAnswers.ToList();
        }

        public void StoreTaskAnswer(TaskAnswer taskAnswer)
        {
            db.TaskAnswers.Add(taskAnswer);
            db.SaveChanges();
        }
    }
}
