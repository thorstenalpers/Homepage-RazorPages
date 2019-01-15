using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Homepage.Models
{
    public class EMail
    {
        /// <summary>
        /// Name des Senders
        /// </summary>
        [Required(ErrorMessage = "Name ist erforderlich")]
        public string Name { get; set; }

        /// <summary>
        /// EMail Adresse des Senders
        /// </summary>
        [Required(ErrorMessage = "Absender ist erforderlich")]
        [EmailAddress]
        public string From { get; set; }

        /// <summary>
        /// Nachricht des Senders
        /// </summary>
        [Required(ErrorMessage = "Nachricht ist erforderlich")]
        public string MsgContent { get; set; }
    }
}
