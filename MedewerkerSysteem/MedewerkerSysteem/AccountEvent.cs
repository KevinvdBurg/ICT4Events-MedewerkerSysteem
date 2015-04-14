using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedewerkerSysteem
{
    class AccountEvent
    {
        public bool Present { get; set; }
        public string RFID { get; set; }

        public int EventID { get; set; }

        public AccountEvent(bool Present, string RFID, int EventID)
        {
            this.Present = Present;
            this.RFID = RFID;
            this.EventID = EventID;
        }
    }
}
