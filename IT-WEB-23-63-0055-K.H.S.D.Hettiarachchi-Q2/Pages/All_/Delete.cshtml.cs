﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IT_WEB_23_63_0055_K.H.S.D.Hettiarachchi_Q2.Data;
using IT_WEB_23_63_0055_K.H.S.D.Hettiarachchi_Q2.Model;

namespace IT_WEB_23_63_0055_K.H.S.D.Hettiarachchi_Q2.Pages.All_
{
    public class DeleteModel : PageModel
    {
        private readonly IT_WEB_23_63_0055_K.H.S.D.Hettiarachchi_Q2.Data.IT_WEB_23_63_0055_KHSDHettiarachchi_Q2Context _context;

        public DeleteModel(IT_WEB_23_63_0055_K.H.S.D.Hettiarachchi_Q2.Data.IT_WEB_23_63_0055_KHSDHettiarachchi_Q2Context context)
        {
            _context = context;
        }

        [BindProperty]
        public All_info All_info { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var all_info = await _context.All_info.FirstOrDefaultAsync(m => m.Id == id);

            if (all_info == null)
            {
                return NotFound();
            }
            else
            {
                All_info = all_info;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var all_info = await _context.All_info.FindAsync(id);
            if (all_info != null)
            {
                All_info = all_info;
                _context.All_info.Remove(All_info);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}