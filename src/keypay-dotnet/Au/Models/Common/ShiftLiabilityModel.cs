using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Common
{
    public class ShiftLiabilityModel
    {
        public string LiabilityCategoryName { get; set; }
        public int LiabilityCategoryId { get; set; }
        public bool IncludeInShiftCost { get; set; }
        public decimal Amount { get; set; }
        public ShiftAllowanceOption Option { get; set; }
        public decimal Cost { get; set; }
    }
}