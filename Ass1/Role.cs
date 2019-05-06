﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ass1.Models
{

    public class Role
    {
        [Required]
        public int RoleId
        {
            get;
            set;

        }

        [Required]
        [StringLength(100)]
        public string Name
        {
            get;
            set;

        }
    }
}