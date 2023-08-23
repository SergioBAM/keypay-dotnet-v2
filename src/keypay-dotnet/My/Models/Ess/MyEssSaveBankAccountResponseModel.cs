using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Ess
{
    public class MyEssSaveBankAccountResponseModel
    {
        public string ValidationWarning { get; set; }
        public MyEssBankAccountModel Result { get; set; }
    }
}
