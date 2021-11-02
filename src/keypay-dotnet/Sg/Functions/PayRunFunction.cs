using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Sg.Enums;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Models.PayRun;

namespace KeyPayV2.Sg.Functions
{
    public class PayRunFunction : BaseFunction
    {
        public PayRunFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List Pay Run Totals for Employee
        /// </summary>
        /// <remarks>
        /// Lists all the pay run totals for the employee with the specified ID.
        /// </remarks>
        public List<PayRunTotalModel> ListPayRunTotalsForEmployee(int businessId, int employeeId)
        {
            return ApiRequest<List<PayRunTotalModel>>($"/business/{businessId}/employee/{employeeId}/payruntotals", Method.GET);
        }

        /// <summary>
        /// List Pay Run Totals for Employee
        /// </summary>
        /// <remarks>
        /// Lists all the pay run totals for the employee with the specified ID.
        /// </remarks>
        public Task<List<PayRunTotalModel>> ListPayRunTotalsForEmployeeAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<PayRunTotalModel>>($"/business/{businessId}/employee/{employeeId}/payruntotals", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get Journal Details
        /// </summary>
        /// <remarks>
        /// Gets the journal details for this pay run.
        /// </remarks>
        public List<SgJournalItemResponse> GetJournalDetails(int businessId, int payRunId)
        {
            return ApiRequest<List<SgJournalItemResponse>>($"/business/{businessId}/journal/{payRunId}", Method.GET);
        }

        /// <summary>
        /// Get Journal Details
        /// </summary>
        /// <remarks>
        /// Gets the journal details for this pay run.
        /// </remarks>
        public Task<List<SgJournalItemResponse>> GetJournalDetailsAsync(int businessId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SgJournalItemResponse>>($"/business/{businessId}/journal/{payRunId}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// List Pay Runs
        /// </summary>
        /// <remarks>
        /// Get a list of pay runs associated with the business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<PayRunModel> ListPayRuns(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<PayRunModel>>($"/business/{businessId}/payrun{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.GET);
        }

        /// <summary>
        /// List Pay Runs
        /// </summary>
        /// <remarks>
        /// Get a list of pay runs associated with the business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<PayRunModel>> ListPayRunsAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<PayRunModel>>($"/business/{businessId}/payrun{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Create Pay Run
        /// </summary>
        /// <remarks>
        /// Creates a new pay run for this business.
        /// </remarks>
        public PayRunModel CreatePayRun(int businessId, PayRunCreateRequest request)
        {
            return ApiRequest<PayRunModel,PayRunCreateRequest>($"/business/{businessId}/payrun", request, Method.POST);
        }

        /// <summary>
        /// Create Pay Run
        /// </summary>
        /// <remarks>
        /// Creates a new pay run for this business.
        /// </remarks>
        public Task<PayRunModel> CreatePayRunSynchronouslyAsync(int businessId, PayRunCreateRequest request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PayRunModel,PayRunCreateRequest>($"/business/{businessId}/payrun", request, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Get Pay Run
        /// </summary>
        /// <remarks>
        /// Gets the pay run with the specified ID.
        /// </remarks>
        public PayRunModel GetPayRun(int businessId, int payRunId)
        {
            return ApiRequest<PayRunModel>($"/business/{businessId}/payrun/{payRunId}", Method.GET);
        }

        /// <summary>
        /// Get Pay Run
        /// </summary>
        /// <remarks>
        /// Gets the pay run with the specified ID.
        /// </remarks>
        public Task<PayRunModel> GetPayRunAsync(int businessId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PayRunModel>($"/business/{businessId}/payrun/{payRunId}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Delete Pay Run
        /// </summary>
        /// <remarks>
        /// Deletes the pay run with the specified ID.
        /// </remarks>
        public void DeletePayRun(int businessId, int payRunId)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}", Method.DELETE);
        }

        /// <summary>
        /// Delete Pay Run
        /// </summary>
        /// <remarks>
        /// Deletes the pay run with the specified ID.
        /// </remarks>
        public Task DeletePayRunAsync(int businessId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/payrun/{payRunId}", Method.DELETE, cancellationToken);
        }

        /// <summary>
        /// List Deductions
        /// </summary>
        /// <remarks>
        /// Gets all the deductions for a pay run.
        /// </remarks>
        public SgPayRunDeductionResponse ListDeductions(int businessId, int payRunId)
        {
            return ApiRequest<SgPayRunDeductionResponse>($"/business/{businessId}/payrun/{payRunId}/deductions", Method.GET);
        }

        /// <summary>
        /// List Deductions
        /// </summary>
        /// <remarks>
        /// Gets all the deductions for a pay run.
        /// </remarks>
        public Task<SgPayRunDeductionResponse> ListDeductionsAsync(int businessId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SgPayRunDeductionResponse>($"/business/{businessId}/payrun/{payRunId}/deductions", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Create Deductions
        /// </summary>
        /// <remarks>
        /// Add deductions to the specified pay run.
        /// </remarks>
        public void CreateDeductions(int businessId, int payRunId, SubmitPayRunDeductionRequest request)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/deductions", request, Method.POST);
        }

        /// <summary>
        /// Create Deductions
        /// </summary>
        /// <remarks>
        /// Add deductions to the specified pay run.
        /// </remarks>
        public Task CreateDeductionsAsync(int businessId, int payRunId, SubmitPayRunDeductionRequest request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/payrun/{payRunId}/deductions", request, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Delete Deduction
        /// </summary>
        /// <remarks>
        /// Deletes the deduction with the specified ID from the pay run.
        /// </remarks>
        public void DeleteDeduction(int businessId, int payRunId, DeleteDeductionQueryModel request)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/deductions?id={request.Id}", Method.DELETE);
        }

        /// <summary>
        /// Delete Deduction
        /// </summary>
        /// <remarks>
        /// Deletes the deduction with the specified ID from the pay run.
        /// </remarks>
        public Task DeleteDeductionAsync(int businessId, int payRunId, DeleteDeductionQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/payrun/{payRunId}/deductions?id={request.Id}", Method.DELETE, cancellationToken);
        }

        /// <summary>
        /// Get Deductions by Employee ID
        /// </summary>
        /// <remarks>
        /// Gets all the deductions for a specific employee in a pay run.
        /// </remarks>
        public SgPayRunDeductionResponse GetDeductionsByEmployeeId(int businessId, int employeeId, int payRunId)
        {
            return ApiRequest<SgPayRunDeductionResponse>($"/business/{businessId}/payrun/{payRunId}/deductions/{employeeId}", Method.GET);
        }

        /// <summary>
        /// Get Deductions by Employee ID
        /// </summary>
        /// <remarks>
        /// Gets all the deductions for a specific employee in a pay run.
        /// </remarks>
        public Task<SgPayRunDeductionResponse> GetDeductionsByEmployeeIdAsync(int businessId, int employeeId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SgPayRunDeductionResponse>($"/business/{businessId}/payrun/{payRunId}/deductions/{employeeId}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// List Earnings Lines
        /// </summary>
        /// <remarks>
        /// Lists all the earnings lines for a pay run.
        /// </remarks>
        public SgPayRunEarningsLineResponseModel ListEarningsLines(int businessId, int payRunId)
        {
            return ApiRequest<SgPayRunEarningsLineResponseModel>($"/business/{businessId}/payrun/{payRunId}/earningslines", Method.GET);
        }

        /// <summary>
        /// List Earnings Lines
        /// </summary>
        /// <remarks>
        /// Lists all the earnings lines for a pay run.
        /// </remarks>
        public Task<SgPayRunEarningsLineResponseModel> ListEarningsLinesAsync(int businessId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SgPayRunEarningsLineResponseModel>($"/business/{businessId}/payrun/{payRunId}/earningslines", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Create Earnings Lines
        /// </summary>
        /// <remarks>
        /// Adds earnings lines to the specified pay run.
        /// </remarks>
        public void CreateEarningsLines(int businessId, int payRunId, SgSubmitPayRunEarningsLineRequest request)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/earningslines", request, Method.POST);
        }

        /// <summary>
        /// Create Earnings Lines
        /// </summary>
        /// <remarks>
        /// Adds earnings lines to the specified pay run.
        /// </remarks>
        public Task CreateEarningsLinesAsync(int businessId, int payRunId, SgSubmitPayRunEarningsLineRequest request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/payrun/{payRunId}/earningslines", request, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Delete Earnings Line
        /// </summary>
        /// <remarks>
        /// Deletes the earnings with the specified ID from the pay run.
        /// </remarks>
        public void DeleteEarningsLine(int businessId, int payRunId, DeleteEarningsLineQueryModel request)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/earningslines?id={request.Id}", Method.DELETE);
        }

        /// <summary>
        /// Delete Earnings Line
        /// </summary>
        /// <remarks>
        /// Deletes the earnings with the specified ID from the pay run.
        /// </remarks>
        public Task DeleteEarningsLineAsync(int businessId, int payRunId, DeleteEarningsLineQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/payrun/{payRunId}/earningslines?id={request.Id}", Method.DELETE, cancellationToken);
        }

        /// <summary>
        /// Get Earnings Lines by Employee ID
        /// </summary>
        /// <remarks>
        /// Gets all the earnings lines for a specific employee in a pay run.
        /// </remarks>
        public SgPayRunEarningsLineResponseModel GetEarningsLinesByEmployeeId(int businessId, int employeeId, int payRunId)
        {
            return ApiRequest<SgPayRunEarningsLineResponseModel>($"/business/{businessId}/payrun/{payRunId}/earningslines/{employeeId}", Method.GET);
        }

        /// <summary>
        /// Get Earnings Lines by Employee ID
        /// </summary>
        /// <remarks>
        /// Gets all the earnings lines for a specific employee in a pay run.
        /// </remarks>
        public Task<SgPayRunEarningsLineResponseModel> GetEarningsLinesByEmployeeIdAsync(int businessId, int employeeId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SgPayRunEarningsLineResponseModel>($"/business/{businessId}/payrun/{payRunId}/earningslines/{employeeId}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Include Employee
        /// </summary>
        /// <remarks>
        /// Includes an employee in a pay run.
        /// </remarks>
        public PayRunTotalModel IncludeEmployee(int businessId, int employeeId, int payRunId)
        {
            return ApiRequest<PayRunTotalModel>($"/business/{businessId}/payrun/{payRunId}/employee/{employeeId}", Method.POST);
        }

        /// <summary>
        /// Include Employee
        /// </summary>
        /// <remarks>
        /// Includes an employee in a pay run.
        /// </remarks>
        public Task<PayRunTotalModel> IncludeEmployeeAsync(int businessId, int employeeId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PayRunTotalModel>($"/business/{businessId}/payrun/{payRunId}/employee/{employeeId}", Method.POST, cancellationToken);
        }

        /// <summary>
        /// Remove Employee from Pay Run
        /// </summary>
        /// <remarks>
        /// Removes an employee from a pay run.
        /// </remarks>
        public void RemoveEmployeeFromPayRun(int businessId, int employeeId, int payRunId)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/employee/{employeeId}", Method.DELETE);
        }

        /// <summary>
        /// Remove Employee from Pay Run
        /// </summary>
        /// <remarks>
        /// Removes an employee from a pay run.
        /// </remarks>
        public Task RemoveEmployeeFromPayRunAsync(int businessId, int employeeId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/payrun/{payRunId}/employee/{employeeId}", Method.DELETE, cancellationToken);
        }

        /// <summary>
        /// List Employee Expenses
        /// </summary>
        /// <remarks>
        /// Lists all the employee expenses for a pay run.
        /// </remarks>
        public PayRunEmployeeExpenseResponse ListEmployeeExpenses(int businessId, int payRunId)
        {
            return ApiRequest<PayRunEmployeeExpenseResponse>($"/business/{businessId}/payrun/{payRunId}/EmployeeExpenses", Method.GET);
        }

        /// <summary>
        /// List Employee Expenses
        /// </summary>
        /// <remarks>
        /// Lists all the employee expenses for a pay run.
        /// </remarks>
        public Task<PayRunEmployeeExpenseResponse> ListEmployeeExpensesAsync(int businessId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PayRunEmployeeExpenseResponse>($"/business/{businessId}/payrun/{payRunId}/EmployeeExpenses", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Create Employee Expenses
        /// </summary>
        /// <remarks>
        /// Add employee expenses to the specified pay run.
        /// </remarks>
        public void CreateEmployeeExpenses(int businessId, int payRunId, SubmitPayRunEmployeeExpenseRequest request)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/EmployeeExpenses", request, Method.POST);
        }

        /// <summary>
        /// Create Employee Expenses
        /// </summary>
        /// <remarks>
        /// Add employee expenses to the specified pay run.
        /// </remarks>
        public Task CreateEmployeeExpensesAsync(int businessId, int payRunId, SubmitPayRunEmployeeExpenseRequest request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/payrun/{payRunId}/EmployeeExpenses", request, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Delete Employee Expense
        /// </summary>
        /// <remarks>
        /// Deletes the employee expense with the specified ID from the pay run.
        /// </remarks>
        public void DeleteEmployeeExpense(int businessId, int payRunId, DeleteEmployeeExpenseQueryModel request)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/EmployeeExpenses?id={request.Id}", Method.DELETE);
        }

        /// <summary>
        /// Delete Employee Expense
        /// </summary>
        /// <remarks>
        /// Deletes the employee expense with the specified ID from the pay run.
        /// </remarks>
        public Task DeleteEmployeeExpenseAsync(int businessId, int payRunId, DeleteEmployeeExpenseQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/payrun/{payRunId}/EmployeeExpenses?id={request.Id}", Method.DELETE, cancellationToken);
        }

        /// <summary>
        /// Get Employee Expenses by Employee ID
        /// </summary>
        /// <remarks>
        /// Gets all the employee expenses for a specific employee in a pay run.
        /// </remarks>
        public PayRunEmployeeExpenseResponse GetEmployeeExpensesByEmployeeId(int businessId, int employeeId, int payRunId)
        {
            return ApiRequest<PayRunEmployeeExpenseResponse>($"/business/{businessId}/payrun/{payRunId}/EmployeeExpenses/{employeeId}", Method.GET);
        }

        /// <summary>
        /// Get Employee Expenses by Employee ID
        /// </summary>
        /// <remarks>
        /// Gets all the employee expenses for a specific employee in a pay run.
        /// </remarks>
        public Task<PayRunEmployeeExpenseResponse> GetEmployeeExpensesByEmployeeIdAsync(int businessId, int employeeId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PayRunEmployeeExpenseResponse>($"/business/{businessId}/payrun/{payRunId}/EmployeeExpenses/{employeeId}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// List Employer Liabilities
        /// </summary>
        /// <remarks>
        /// Lists all the employer liabilities for a pay run.
        /// </remarks>
        public PayRunEmployerLiabilityResponse ListEmployerLiabilities(int businessId, int payRunId)
        {
            return ApiRequest<PayRunEmployerLiabilityResponse>($"/business/{businessId}/payrun/{payRunId}/employerliabilities", Method.GET);
        }

        /// <summary>
        /// List Employer Liabilities
        /// </summary>
        /// <remarks>
        /// Lists all the employer liabilities for a pay run.
        /// </remarks>
        public Task<PayRunEmployerLiabilityResponse> ListEmployerLiabilitiesAsync(int businessId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PayRunEmployerLiabilityResponse>($"/business/{businessId}/payrun/{payRunId}/employerliabilities", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Create Employer Liabilities
        /// </summary>
        /// <remarks>
        /// Add employer liabilities to the specified pay run.
        /// </remarks>
        public void CreateEmployerLiabilities(int businessId, int payRunId, SubmitPayRunEmployerLiabilityRequest request)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/employerliabilities", request, Method.POST);
        }

        /// <summary>
        /// Create Employer Liabilities
        /// </summary>
        /// <remarks>
        /// Add employer liabilities to the specified pay run.
        /// </remarks>
        public Task CreateEmployerLiabilitiesAsync(int businessId, int payRunId, SubmitPayRunEmployerLiabilityRequest request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/payrun/{payRunId}/employerliabilities", request, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Delete Employer Liability
        /// </summary>
        /// <remarks>
        /// Deletes the employer liability with the specified ID from the pay run.
        /// </remarks>
        public void DeleteEmployerLiability(int businessId, int payRunId, DeleteEmployerLiabilityQueryModel request)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/employerliabilities?id={request.Id}", Method.DELETE);
        }

        /// <summary>
        /// Delete Employer Liability
        /// </summary>
        /// <remarks>
        /// Deletes the employer liability with the specified ID from the pay run.
        /// </remarks>
        public Task DeleteEmployerLiabilityAsync(int businessId, int payRunId, DeleteEmployerLiabilityQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/payrun/{payRunId}/employerliabilities?id={request.Id}", Method.DELETE, cancellationToken);
        }

        /// <summary>
        /// Get Employer Liabilities by Employee ID
        /// </summary>
        /// <remarks>
        /// Gets all the employer liabilities for a specific employee in a pay run.
        /// </remarks>
        public PayRunEmployerLiabilityResponse GetEmployerLiabilitiesByEmployeeId(int businessId, int employeeId, int payRunId)
        {
            return ApiRequest<PayRunEmployerLiabilityResponse>($"/business/{businessId}/payrun/{payRunId}/employerliabilities/{employeeId}", Method.GET);
        }

        /// <summary>
        /// Get Employer Liabilities by Employee ID
        /// </summary>
        /// <remarks>
        /// Gets all the employer liabilities for a specific employee in a pay run.
        /// </remarks>
        public Task<PayRunEmployerLiabilityResponse> GetEmployerLiabilitiesByEmployeeIdAsync(int businessId, int employeeId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PayRunEmployerLiabilityResponse>($"/business/{businessId}/payrun/{payRunId}/employerliabilities/{employeeId}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get Giro Bank Payment File
        /// </summary>
        /// <remarks>
        /// Gets a Giro Bank Payment file associated with a pay run.
        /// </remarks>
        public void GetGiroBankPaymentFile(int businessId, int payRunId, int paymentFileId)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/file/bankpayment/{paymentFileId}", Method.GET);
        }

        /// <summary>
        /// Get Giro Bank Payment File
        /// </summary>
        /// <remarks>
        /// Gets a Giro Bank Payment file associated with a pay run.
        /// </remarks>
        public Task GetGiroBankPaymentFileAsync(int businessId, int payRunId, int paymentFileId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/payrun/{payRunId}/file/bankpayment/{paymentFileId}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get Pay Slip File
        /// </summary>
        /// <remarks>
        /// Gets the pay slip for an employee in a pay run.
        /// </remarks>
        public byte[] GetPaySlipFile(int businessId, int employeeId, int payRunId)
        {
            return ApiByteArrayRequest($"/business/{businessId}/payrun/{payRunId}/file/payslip/{employeeId}", Method.GET);
        }

        /// <summary>
        /// Get Pay Slip File
        /// </summary>
        /// <remarks>
        /// Gets the pay slip for an employee in a pay run.
        /// </remarks>
        public Task<byte[]> GetPaySlipFileAsync(int businessId, int employeeId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/business/{businessId}/payrun/{payRunId}/file/payslip/{employeeId}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Finalise Pay Run
        /// </summary>
        /// <remarks>
        /// Finalises the specified pay run. A pay run can only be finalised if there are no calculations in progress.
        /// </remarks>
        public PayRunFinaliseResult FinalisePayRun(int businessId, int payRunId, FinalisePayRunOptions options)
        {
            return ApiRequest<PayRunFinaliseResult,FinalisePayRunOptions>($"/business/{businessId}/payrun/{payRunId}/finalise", options, Method.POST);
        }

        /// <summary>
        /// Finalise Pay Run
        /// </summary>
        /// <remarks>
        /// Finalises the specified pay run. A pay run can only be finalised if there are no calculations in progress.
        /// </remarks>
        public Task<PayRunFinaliseResult> FinalisePayRunAsync(int businessId, int payRunId, FinalisePayRunOptions options, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PayRunFinaliseResult,FinalisePayRunOptions>($"/business/{businessId}/payrun/{payRunId}/finalise", options, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Get Leave Accruals
        /// </summary>
        /// <remarks>
        /// Lists all the leave accruals for the pay run.
        /// </remarks>
        public LeaveAccrualResponse GetLeaveAccruals(int businessId, int payRunId, GetLeaveAccrualsQueryModel request)
        {
            return ApiRequest<LeaveAccrualResponse>($"/business/{businessId}/payrun/{payRunId}/leaveaccrued?includeLeaveTaken={request.IncludeLeaveTaken}", Method.GET);
        }

        /// <summary>
        /// Get Leave Accruals
        /// </summary>
        /// <remarks>
        /// Lists all the leave accruals for the pay run.
        /// </remarks>
        public Task<LeaveAccrualResponse> GetLeaveAccrualsAsync(int businessId, int payRunId, GetLeaveAccrualsQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<LeaveAccrualResponse>($"/business/{businessId}/payrun/{payRunId}/leaveaccrued?includeLeaveTaken={request.IncludeLeaveTaken}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Save Leave Accruals
        /// </summary>
        /// <remarks>
        /// Saves a set of leave accruals for the pay run.
        /// </remarks>
        public void SaveLeaveAccruals(int businessId, int payRunId, SubmitLeaveAccrualsModel model)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/leaveaccrued", model, Method.POST);
        }

        /// <summary>
        /// Save Leave Accruals
        /// </summary>
        /// <remarks>
        /// Saves a set of leave accruals for the pay run.
        /// </remarks>
        public Task SaveLeaveAccrualsAsync(int businessId, int payRunId, SubmitLeaveAccrualsModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/payrun/{payRunId}/leaveaccrued", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Delete Leave Accrual
        /// </summary>
        /// <remarks>
        /// Deletes the manually added leave accrual, leave taken or leave adjustment with the specified ID from the pay run.
        /// </remarks>
        public void DeleteLeaveAccrual(int businessId, int payRunId, DeleteLeaveAccrualQueryModel request)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/leaveaccrued?id={request.Id}", Method.DELETE);
        }

        /// <summary>
        /// Delete Leave Accrual
        /// </summary>
        /// <remarks>
        /// Deletes the manually added leave accrual, leave taken or leave adjustment with the specified ID from the pay run.
        /// </remarks>
        public Task DeleteLeaveAccrualAsync(int businessId, int payRunId, DeleteLeaveAccrualQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/payrun/{payRunId}/leaveaccrued?id={request.Id}", Method.DELETE, cancellationToken);
        }

        /// <summary>
        /// Get Leave Accruals for Employee
        /// </summary>
        /// <remarks>
        /// Gets the leave accruals for the specified employee in the pay run.
        /// </remarks>
        public LeaveAccrualResponse GetLeaveAccrualsForEmployee(int businessId, int employeeId, int payRunId, GetLeaveAccrualsForEmployeeQueryModel request)
        {
            return ApiRequest<LeaveAccrualResponse>($"/business/{businessId}/payrun/{payRunId}/leaveaccrued/{employeeId}?includeLeaveTaken={request.IncludeLeaveTaken}", Method.GET);
        }

        /// <summary>
        /// Get Leave Accruals for Employee
        /// </summary>
        /// <remarks>
        /// Gets the leave accruals for the specified employee in the pay run.
        /// </remarks>
        public Task<LeaveAccrualResponse> GetLeaveAccrualsForEmployeeAsync(int businessId, int employeeId, int payRunId, GetLeaveAccrualsForEmployeeQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<LeaveAccrualResponse>($"/business/{businessId}/payrun/{payRunId}/leaveaccrued/{employeeId}?includeLeaveTaken={request.IncludeLeaveTaken}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Net to Gross
        /// </summary>
        /// <remarks>
        /// Calculates net to gross for a given pay run.
        /// </remarks>
        public NetToGrossModel NetToGross(int businessId, NetToGrossRequest netToGrossRequest, string payRunId)
        {
            return ApiRequest<NetToGrossModel,NetToGrossRequest>($"/business/{businessId}/payrun/{payRunId}/nettogross", netToGrossRequest, Method.POST);
        }

        /// <summary>
        /// Net to Gross
        /// </summary>
        /// <remarks>
        /// Calculates net to gross for a given pay run.
        /// </remarks>
        public Task<NetToGrossModel> NetToGrossAsync(int businessId, NetToGrossRequest netToGrossRequest, string payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NetToGrossModel,NetToGrossRequest>($"/business/{businessId}/payrun/{payRunId}/nettogross", netToGrossRequest, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Set Pay Run Notation
        /// </summary>
        /// <remarks>
        /// Sets the notation for this pay run. The pay run notation is the message that is shown on all pay slips for this pay run.
        /// </remarks>
        public void SetPayRunNotation(int businessId, int payRunId, PayRunNotationModel model)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/notation", model, Method.POST);
        }

        /// <summary>
        /// Set Pay Run Notation
        /// </summary>
        /// <remarks>
        /// Sets the notation for this pay run. The pay run notation is the message that is shown on all pay slips for this pay run.
        /// </remarks>
        public Task SetPayRunNotationAsync(int businessId, int payRunId, PayRunNotationModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/payrun/{payRunId}/notation", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Delete Pay Run Notation
        /// </summary>
        /// <remarks>
        /// Deletes the notation for this pay run. The pay run notation is the message that is shown on all pay slips for this pay run.
        /// </remarks>
        public void DeletePayRunNotation(int businessId, int payRunId)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/notation", Method.DELETE);
        }

        /// <summary>
        /// Delete Pay Run Notation
        /// </summary>
        /// <remarks>
        /// Deletes the notation for this pay run. The pay run notation is the message that is shown on all pay slips for this pay run.
        /// </remarks>
        public Task DeletePayRunNotationAsync(int businessId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/payrun/{payRunId}/notation", Method.DELETE, cancellationToken);
        }

        /// <summary>
        /// Create Note for Employee
        /// </summary>
        /// <remarks>
        /// Creates a note for an employee record in a pay run.
        /// </remarks>
        public void CreateNoteForEmployee(int businessId, int employeeId, int payRunId, PayRunTotalNotationModel model)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/notation/{employeeId}", model, Method.POST);
        }

        /// <summary>
        /// Create Note for Employee
        /// </summary>
        /// <remarks>
        /// Creates a note for an employee record in a pay run.
        /// </remarks>
        public Task CreateNoteForEmployeeAsync(int businessId, int employeeId, int payRunId, PayRunTotalNotationModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/payrun/{payRunId}/notation/{employeeId}", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Delete Note for Employee
        /// </summary>
        /// <remarks>
        /// Deletes the note for an employee record in a pay run.
        /// </remarks>
        public void DeleteNoteForEmployee(int businessId, int employeeId, int payRunId)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/notation/{employeeId}", Method.DELETE);
        }

        /// <summary>
        /// Delete Note for Employee
        /// </summary>
        /// <remarks>
        /// Deletes the note for an employee record in a pay run.
        /// </remarks>
        public Task DeleteNoteForEmployeeAsync(int businessId, int employeeId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/payrun/{payRunId}/notation/{employeeId}", Method.DELETE, cancellationToken);
        }

        /// <summary>
        /// Get pay run payments
        /// </summary>
        /// <remarks>
        /// Gets the payments associated with a pay run.
        /// </remarks>
        public List<SgBankPaymentModel> GetPayRunPayments(int businessId, int payRunId)
        {
            return ApiRequest<List<SgBankPaymentModel>>($"/business/{businessId}/payrun/{payRunId}/payments", Method.GET);
        }

        /// <summary>
        /// Get pay run payments
        /// </summary>
        /// <remarks>
        /// Gets the payments associated with a pay run.
        /// </remarks>
        public Task<List<SgBankPaymentModel>> GetPayRunPaymentsAsync(int businessId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SgBankPaymentModel>>($"/business/{businessId}/payrun/{payRunId}/payments", Method.GET, cancellationToken);
        }

        /// <summary>
        /// List Pay Slip Data
        /// </summary>
        /// <remarks>
        /// Lists all the pay slips for the specified pay run.
        /// </remarks>
        public Dictionary<String,SgApiPaySlipModel> ListPaySlipData(int businessId, int payRunId, ListPaySlipDataQueryModel request)
        {
            return ApiRequest<Dictionary<String,SgApiPaySlipModel>>($"/business/{businessId}/payrun/{payRunId}/payslips?showAllData={request.ShowAllData}", Method.GET);
        }

        /// <summary>
        /// List Pay Slip Data
        /// </summary>
        /// <remarks>
        /// Lists all the pay slips for the specified pay run.
        /// </remarks>
        public Task<Dictionary<String,SgApiPaySlipModel>> ListPaySlipDataAsync(int businessId, int payRunId, ListPaySlipDataQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<Dictionary<String,SgApiPaySlipModel>>($"/business/{businessId}/payrun/{payRunId}/payslips?showAllData={request.ShowAllData}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get Pay Slip Data by Employee ID
        /// </summary>
        /// <remarks>
        /// Gets the pay slip data for an employee in a payrun.
        /// </remarks>
        public SgApiPaySlipModel GetPaySlipDataByEmployeeId(int businessId, int employeeId, int payRunId, GetPaySlipDataByEmployeeIdQueryModel request)
        {
            return ApiRequest<SgApiPaySlipModel>($"/business/{businessId}/payrun/{payRunId}/payslips/{employeeId}?showAllData={request.ShowAllData}", Method.GET);
        }

        /// <summary>
        /// Get Pay Slip Data by Employee ID
        /// </summary>
        /// <remarks>
        /// Gets the pay slip data for an employee in a payrun.
        /// </remarks>
        public Task<SgApiPaySlipModel> GetPaySlipDataByEmployeeIdAsync(int businessId, int employeeId, int payRunId, GetPaySlipDataByEmployeeIdQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SgApiPaySlipModel>($"/business/{businessId}/payrun/{payRunId}/payslips/{employeeId}?showAllData={request.ShowAllData}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Recalculate
        /// </summary>
        /// <remarks>
        /// Recalculates a pay run.
        /// </remarks>
        public void Recalculate(int businessId, int payRunId)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/recalculate", Method.POST);
        }

        /// <summary>
        /// Recalculate
        /// </summary>
        /// <remarks>
        /// Recalculates a pay run.
        /// </remarks>
        public Task RecalculateAsync(int businessId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/payrun/{payRunId}/recalculate", Method.POST, cancellationToken);
        }

        /// <summary>
        /// Set UI Unlock enabled
        /// </summary>
        /// <remarks>
        /// Sets whether a pay run can be unlocked by the UI or not. Only applies to finalized pay runs.
        /// </remarks>
        public void SetUiUnlockEnabled(int businessId, int payRunId, SetPayRunUIUnlockStateRequest request)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/setuiunlockstate", request, Method.POST);
        }

        /// <summary>
        /// Set UI Unlock enabled
        /// </summary>
        /// <remarks>
        /// Sets whether a pay run can be unlocked by the UI or not. Only applies to finalized pay runs.
        /// </remarks>
        public Task SetUiUnlockEnabledAsync(int businessId, int payRunId, SetPayRunUIUnlockStateRequest request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/payrun/{payRunId}/setuiunlockstate", request, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Get Pay Run Summary
        /// </summary>
        /// <remarks>
        /// Gets the pay run summary information with the specified ID.
        /// </remarks>
        public PayRunSummaryModel GetPayRunSummary(int businessId, int payRunId)
        {
            return ApiRequest<PayRunSummaryModel>($"/business/{businessId}/payrun/{payRunId}/summary", Method.GET);
        }

        /// <summary>
        /// Get Pay Run Summary
        /// </summary>
        /// <remarks>
        /// Gets the pay run summary information with the specified ID.
        /// </remarks>
        public Task<PayRunSummaryModel> GetPayRunSummaryAsync(int businessId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PayRunSummaryModel>($"/business/{businessId}/payrun/{payRunId}/summary", Method.GET, cancellationToken);
        }

        /// <summary>
        /// List withholding and clearance tax adjustments
        /// </summary>
        /// <remarks>
        /// Lists all the withholding and clearance tax adjustments for a pay run.
        /// </remarks>
        public PayRunForeignTaxAdjustmentResponse ListWithholdingAndClearanceTaxAdjustments(int businessId, int payRunId)
        {
            return ApiRequest<PayRunForeignTaxAdjustmentResponse>($"/business/{businessId}/payrun/{payRunId}/taxadjustments", Method.GET);
        }

        /// <summary>
        /// List withholding and clearance tax adjustments
        /// </summary>
        /// <remarks>
        /// Lists all the withholding and clearance tax adjustments for a pay run.
        /// </remarks>
        public Task<PayRunForeignTaxAdjustmentResponse> ListWithholdingAndClearanceTaxAdjustmentsAsync(int businessId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PayRunForeignTaxAdjustmentResponse>($"/business/{businessId}/payrun/{payRunId}/taxadjustments", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Create a withholding or clearance tax adjustment
        /// </summary>
        /// <remarks>
        /// Adds a withholding or clearance tax adjustment to the specified pay run.
        /// </remarks>
        public void CreateAWithholdingOrClearanceTaxAdjustment(int businessId, int payRunId, SubmitPayRunForeignTaxAdjustmentRequest request)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/taxadjustments", request, Method.POST);
        }

        /// <summary>
        /// Create a withholding or clearance tax adjustment
        /// </summary>
        /// <remarks>
        /// Adds a withholding or clearance tax adjustment to the specified pay run.
        /// </remarks>
        public Task CreateAWithholdingOrClearanceTaxAdjustmentAsync(int businessId, int payRunId, SubmitPayRunForeignTaxAdjustmentRequest request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/payrun/{payRunId}/taxadjustments", request, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Delete a withholding or clearance tax adjustment
        /// </summary>
        /// <remarks>
        /// Deletes a withholding or clearance tax adjustment with the specified ID from the pay run.
        /// </remarks>
        public void DeleteAWithholdingOrClearanceTaxAdjustment(int businessId, int payRunId, DeleteAWithholdingOrClearanceTaxAdjustmentQueryModel request)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/taxadjustments?id={request.Id}", Method.DELETE);
        }

        /// <summary>
        /// Delete a withholding or clearance tax adjustment
        /// </summary>
        /// <remarks>
        /// Deletes a withholding or clearance tax adjustment with the specified ID from the pay run.
        /// </remarks>
        public Task DeleteAWithholdingOrClearanceTaxAdjustmentAsync(int businessId, int payRunId, DeleteAWithholdingOrClearanceTaxAdjustmentQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/payrun/{payRunId}/taxadjustments?id={request.Id}", Method.DELETE, cancellationToken);
        }

        /// <summary>
        /// Get withholding and clearance tax adjustments by Employee ID
        /// </summary>
        /// <remarks>
        /// Gets all withholding and clearance tax adjustments for a specific employee in a pay run.
        /// </remarks>
        public PayRunForeignTaxAdjustmentResponse GetWithholdingAndClearanceTaxAdjustmentsByEmployeeId(int businessId, int employeeId, int payRunId)
        {
            return ApiRequest<PayRunForeignTaxAdjustmentResponse>($"/business/{businessId}/payrun/{payRunId}/taxadjustments/{employeeId}", Method.GET);
        }

        /// <summary>
        /// Get withholding and clearance tax adjustments by Employee ID
        /// </summary>
        /// <remarks>
        /// Gets all withholding and clearance tax adjustments for a specific employee in a pay run.
        /// </remarks>
        public Task<PayRunForeignTaxAdjustmentResponse> GetWithholdingAndClearanceTaxAdjustmentsByEmployeeIdAsync(int businessId, int employeeId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PayRunForeignTaxAdjustmentResponse>($"/business/{businessId}/payrun/{payRunId}/taxadjustments/{employeeId}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Terminate Employee in Pay Run
        /// </summary>
        /// <remarks>
        /// Terminates an employee in the specified pay run.
        /// </remarks>
        public void TerminateEmployeeInPayRun(int businessId, int payRunId, TerminateEmployeeRequest request)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/terminate", request, Method.POST);
        }

        /// <summary>
        /// Terminate Employee in Pay Run
        /// </summary>
        /// <remarks>
        /// Terminates an employee in the specified pay run.
        /// </remarks>
        public Task TerminateEmployeeInPayRunAsync(int businessId, int payRunId, TerminateEmployeeRequest request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/payrun/{payRunId}/terminate", request, Method.POST, cancellationToken);
        }

        /// <summary>
        /// List Pay Run Totals
        /// </summary>
        /// <remarks>
        /// Lists all of the pay run totals in a pay run.
        /// </remarks>
        public SgPayRunTotalResponse ListPayRunTotals(int businessId, int payRunId)
        {
            return ApiRequest<SgPayRunTotalResponse>($"/business/{businessId}/payrun/{payRunId}/totals", Method.GET);
        }

        /// <summary>
        /// List Pay Run Totals
        /// </summary>
        /// <remarks>
        /// Lists all of the pay run totals in a pay run.
        /// </remarks>
        public Task<SgPayRunTotalResponse> ListPayRunTotalsAsync(int businessId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SgPayRunTotalResponse>($"/business/{businessId}/payrun/{payRunId}/totals", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get Pay Run Totals by Employee ID
        /// </summary>
        /// <remarks>
        /// Gets the pay run totals for a specific employee in a pay run.
        /// </remarks>
        public SgPayRunTotalResponse GetPayRunTotalsByEmployeeId(int businessId, int employeeId, int payRunId)
        {
            return ApiRequest<SgPayRunTotalResponse>($"/business/{businessId}/payrun/{payRunId}/totals/{employeeId}", Method.GET);
        }

        /// <summary>
        /// Get Pay Run Totals by Employee ID
        /// </summary>
        /// <remarks>
        /// Gets the pay run totals for a specific employee in a pay run.
        /// </remarks>
        public Task<SgPayRunTotalResponse> GetPayRunTotalsByEmployeeIdAsync(int businessId, int employeeId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SgPayRunTotalResponse>($"/business/{businessId}/payrun/{payRunId}/totals/{employeeId}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Unlock Pay Run
        /// </summary>
        /// <remarks>
        /// Unlocks the specified pay run.
        /// </remarks>
        public void UnlockPayRun(int businessId, int payRunId, PayRunUnlockRequest request)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/unlock", request, Method.POST);
        }

        /// <summary>
        /// Unlock Pay Run
        /// </summary>
        /// <remarks>
        /// Unlocks the specified pay run.
        /// </remarks>
        public Task UnlockPayRunAsync(int businessId, int payRunId, PayRunUnlockRequest request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/payrun/{payRunId}/unlock", request, Method.POST, cancellationToken);
        }

        /// <summary>
        /// List voluntary CPF contributions
        /// </summary>
        /// <remarks>
        /// Lists all the voluntary CPF contributions for a pay run.
        /// </remarks>
        public PayRunCpfAdjustmentResponse ListVoluntaryCpfContributions(int businessId, int payRunId)
        {
            return ApiRequest<PayRunCpfAdjustmentResponse>($"/business/{businessId}/payrun/{payRunId}/voluntarycpf", Method.GET);
        }

        /// <summary>
        /// List voluntary CPF contributions
        /// </summary>
        /// <remarks>
        /// Lists all the voluntary CPF contributions for a pay run.
        /// </remarks>
        public Task<PayRunCpfAdjustmentResponse> ListVoluntaryCpfContributionsAsync(int businessId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PayRunCpfAdjustmentResponse>($"/business/{businessId}/payrun/{payRunId}/voluntarycpf", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Create voluntary CPF contributions
        /// </summary>
        /// <remarks>
        /// Adds voluntary CPF contributions to the specified pay run.
        /// </remarks>
        public void CreateVoluntaryCpfContributions(int businessId, int payRunId, SubmitPayRunCpfAdjustmentRequest request)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/voluntarycpf", request, Method.POST);
        }

        /// <summary>
        /// Create voluntary CPF contributions
        /// </summary>
        /// <remarks>
        /// Adds voluntary CPF contributions to the specified pay run.
        /// </remarks>
        public Task CreateVoluntaryCpfContributionsAsync(int businessId, int payRunId, SubmitPayRunCpfAdjustmentRequest request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/payrun/{payRunId}/voluntarycpf", request, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Delete voluntary CPF contribution
        /// </summary>
        /// <remarks>
        /// Deletes the voluntary CPF contribution with the specified ID from the pay run.
        /// </remarks>
        public void DeleteVoluntaryCpfContribution(int businessId, int payRunId, DeleteVoluntaryCpfContributionQueryModel request)
        {
            ApiRequest($"/business/{businessId}/payrun/{payRunId}/voluntarycpf?id={request.Id}", Method.DELETE);
        }

        /// <summary>
        /// Delete voluntary CPF contribution
        /// </summary>
        /// <remarks>
        /// Deletes the voluntary CPF contribution with the specified ID from the pay run.
        /// </remarks>
        public Task DeleteVoluntaryCpfContributionAsync(int businessId, int payRunId, DeleteVoluntaryCpfContributionQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/payrun/{payRunId}/voluntarycpf?id={request.Id}", Method.DELETE, cancellationToken);
        }

        /// <summary>
        /// Get voluntary CPF contributions by Employee ID
        /// </summary>
        /// <remarks>
        /// Gets all voluntary CPF contributions for a specific employee in a pay run.
        /// </remarks>
        public PayRunCpfAdjustmentResponse GetVoluntaryCpfContributionsByEmployeeId(int businessId, int employeeId, int payRunId)
        {
            return ApiRequest<PayRunCpfAdjustmentResponse>($"/business/{businessId}/payrun/{payRunId}/voluntarycpf/{employeeId}", Method.GET);
        }

        /// <summary>
        /// Get voluntary CPF contributions by Employee ID
        /// </summary>
        /// <remarks>
        /// Gets all voluntary CPF contributions for a specific employee in a pay run.
        /// </remarks>
        public Task<PayRunCpfAdjustmentResponse> GetVoluntaryCpfContributionsByEmployeeIdAsync(int businessId, int employeeId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PayRunCpfAdjustmentResponse>($"/business/{businessId}/payrun/{payRunId}/voluntarycpf/{employeeId}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Create Pay Run (Async)
        /// </summary>
        /// <remarks>
        /// Creates a new pay run for this business asynchronously (the request will return before the pay run is created).
        /// </remarks>
        public PayRunJobModel CreatePayRunAsync(int businessId, PayRunCreateRequest request)
        {
            return ApiRequest<PayRunJobModel,PayRunCreateRequest>($"/business/{businessId}/payrun/async", request, Method.POST);
        }

        /// <summary>
        /// Create Pay Run (Async)
        /// </summary>
        /// <remarks>
        /// Creates a new pay run for this business asynchronously (the request will return before the pay run is created).
        /// </remarks>
        public Task<PayRunJobModel> CreatePayRunAsynchronouslyAsync(int businessId, PayRunCreateRequest request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PayRunJobModel,PayRunCreateRequest>($"/business/{businessId}/payrun/async", request, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Get Creation Status
        /// </summary>
        /// <remarks>
        /// Gets the creation status of a pay run that was created asynchronously.
        /// </remarks>
        public PayRunJobStatusModel GetCreationStatus(int businessId, Guid jobId)
        {
            return ApiRequest<PayRunJobStatusModel>($"/business/{businessId}/payrun/creationstatus/{jobId}", Method.GET);
        }

        /// <summary>
        /// Get Creation Status
        /// </summary>
        /// <remarks>
        /// Gets the creation status of a pay run that was created asynchronously.
        /// </remarks>
        public Task<PayRunJobStatusModel> GetCreationStatusAsync(int businessId, Guid jobId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PayRunJobStatusModel>($"/business/{businessId}/payrun/creationstatus/{jobId}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// List Pay Runs Summaries
        /// </summary>
        /// <remarks>
        /// Get a list of pay run summaries associated with the business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<PayRunSummaryModel> ListPayRunsSummaries(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<PayRunSummaryModel>>($"/business/{businessId}/payrun/summary{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.GET);
        }

        /// <summary>
        /// List Pay Runs Summaries
        /// </summary>
        /// <remarks>
        /// Get a list of pay run summaries associated with the business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<PayRunSummaryModel>> ListPayRunsSummariesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<PayRunSummaryModel>>($"/business/{businessId}/payrun/summary{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.GET, cancellationToken);
        }
    }
}
