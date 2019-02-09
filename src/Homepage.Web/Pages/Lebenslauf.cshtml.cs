using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Homepage.Web.Pages
{
    public class LebenslaufModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
        }
    }
}
