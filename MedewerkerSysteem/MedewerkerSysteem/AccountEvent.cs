using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedewerkerSysteem
{
    public class AccountEvent
    {
        public bool Present { get; set; }
        public int AccountID { get; set; }

        public int EventID { get; set; }

        public AccountEvent(bool Present, int accountID, int EventID)
        {
            this.Present = Present;
            this.AccountID = accountID;
            this.EventID = EventID;
        }
    }
}
