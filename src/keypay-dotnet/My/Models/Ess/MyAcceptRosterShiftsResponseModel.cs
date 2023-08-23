using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Ess
{
    public class MyAcceptRosterShiftsResponseModel
    {
        public IList<MyEssRosterShiftModel> Shifts { get; set; }
        public int ProposedSwapCount { get; set; }
        public int PendingShiftCount { get; set; }
        public int BiddableShiftCount { get; set; }
        public int NotAcceptedShiftsCount { get; set; }
    }
}
