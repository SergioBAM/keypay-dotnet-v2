using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Common
{
    public class ClassificationLookupModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}