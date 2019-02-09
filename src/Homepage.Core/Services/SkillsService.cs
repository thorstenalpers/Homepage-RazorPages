using Homepage.Core.Models;
using System.Collections.Generic;
using System.Linq;

namespace Homepage.Core.Services
{
    public class SkillsService
    {
        public List<Skill> GetSkills()
        {
            return new List<Skill> { 
                new Skill { Name = "C#", Value = 90 },
                new Skill { Name = "ASP .net MVC 5", Value = 80 },
                new Skill { Name = "GIT", Value = 80 },
                new Skill { Name = "Englisch", Value = 70 },
                new Skill { Name = "WPF", Value = 60 },
                new Skill { Name = "ASP .net Core", Value = 50 },
                new Skill { Name = "HTML5", Value = 50 },
                new Skill { Name = "Javascript", Value = 50 },
                new Skill { Name = "Java 1.6", Value = 40 },
                new Skill { Name = "Python", Value = 40 },
                new Skill { Name = "SQL", Value = 40 },
                new Skill { Name = "CSS3", Value = 40 },
                new Skill { Name = "Batch Script", Value = 40 },
                new Skill { Name = "Docker", Value = 20 },
            }.OrderByDescending(e => e.Value).ToList();
        }
    }
}
