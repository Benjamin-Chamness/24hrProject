﻿using _24hr.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24hr.Models
{
    public class ReplyDetail
    {
        public int ReplyId { get; set; }
        public Guid Author { get; set; }
        public string Text { get; set; }

        [Display(Name = "Created")]
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset? ModifiedUtc { get; set; }


         public Comment Comment {get;set;}

        public Comment Comment {get;set;}

    }
}
