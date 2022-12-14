using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGSteady.Shared.Domain
{
    public class Chat
    {
        public int ChatID { get; set; }
        public string MessageText { get; set; }
        public DateTime ChatTimeStamp { get; set; }
        public int MatchID { get; set; }
        public virtual Match Match { get; set; }
    }
}
