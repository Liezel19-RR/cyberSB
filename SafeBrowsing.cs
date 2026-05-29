using System;
using System.Collections.Generic;
using System.Text;

namespace cyber_security_bottttt
{
    class SafeBrowsing : SecurityTopic
    {
        public override string GetInfo()
        {
            return "Always check HTTPS before entering personal info.";
        }
    }
}
