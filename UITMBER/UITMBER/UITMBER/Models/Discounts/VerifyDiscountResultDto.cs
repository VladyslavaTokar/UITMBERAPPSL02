using System;
using System.Collections.Generic;
using System.Text;

namespace UITMBER.Models.Discounts
{
    public class VerifyDiscountResultDto
    {
        public bool Success { get; set; }
        public bool CanUse { get; set; }
        public string Error { get; set; }
    }
}
