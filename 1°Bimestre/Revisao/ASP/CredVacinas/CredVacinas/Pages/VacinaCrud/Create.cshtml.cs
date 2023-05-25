﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CredVacinas.Data;
using CredVacinas.Models;

namespace CredVacinas.Pages.VacinaCrud
{
    public class CreateModel : PageModel
    {
        private readonly CredVacinas.Data.CredVacinasContext _context;

        public CreateModel(CredVacinas.Data.CredVacinasContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Vacina Vacina { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Vacina == null || Vacina == null)
            {
                return Page();
            }

            _context.Vacina.Add(Vacina);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
