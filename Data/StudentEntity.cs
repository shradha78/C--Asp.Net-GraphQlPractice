﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPPractice.Data
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [StringLength(30)]
        public string Name { get; set; }
    }
}
