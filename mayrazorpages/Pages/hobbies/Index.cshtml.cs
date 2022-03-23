#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using mayrazorpages.Data;

namespace mayrazorpages.Pages.hobbies
{
    public class IndexModel : PageModel
    {
        private readonly mayrazorpages.Data.mayrazorpagesContext _context;

        public IndexModel(mayrazorpages.Data.mayrazorpagesContext context)
        {
            _context = context;
        }

        public IList<Class> Class { get;set; }

        public async Task OnGetAsync()
        {
            Class = await _context.Class.ToListAsync();
        }
    }
}
