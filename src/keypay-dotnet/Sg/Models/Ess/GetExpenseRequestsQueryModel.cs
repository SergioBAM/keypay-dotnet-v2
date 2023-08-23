using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Ess
{
    public class GetExpenseRequestsQueryModel
    {
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
    }
}
