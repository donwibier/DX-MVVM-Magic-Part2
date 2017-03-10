namespace DXMVVMSampleWinForms.Views
{
	partial class NavigationItemView
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
			this.SuspendLayout();
			// 
			// mvvmContext1
			// 
			this.mvvmContext1.ContainerControl = this;
			this.mvvmContext1.ViewModelType = typeof(DXMVVMSampleWinForms.ViewModels.NavigationItemViewModel);
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(34, 59);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(63, 13);
			this.labelControl1.TabIndex = 0;
			this.labelControl1.Text = "labelControl1";
			// 
			// NavigationItemView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.labelControl1);
			this.Name = "NavigationItemView";
			((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

		private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
		private DevExpress.XtraEditors.LabelControl labelControl1;
	}
}
