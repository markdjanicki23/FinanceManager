using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManager.Shared
{
    public enum EarningCategory
    {
        Salary,
        CapitalGain,
        Freelancing,
        Coaching,
        Flipping,
        Gift,
    }
}

// This goes in Shared. As far as I understand, things that will be used by both Client and Server can go here, like Enums.