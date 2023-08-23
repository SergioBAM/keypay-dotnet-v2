using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Reporting
{
    public class UkFpsXmlApiModel
    {
        public int PayRunId { get; set; }
        public bool LodgeFinalPayRun { get; set; }
        public int TaxYear { get; set; }
    }
}
