using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.User
{
    public class RelatedBusinessesModel
    {
        public List<AbbreviatedBusinessModel> RelatedBusinesses { get; set; }
        public int UserId { get; set; }
    }
}
