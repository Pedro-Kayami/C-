﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CredVacinas.Data;
using CredVacinas.Models;

namespace CredVacinas.Pages.SetorCrud
{
    public class DeleteModel : PageModel
    {
        private readonly CredVacinas.Data.CredVacinasContext _context;

        public DeleteModel(CredVacinas.Data.CredVacinasContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Setor Setor { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Setor == null)
            {
                return NotFound();
            }

            var setor = await _context.Setor.FirstOrDefaultAsync(m => m.Id == id);

            if (setor == null)
            {
                return NotFound();
            }
            else 
            {
                Setor = setor;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Setor == null)
            {
                return NotFound();
            }
            var setor = await _context.Setor.FindAsync(id);

            if (setor != null)
            {
                Setor = setor;
                _context.Setor.Remove(Setor);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
