namespace DXMVVMSampleWinForms.Views
{
	partial class TrackView
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
			this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
			this.txtComposer = new DevExpress.XtraEditors.TextEdit();
			this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
			this.cbxAlbum = new DevExpress.XtraEditors.LookUpEdit();
			this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
			this.bar2 = new DevExpress.XtraBars.Bar();
			this.btnClear = new DevExpress.XtraBars.BarButtonItem();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.txtName = new DevExpress.XtraEditors.TextEdit();
			this.spnLength = new DevExpress.XtraEditors.SpinEdit();
			this.spnBytes = new DevExpress.XtraEditors.SpinEdit();
			this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtComposer.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
			this.layoutControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cbxAlbum.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.spnLength.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.spnBytes.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			this.SuspendLayout();
			// 
			// repositoryItemLookUpEdit1
			// 
			this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repositoryItemLookUpEdit1.DisplayMember = "Value";
			this.repositoryItemLookUpEdit1.KeyMember = "Key";
			this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
			this.repositoryItemLookUpEdit1.ValueMember = "Value";
			// 
			// mvvmContext1
			// 
			this.mvvmContext1.ContainerControl = this;
			this.mvvmContext1.RegistrationExpressions.AddRange(new DevExpress.Utils.MVVM.RegistrationExpression[] {
            DevExpress.Utils.MVVM.RegistrationExpression.RegisterMessageBoxService(null, false, DevExpress.Utils.MVVM.Services.DefaultMessageBoxServiceType.Default)});
			this.mvvmContext1.ViewModelType = typeof(DXMVVMSampleWinForms.ViewModels.TrackViewModel);
			// 
			// txtComposer
			// 
			this.txtComposer.Location = new System.Drawing.Point(63, 60);
			this.txtComposer.Name = "txtComposer";
			this.txtComposer.Size = new System.Drawing.Size(530, 20);
			this.txtComposer.StyleController = this.layoutControl2;
			this.txtComposer.TabIndex = 6;
			// 
			// layoutControl2
			// 
			this.layoutControl2.Controls.Add(this.cbxAlbum);
			this.layoutControl2.Controls.Add(this.txtName);
			this.layoutControl2.Controls.Add(this.txtComposer);
			this.layoutControl2.Controls.Add(this.spnLength);
			this.layoutControl2.Controls.Add(this.spnBytes);
			this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl2.Location = new System.Drawing.Point(0, 22);
			this.layoutControl2.Name = "layoutControl2";
			this.layoutControl2.Root = this.layoutControlGroup2;
			this.layoutControl2.Size = new System.Drawing.Size(605, 291);
			this.layoutControl2.TabIndex = 1;
			this.layoutControl2.Text = "layoutControl2";
			// 
			// cbxAlbum
			// 
			this.cbxAlbum.Location = new System.Drawing.Point(63, 36);
			this.cbxAlbum.MenuManager = this.barManager1;
			this.cbxAlbum.Name = "cbxAlbum";
			this.cbxAlbum.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", 200, "Album")});
			this.cbxAlbum.Properties.DisplayMember = "Value";
			this.cbxAlbum.Properties.ValueMember = "Key";
			this.cbxAlbum.Size = new System.Drawing.Size(530, 20);
			this.cbxAlbum.StyleController = this.layoutControl2;
			this.cbxAlbum.TabIndex = 9;
			// 
			// barManager1
			// 
			this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
			this.barManager1.DockControls.Add(this.barDockControlTop);
			this.barManager1.DockControls.Add(this.barDockControlBottom);
			this.barManager1.DockControls.Add(this.barDockControlLeft);
			this.barManager1.DockControls.Add(this.barDockControlRight);
			this.barManager1.Form = this;
			this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnClear});
			this.barManager1.MainMenu = this.bar2;
			this.barManager1.MaxItemId = 1;
			// 
			// bar2
			// 
			this.bar2.BarName = "Main menu";
			this.bar2.DockCol = 0;
			this.bar2.DockRow = 0;
			this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnClear)});
			this.bar2.OptionsBar.MultiLine = true;
			this.bar2.OptionsBar.UseWholeRow = true;
			this.bar2.Text = "Main menu";
			// 
			// btnClear
			// 
			this.btnClear.Caption = "Clear Name";
			this.btnClear.Id = 0;
			this.btnClear.Name = "btnClear";
			// 
			// barDockControlTop
			// 
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
			this.barDockControlTop.Manager = this.barManager1;
			this.barDockControlTop.Size = new System.Drawing.Size(605, 22);
			// 
			// barDockControlBottom
			// 
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 313);
			this.barDockControlBottom.Manager = this.barManager1;
			this.barDockControlBottom.Size = new System.Drawing.Size(605, 0);
			// 
			// barDockControlLeft
			// 
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 22);
			this.barDockControlLeft.Manager = this.barManager1;
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 291);
			// 
			// barDockControlRight
			// 
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(605, 22);
			this.barDockControlRight.Manager = this.barManager1;
			this.barDockControlRight.Size = new System.Drawing.Size(0, 291);
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(63, 12);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(530, 20);
			this.txtName.StyleController = this.layoutControl2;
			this.txtName.TabIndex = 4;
			// 
			// spnLength
			// 
			this.spnLength.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.spnLength.Location = new System.Drawing.Point(63, 84);
			this.spnLength.Name = "spnLength";
			this.spnLength.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.spnLength.Size = new System.Drawing.Size(530, 20);
			this.spnLength.StyleController = this.layoutControl2;
			this.spnLength.TabIndex = 7;
			// 
			// spnBytes
			// 
			this.spnBytes.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.spnBytes.Location = new System.Drawing.Point(63, 108);
			this.spnBytes.Name = "spnBytes";
			this.spnBytes.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.spnBytes.Size = new System.Drawing.Size(530, 20);
			this.spnBytes.StyleController = this.layoutControl2;
			this.spnBytes.TabIndex = 8;
			// 
			// layoutControlGroup2
			// 
			this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup2.GroupBordersVisible = false;
			this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem2});
			this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup2.Name = "Root";
			this.layoutControlGroup2.Size = new System.Drawing.Size(605, 291);
			this.layoutControlGroup2.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.txtName;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(585, 24);
			this.layoutControlItem1.Text = "Name";
			this.layoutControlItem1.TextSize = new System.Drawing.Size(48, 13);
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.txtComposer;
			this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(585, 24);
			this.layoutControlItem3.Text = "Composer";
			this.layoutControlItem3.TextSize = new System.Drawing.Size(48, 13);
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.Control = this.spnLength;
			this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(585, 24);
			this.layoutControlItem4.Text = "Length";
			this.layoutControlItem4.TextSize = new System.Drawing.Size(48, 13);
			// 
			// layoutControlItem5
			// 
			this.layoutControlItem5.Control = this.spnBytes;
			this.layoutControlItem5.Location = new System.Drawing.Point(0, 96);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Size = new System.Drawing.Size(585, 175);
			this.layoutControlItem5.Text = "Bytes";
			this.layoutControlItem5.TextSize = new System.Drawing.Size(48, 13);
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.cbxAlbum;
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(585, 24);
			this.layoutControlItem2.Text = "Album";
			this.layoutControlItem2.TextSize = new System.Drawing.Size(48, 13);
			// 
			// TrackView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.layoutControl2);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Name = "TrackView";
			this.Size = new System.Drawing.Size(605, 313);
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtComposer.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
			this.layoutControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cbxAlbum.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.spnLength.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.spnBytes.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

		private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
		private DevExpress.XtraLayout.LayoutControl layoutControl2;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
		private DevExpress.XtraEditors.TextEdit txtName;
		private DevExpress.XtraEditors.TextEdit txtComposer;
		private DevExpress.XtraEditors.SpinEdit spnLength;
		private DevExpress.XtraEditors.SpinEdit spnBytes;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarManager barManager1;
		private DevExpress.XtraBars.Bar bar2;
		private DevExpress.XtraBars.BarButtonItem btnClear;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraEditors.LookUpEdit cbxAlbum;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
	}
}
