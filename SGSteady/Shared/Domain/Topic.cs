//using SGSteady.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGSteady.Shared.Domain
{
    public class Topic
    {
        public int TopicID { get; set; }
        public DateTime TimeStamp{ get; set; }
        public string TopicTitle { get; set; }
        public string TopicDesc { get; set; }
        //public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
