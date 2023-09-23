using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using TrainingManagment.Domain.Models;
using TrainingManagment.Repository.Interfaces;
using Microsoft.VisualBasic;
using AspNetCore.Reporting;
namespace TrainingManagement.Presentation.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ReportApiController : ControllerBase
    {

        private readonly ILogger<ReportApiController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public ReportApiController(ILogger<ReportApiController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        [Route("/Report")]
        public async Task<IActionResult> Report()
        {
            DataTable ReportDataTable = new DataTable();

            ReportDataTable.Columns.Add("SessionId", typeof(int));
            ReportDataTable.Columns.Add("StartDate", typeof(string));
            ReportDataTable.Columns.Add("ExpectedEndDate", typeof(string));
            ReportDataTable.Columns.Add("AcctualEndDate", typeof(string));
            ReportDataTable.Columns.Add("Year", typeof(string));
            ReportDataTable.Columns.Add("TraineeName", typeof(string));
            ReportDataTable.Columns.Add("TrainingResult", typeof(string));
            ReportDataTable.Columns.Add("TrainingTopic", typeof(string));
            ReportDataTable.Columns.Add("TrainingType", typeof(string));
            ReportDataTable.Columns.Add("TrainingStatus", typeof(string));
            ReportDataTable.Columns.Add("TrainerName", typeof(string));
            ReportDataTable.Columns.Add("FinalPresintationDate", typeof(string));
            ReportDataTable.Columns.Add("EvaluationScore", typeof(double));
            ReportDataTable.Columns.Add("Comments", typeof(string));
            IEnumerable<Session> sessions = await _unitOfWork.Sessions.FindAllAsync(s => s.IsActive == true && s.IsDeleted == false, new[] { "TrainerName", "TrainingType", "TrainingTopic", "TrainingStatus" });

            foreach (Session session in sessions)
            {
                ReportDataTable.Rows.Add(session.SessionId, session.StartDate.Date.ToString(), session.ExpectedEndDate.Date.ToString(), session.ActualEndDate.ToString(),
                    session.Year, session.TraineeName, session.TrainingResult?.NameEn, session.TrainingTopic.NameEn,
                    session.TrainingType.NameEn, session.TrainingStatus.NameEn, session.TrainerName.NameEn,
                    session.FinalPresentationDate.ToString(), session.EvaluationScore, session.Comment);
            }

            var path = "C:\\Users\\AMCT\\source\\repos\\TrainingManagement\\TrainingManagement.Report\\Report\\Report.rdlc";

            Dictionary<string, string> parameters = new Dictionary<string, string>();

            LocalReport lr = new LocalReport(path);
            lr.AddDataSource("SessionDS", ReportDataTable);

            Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            var result = lr.Execute(RenderType.Excel, 1, parameters, "");

            return new FileContentResult(result.MainStream, "application/vnd.ms-excel");

            //return new FileContentResult(result.MainStream, "application/pdf");
            //{
            //    FileDownloadName = "Sessions Report"
            //};
        }
    }
}
