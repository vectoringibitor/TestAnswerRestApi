using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface IStorageService
    {
        void StoreTaskAnswer(TaskAnswer taskAnswer);
        List<TaskAnswer> GetAllTaskAnswers();
    }
}
