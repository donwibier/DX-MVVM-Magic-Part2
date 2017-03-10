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
	public partial class NavigationItemView : DevExpress.XtraEditors.XtraUserControl
	{
		public NavigationItemView()
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

			var f = mvvmContext1.OfType<NavigationItemViewModel>();

			f.SetBinding(labelControl1, x => x.Text, x => x.Title);
		}
	}
}
