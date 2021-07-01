using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class TaskAnswer
    {
        public int Id { get; set; }
        [Required]
        public Guid TaskId { get; set; }
        [Required]
        public DateTime AnswerTime { get; set; }
        [Required]
        public String Text { get; set; }
    }

}
