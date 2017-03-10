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

namespace DXMVVMSampleWinForms.Views
{
	public partial class TrackView : DevExpress.XtraEditors.XtraUserControl
	{
		public TrackView()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			if (!DesignMode)
				InitBindings();
		}
		void InitBindings()
		{
			
			
			//var f = mvvmContext1.OfType<TrackViewModel>();			


			//f.SetBinding(txtName, x => x.EditValue, x => x.Name);
			//f.SetBinding(cbxAlbum, x => x.EditValue, x => x.AlbumId);
			//f.SetBinding(cbxAlbum, x => x.Properties.DataSource, x => x.AlbumLookupData);
			//f.SetBinding(txtComposer, x => x.EditValue, x => x.Composer);
			//f.SetBinding(spnLength, x => x.EditValue, x => x.Milliseconds);
			//f.SetBinding(spnBytes, x => x.EditValue, x => x.Bytes);
			//f.BindCommand(btnClear, x => x.ResetName());
		}
	}
}
