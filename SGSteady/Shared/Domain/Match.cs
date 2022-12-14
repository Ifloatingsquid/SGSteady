using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using SGSteady.Server.Models;

namespace SGSteady.Shared.Domain
{
    public class Match
    {
        public int MatchID { get; set; }
        public Boolean MatchBoolean { get; set; }
        public int UserID1 { get; set; }
        //public virtual ApplicationUser PersonalProfile { get; set; }
    }
}
