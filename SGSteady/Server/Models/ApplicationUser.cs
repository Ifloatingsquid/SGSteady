using Microsoft.AspNetCore.Identity;
using SGSteady.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGSteady.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string ICNumber { get; set; }
        public int PersonalProfileID { get; set; }
        public virtual PersonalProfile PersonalProfile { get; set; }
        public virtual List<Topic> Topic { get; set; }
        public virtual List<Post> Post { get; set; }
        public virtual List<Match> Match1 { get; set; }
        public virtual List<Match> Match2 { get; set; }



    }
}

