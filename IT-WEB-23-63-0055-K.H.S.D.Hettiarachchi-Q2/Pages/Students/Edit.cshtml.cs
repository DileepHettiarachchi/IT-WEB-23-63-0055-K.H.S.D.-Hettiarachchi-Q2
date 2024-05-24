using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IT_WEB_23_63_0055_K.H.S.D.Hettiarachchi_Q2.Data;
using IT_WEB_23_63_0055_K.H.S.D.Hettiarachchi_Q2.Model;

namespace IT_WEB_23_63_0055_K.H.S.D.Hettiarachchi_Q2.Pages.Students
{
    public class EditModel : PageModel
    {
        private readonly IT_WEB_23_63_0055_K.H.S.D.Hettiarachchi_Q2.Data.IT_WEB_23_63_0055_KHSDHettiarachchi_Q2Context _context;

        public EditModel(IT_WEB_23_63_0055_K.H.S.D.Hettiarachchi_Q2.Data.IT_WEB_23_63_0055_KHSDHettiarachchi_Q2Context context)
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

            var students_informationnew =  await _context.Students_InformationNew.FirstOrDefaultAsync(m => m.Id == id);
            if (students_informationnew == null)
            {
                return NotFound();
            }
            Students_InformationNew = students_informationnew;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Students_InformationNew).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Students_InformationNewExists(Students_InformationNew.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool Students_InformationNewExists(int id)
        {
            return _context.Students_InformationNew.Any(e => e.Id == id);
        }
    }
}
