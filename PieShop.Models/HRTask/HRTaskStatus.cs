using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PieShop.Models.HRTask
{
    public enum HRTaskStatus
    {
        Open,
        Assigned,
        InProgress,
        Blocked,
        Complete
    }
}
