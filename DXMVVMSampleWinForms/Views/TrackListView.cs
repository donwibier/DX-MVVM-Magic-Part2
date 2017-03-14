using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DXMVVMSampleWinForms.ViewModels;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils.MVVM.Services;

namespace DXMVVMSampleWinForms.Views
{
	public partial class TrackListView : DevExpress.XtraEditors.XtraUserControl
	{
		public TrackListView()
		{
			InitializeComponent();
			if (!DesignMode)
				InitBindings();
		}

		void InitBindings()
		{			
			mvvmContext1.RegisterService(DialogService.CreateXtraDialogService(this, "Details"));
			mvvmContext1.RegisterService(DispatcherService.Create());

			var mvvm = mvvmContext1.OfType<TrackListViewModel>();
			
			mvvm.SetBinding(gridView1, x => x.LoadingPanelVisible, x => x.IsLoading);

			mvvm.WithEvent<EventArgs>(this, "Load").EventToCommand(x => x.LoadTracks());	
					
			mvvm.WithEvent<ColumnView, FocusedRowObjectChangedEventArgs>(gridView1, "FocusedRowObjectChanged")
				.SetBinding(x => x.CurrentItem,
					args => args.Row as TrackViewModel,
					(gView, track) => gView.FocusedRowHandle = gView.FindRow(track));

			mvvm.WithEvent<RowClickEventArgs>(gridView1, "RowClick")
			   .EventToCommand(
				   x => x.EditItem(null), x => x.CurrentItem,
				   args => (args.Clicks == 2) && (args.Button == MouseButtons.Left));

			mvvmContext1.RegisterService(new CustomReportService(gridView1));
			mvvm.BindCommand(barButtonItem1, x => x.ShowReport());
		}
	}
}
