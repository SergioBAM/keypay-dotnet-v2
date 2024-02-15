using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Models.Employee;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Common
{
    public class StandardHoursModel
    {
        public int EmployeeId { get; set; }
        public decimal StandardHoursPerWeek { get; set; }
        public decimal StandardHoursPerDay { get; set; }
        public bool UseAdvancedWorkWeek { get; set; }
        public List<StandardHoursDayModel> StandardWorkDays { get; set; }
        public decimal? FullTimeEquivalentHours { get; set; }
    }
}
