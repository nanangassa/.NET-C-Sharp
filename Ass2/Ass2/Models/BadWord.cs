﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ass2.Models
{
    public class BadWord
    {
        [Key]
        public int BadWordId
        {
            get;
            set;
        }

        [Required]
        [StringLength(1000)]
        public string Word
        {
            get;
            set;
        }
    }
}
