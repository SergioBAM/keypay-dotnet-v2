using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Other
{
    public class ReportsRosterLiveLeaveExport_GetQueryModel
    {
        public Int32[] PayScheduleIds { get; set; }
        public DateTime? AsAtDate { get; set; }
    }
}
