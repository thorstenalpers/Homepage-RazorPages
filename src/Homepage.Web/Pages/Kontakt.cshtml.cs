using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Homepage.Core.Helper;
using Homepage.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Homepage.Web.Pages
{
    public class KontaktModel : PageModel
    {

        [BindProperty]
        public EMail EMail { get; set; }
        
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                EMailService service = new EMailService();
                await service.SendMessage(EMail.From, EMail.Name, EMail.MsgContent);
                TempData["email"] = "Ihre Nachricht wurde gesendet";
                return RedirectToPage("./Kontakt");
            }
            return Page();
        }
    }
}