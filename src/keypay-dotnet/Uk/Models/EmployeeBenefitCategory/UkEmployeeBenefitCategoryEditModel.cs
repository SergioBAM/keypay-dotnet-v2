using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;
using MidpointRounding = KeyPayV2.Uk.Enums.MidpointRounding;

namespace KeyPayV2.Uk.Models.EmployeeBenefitCategory
{
    public class UkEmployeeBenefitCategoryEditModel
    {
        public int? BenefitCategoryId { get; set; }
        public bool CarryBenefitForward { get; set; }
        public decimal AmountForegone { get; set; }
        public decimal AmountMadeGood { get; set; }
        public int StartFromPeriod { get; set; }
        public decimal AmountPayrolledToDate { get; set; }
        public decimal AmountToBePayrolledPerPeriod { get; set; }
        public int Year { get; set; }
    }
}
