using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMediaSite.Models
{
    public class UserPage
    {
        [Required] [MaxLength(450)]
        public string userID { get; set; }

        public string[] comments { get; set; }

        public string[] imgUrls { get; set; }

    }
}
