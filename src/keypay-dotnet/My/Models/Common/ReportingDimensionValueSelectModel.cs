using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Common
{
    public class ReportingDimensionValueSelectModel
    {
        public int ReportingDimensionId { get; set; }
        public bool IsDeleted { get; set; }
        public int? Value { get; set; }
        public string Text { get; set; }
    }
}
