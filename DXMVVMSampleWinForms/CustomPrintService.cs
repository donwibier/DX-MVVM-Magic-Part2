using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.ReportGeneration;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXMVVMSampleWinForms
{
	public interface ICustomReportService {
		void ShowReport();
	}

	public class CustomReportService : ICustomReportService
	{
		GridView gridView;
		public CustomReportService(GridView gridView)
		{
			this.gridView = gridView;
		}
		public void ShowReport()
		{
			XtraReport report = ReportGenerator.GenerateReport(gridView);
			using (ReportPrintTool printTool = new ReportPrintTool(report))
			{
				printTool.ShowRibbonPreviewDialog();
			}
		}

	}
}
