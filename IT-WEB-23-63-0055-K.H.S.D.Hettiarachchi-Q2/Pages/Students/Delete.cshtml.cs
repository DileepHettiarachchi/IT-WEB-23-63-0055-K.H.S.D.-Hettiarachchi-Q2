using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IT_WEB_23_63_0055_K.H.S.D.Hettiarachchi_Q2.Data;
using IT_WEB_23_63_0055_K.H.S.D.Hettiarachchi_Q2.Model;

namespace IT_WEB_23_63_0055_K.H.S.D.Hettiarachchi_Q2.Pages.Students
{
    public class DeleteModel : PageModel
    {
        private readonly IT_WEB_23_63_0055_K.H.S.D.Hettiarachchi_Q2.Data.IT_WEB_23_63_0055_KHSDHettiarachchi_Q2Context _context;

        public DeleteModel(IT_WEB_23_63_0055_K.H.S.D.Hettiarachchi_Q2.Data.IT_WEB_23_63_0055_KHSDHettiarachchi_Q2Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Students_InformationNew Students_InformationNew { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var students_informationnew = await _context.Students_InformationNew.FirstOrDefaultAsync(m => m.Id == id);

            if (students_informationnew == null)
            {
                return NotFound();
            }
            else
            {
                Students_InformationNew = students_informationnew;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var students_informationnew = await _context.Students_InformationNew.FindAsync(id);
            if (students_informationnew != null)
            {
                Students_InformationNew = students_informationnew;
                _context.Students_InformationNew.Remove(Students_InformationNew);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
