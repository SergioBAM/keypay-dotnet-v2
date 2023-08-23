using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.ReportingDimensions
{
    public class ReportingDimensionApiModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public ExternalService Source { get; set; }
        public string ExternalId { get; set; }
    }
}
