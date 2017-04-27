using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayersLib
{
    public class Player
    {
        bool pass;
        bool raise;
        bool call;

        public bool Pass()
        { return pass; }
        public bool Raise()
        { return raise;  }
        public bool Call()
        { return call;  }
    }
}
