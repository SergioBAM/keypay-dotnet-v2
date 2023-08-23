using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Other
{
    public class LeaveAllowanceTemplateModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<LeaveAllowanceTemplateLeaveCategoryModel> LeaveCategories { get; set; }
        public string ExternalId { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public ExternalService Source { get; set; }
        public int? LeaveLoadingCalculatedFromPayCategoryId { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public LeaveAccrualStartDateType? LeaveAccrualStartDateType { get; set; }
        public DateTime? LeaveYearStart { get; set; }
    }
}
