﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IT_WEB_23_63_0055_K.H.S.D.Hettiarachchi_Q2.Model;

namespace IT_WEB_23_63_0055_K.H.S.D.Hettiarachchi_Q2.Data
{
    public class IT_WEB_23_63_0055_KHSDHettiarachchi_Q2Context : DbContext
    {
        public IT_WEB_23_63_0055_KHSDHettiarachchi_Q2Context (DbContextOptions<IT_WEB_23_63_0055_KHSDHettiarachchi_Q2Context> options)
            : base(options)
        {
        }

        
        public DbSet<IT_WEB_23_63_0055_K.H.S.D.Hettiarachchi_Q2.Model.Students_InformationNew> Students_InformationNew { get; set; } = default!;
        public DbSet<IT_WEB_23_63_0055_K.H.S.D.Hettiarachchi_Q2.Model.CoursesNew> CoursesNew { get; set; } = default!;
        public DbSet<IT_WEB_23_63_0055_K.H.S.D.Hettiarachchi_Q2.Model.All_info> All_info { get; set; } = default!;
    }
}
