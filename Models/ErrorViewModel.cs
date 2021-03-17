using System;

namespace EntityFramework_Core_.Net_Core_Database_First_Approach.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
