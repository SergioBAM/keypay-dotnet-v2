using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.My.Enums;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Models.Timesheets;

namespace KeyPayV2.My.Functions
{
    public class TimesheetsFunction : BaseFunction
    {
        public TimesheetsFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Get Business Timesheets
        /// </summary>
        /// <remarks>
        /// Retrieves all timesheets for the specified business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<MyTimesheetLineModel> GetBusinessTimesheets(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<MyTimesheetLineModel>>($"/business/{businessId}/timesheet{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.GET);
        }

        /// <summary>
        /// Get Business Timesheets
        /// </summary>
        /// <remarks>
        /// Retrieves all timesheets for the specified business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<MyTimesheetLineModel>> GetBusinessTimesheetsAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<MyTimesheetLineModel>>($"/business/{businessId}/timesheet{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Create timesheet line
        /// </summary>
        /// <remarks>
        /// Create an individual timesheet line
        /// </remarks>
        public MyIndividualTimesheetLineModel CreateTimesheetLine(int businessId, MyIndividualTimesheetLineModel request)
        {
            return ApiRequest<MyIndividualTimesheetLineModel,MyIndividualTimesheetLineModel>($"/business/{businessId}/timesheet", request, Method.POST);
        }

        /// <summary>
        /// Create timesheet line
        /// </summary>
        /// <remarks>
        /// Create an individual timesheet line
        /// </remarks>
        public Task<MyIndividualTimesheetLineModel> CreateTimesheetLineAsync(int businessId, MyIndividualTimesheetLineModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyIndividualTimesheetLineModel,MyIndividualTimesheetLineModel>($"/business/{businessId}/timesheet", request, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Update timesheet line
        /// </summary>
        /// <remarks>
        /// Update an individual timesheet line
        /// </remarks>
        public MyIndividualTimesheetLineModel UpdateTimesheetLine(int businessId, int timesheetLineId, MyIndividualTimesheetLineModel request)
        {
            return ApiRequest<MyIndividualTimesheetLineModel,MyIndividualTimesheetLineModel>($"/business/{businessId}/timesheet/{timesheetLineId}", request, Method.PUT);
        }

        /// <summary>
        /// Update timesheet line
        /// </summary>
        /// <remarks>
        /// Update an individual timesheet line
        /// </remarks>
        public Task<MyIndividualTimesheetLineModel> UpdateTimesheetLineAsync(int businessId, int timesheetLineId, MyIndividualTimesheetLineModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyIndividualTimesheetLineModel,MyIndividualTimesheetLineModel>($"/business/{businessId}/timesheet/{timesheetLineId}", request, Method.PUT, cancellationToken);
        }

        /// <summary>
        /// Delete timesheet line
        /// </summary>
        /// <remarks>
        /// Delete an individual timesheet line.
        /// Note: You cannot delete a Processed timesheet line.
        /// </remarks>
        public void DeleteTimesheetLine(int businessId, int timesheetLineId)
        {
            ApiRequest($"/business/{businessId}/timesheet/{timesheetLineId}", Method.DELETE);
        }

        /// <summary>
        /// Delete timesheet line
        /// </summary>
        /// <remarks>
        /// Delete an individual timesheet line.
        /// Note: You cannot delete a Processed timesheet line.
        /// </remarks>
        public Task DeleteTimesheetLineAsync(int businessId, int timesheetLineId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/timesheet/{timesheetLineId}", Method.DELETE, cancellationToken);
        }

        /// <summary>
        /// Update/Replace timesheets
        /// </summary>
        /// <remarks>
        /// Performs the same action as 'Bulk Insert Timesheets', but any existing timesheets
        /// for the specified employees within the specified time period
        /// (StartTime - EndTime) will be replaced with the timesheets specified.
        /// </remarks>
        public void UpdateReplaceTimesheets(int businessId, MySubmitTimesheetsRequest request)
        {
            ApiRequest($"/business/{businessId}/timesheet/bulk", request, Method.PUT);
        }

        /// <summary>
        /// Update/Replace timesheets
        /// </summary>
        /// <remarks>
        /// Performs the same action as 'Bulk Insert Timesheets', but any existing timesheets
        /// for the specified employees within the specified time period
        /// (StartTime - EndTime) will be replaced with the timesheets specified.
        /// </remarks>
        public Task UpdateReplaceTimesheetsAsync(int businessId, MySubmitTimesheetsRequest request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/timesheet/bulk", request, Method.PUT, cancellationToken);
        }

        /// <summary>
        /// Bulk Insert Timesheets
        /// </summary>
        /// <remarks>
        /// Adds timesheets for the specified business. This will not replace any existing timesheets.
        /// The timesheets should be grouped by their associated employee IDs, with the key for the timesheet array
        /// being the employee ID. For a Standard Employee ID Type, make sure the employee ID is an integer.
        /// </remarks>
        public void BulkInsertTimesheets(int businessId, MySubmitTimesheetsRequest request)
        {
            ApiRequest($"/business/{businessId}/timesheet/bulk", request, Method.POST);
        }

        /// <summary>
        /// Bulk Insert Timesheets
        /// </summary>
        /// <remarks>
        /// Adds timesheets for the specified business. This will not replace any existing timesheets.
        /// The timesheets should be grouped by their associated employee IDs, with the key for the timesheet array
        /// being the employee ID. For a Standard Employee ID Type, make sure the employee ID is an integer.
        /// </remarks>
        public Task BulkInsertTimesheetsAsync(int businessId, MySubmitTimesheetsRequest request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/timesheet/bulk", request, Method.POST, cancellationToken);
        }
    }
}