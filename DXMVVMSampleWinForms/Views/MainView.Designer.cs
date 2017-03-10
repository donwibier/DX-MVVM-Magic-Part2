namespace DXMVVMSampleWinForms.Views
{
	partial class MainView
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
			this.tileBar1 = new DevExpress.XtraBars.Navigation.TileBar();
			this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
			this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
			this.SuspendLayout();
			// 
			// tileBar1
			// 
			this.tileBar1.AllowDrag = false;
			this.tileBar1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tileBar1.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
			this.tileBar1.Location = new System.Drawing.Point(0, 0);
			this.tileBar1.Name = "tileBar1";
			this.tileBar1.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
			this.tileBar1.Size = new System.Drawing.Size(496, 72);
			this.tileBar1.TabIndex = 0;
			this.tileBar1.Text = "tileBar1";
			// 
			// xtraTabControl1
			// 
			this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.xtraTabControl1.Location = new System.Drawing.Point(0, 72);
			this.xtraTabControl1.Name = "xtraTabControl1";
			this.xtraTabControl1.Size = new System.Drawing.Size(496, 279);
			this.xtraTabControl1.TabIndex = 1;
			// 
			// mvvmContext1
			// 
			this.mvvmContext1.ContainerControl = this;
			// 
			// MainView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.xtraTabControl1);
			this.Controls.Add(this.tileBar1);
			this.Name = "MainView";
			this.Size = new System.Drawing.Size(496, 351);
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraBars.Navigation.TileBar tileBar1;
		private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
		private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
	}
}
