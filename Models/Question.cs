using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Question
    {
        public int QuestionId { get; set; }

        [Index(IsUnique = true)]
        public int QuestionNumber { get; set; }
        public string QuestionText { get; set; }
        public int ScoreA { get; set; }
        public int ScoreB { get; set; }

        public int ScoreC { get; set; }
    }
}