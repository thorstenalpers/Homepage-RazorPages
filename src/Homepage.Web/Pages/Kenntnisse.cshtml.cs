using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Homepage.Core.Services;
using Homepage.Core.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Homepage.Web.Pages
{


    public class KenntnisseModel : PageModel
    {
        public List<Skill> Kenntnisse { get; set; }


        public void OnGet()
        {
            SkillsService service = new SkillsService();
            Kenntnisse = service.GetSkills();
        }
    }
}
