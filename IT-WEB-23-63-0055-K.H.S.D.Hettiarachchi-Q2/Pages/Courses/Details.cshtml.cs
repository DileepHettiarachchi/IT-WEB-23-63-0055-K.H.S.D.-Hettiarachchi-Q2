﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IT_WEB_23_63_0055_K.H.S.D.Hettiarachchi_Q2.Data;
using IT_WEB_23_63_0055_K.H.S.D.Hettiarachchi_Q2.Model;

namespace IT_WEB_23_63_0055_K.H.S.D.Hettiarachchi_Q2.Pages.Courses
{
    public class DetailsModel : PageModel
    {
        private readonly IT_WEB_23_63_0055_K.H.S.D.Hettiarachchi_Q2.Data.IT_WEB_23_63_0055_KHSDHettiarachchi_Q2Context _context;

        public DetailsModel(IT_WEB_23_63_0055_K.H.S.D.Hettiarachchi_Q2.Data.IT_WEB_23_63_0055_KHSDHettiarachchi_Q2Context context)
        {
            _context = context;
        }

        public CoursesNew CoursesNew { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coursesnew = await _context.CoursesNew.FirstOrDefaultAsync(m => m.Id == id);
            if (coursesnew == null)
            {
                return NotFound();
            }
            else
            {
                CoursesNew = coursesnew;
            }
            return Page();
        }
    }
}
