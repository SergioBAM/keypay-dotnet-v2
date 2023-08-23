using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Other
{
    public class WorkersCompReportGridModel
    {
        public int? EmployingEntityId { get; set; }
        public string EmployingEntity { get; set; }
        public int PayCategoryId { get; set; }
        public decimal EarningsReporting { get; set; }
        public decimal SuperContributionReporting { get; set; }
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public int ReportingLocationId { get; set; }
        public string ReportingLocationName { get; set; }
    }
}
