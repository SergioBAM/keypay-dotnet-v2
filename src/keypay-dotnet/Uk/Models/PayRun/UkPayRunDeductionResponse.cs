using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;
using MidpointRounding = KeyPayV2.Uk.Enums.MidpointRounding;

namespace KeyPayV2.Uk.Models.PayRun
{
    public class UkPayRunDeductionResponse
    {
        public Dictionary<string,List<UkDeductionModel>> Deductions { get; set; }
        public int PayRunId { get; set; }
    }
}