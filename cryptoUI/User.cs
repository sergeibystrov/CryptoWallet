using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cryptoUI
{
    partial class User
    {
        public override string ToString()
        {
            return username+password+balance;
        }
    }
}
