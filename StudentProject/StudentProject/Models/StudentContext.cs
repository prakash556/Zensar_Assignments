﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace StudentProject.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("StudentConnection")
        {

        }
        public DbSet<StudentTable> StudentTable { get; set; }
    }
}