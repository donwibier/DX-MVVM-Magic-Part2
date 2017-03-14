namespace DXMVVMSampleWinForms.Views
{
	partial class TrackListView
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
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridColumnId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumnAlbum = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumnMediaType = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumnGenre = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumnComposer = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumnMilliseconds = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumnBytes = new DevExpress.XtraGrid.Columns.GridColumn();
			this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.bar2 = new DevExpress.XtraBars.Bar();
			this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
			((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
			this.SuspendLayout();
			// 
			// mvvmContext1
			// 
			this.mvvmContext1.BindingExpressions.AddRange(new DevExpress.Utils.MVVM.BindingExpression[] {
            DevExpress.Utils.MVVM.BindingExpression.CreatePropertyBinding(typeof(DXMVVMSampleWinForms.ViewModels.TrackListViewModel), "Items", this.gridControl1, "DataSource")});
			this.mvvmContext1.ContainerControl = this;
			this.mvvmContext1.ViewModelType = typeof(DXMVVMSampleWinForms.ViewModels.TrackListViewModel);
			// 
			// gridControl1
			// 
			this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridControl1.Location = new System.Drawing.Point(0, 22);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(684, 406);
			this.gridControl1.TabIndex = 0;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnId,
            this.gridColumnName,
            this.gridColumnAlbum,
            this.gridColumnMediaType,
            this.gridColumnGenre,
            this.gridColumnComposer,
            this.gridColumnMilliseconds,
            this.gridColumnBytes});
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsBehavior.Editable = false;
			// 
			// gridColumnId
			// 
			this.gridColumnId.Caption = "Track Id";
			this.gridColumnId.FieldName = "TrackId";
			this.gridColumnId.Name = "gridColumnId";
			this.gridColumnId.Visible = true;
			this.gridColumnId.VisibleIndex = 0;
			// 
			// gridColumnName
			// 
			this.gridColumnName.Caption = "Name";
			this.gridColumnName.FieldName = "Name";
			this.gridColumnName.Name = "gridColumnName";
			this.gridColumnName.Visible = true;
			this.gridColumnName.VisibleIndex = 1;
			// 
			// gridColumnAlbum
			// 
			this.gridColumnAlbum.Caption = "Album";
			this.gridColumnAlbum.FieldName = "AlbumId";
			this.gridColumnAlbum.Name = "gridColumnAlbum";
			this.gridColumnAlbum.Visible = true;
			this.gridColumnAlbum.VisibleIndex = 2;
			// 
			// gridColumnMediaType
			// 
			this.gridColumnMediaType.Caption = "Media type";
			this.gridColumnMediaType.FieldName = "MediaTypeId";
			this.gridColumnMediaType.Name = "gridColumnMediaType";
			this.gridColumnMediaType.Visible = true;
			this.gridColumnMediaType.VisibleIndex = 3;
			// 
			// gridColumnGenre
			// 
			this.gridColumnGenre.Caption = "Genre";
			this.gridColumnGenre.FieldName = "GenreId";
			this.gridColumnGenre.Name = "gridColumnGenre";
			this.gridColumnGenre.Visible = true;
			this.gridColumnGenre.VisibleIndex = 4;
			// 
			// gridColumnComposer
			// 
			this.gridColumnComposer.Caption = "Composer";
			this.gridColumnComposer.FieldName = "Composer";
			this.gridColumnComposer.Name = "gridColumnComposer";
			this.gridColumnComposer.Visible = true;
			this.gridColumnComposer.VisibleIndex = 5;
			// 
			// gridColumnMilliseconds
			// 
			this.gridColumnMilliseconds.Caption = "Milliseconds";
			this.gridColumnMilliseconds.FieldName = "Milliseconds";
			this.gridColumnMilliseconds.Name = "gridColumnMilliseconds";
			this.gridColumnMilliseconds.Visible = true;
			this.gridColumnMilliseconds.VisibleIndex = 6;
			// 
			// gridColumnBytes
			// 
			this.gridColumnBytes.Caption = "Bytes";
			this.gridColumnBytes.FieldName = "Bytes";
			this.gridColumnBytes.Name = "gridColumnBytes";
			this.gridColumnBytes.Visible = true;
			this.gridColumnBytes.VisibleIndex = 7;
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
            this.barButtonItem1});
			this.barManager1.MainMenu = this.bar2;
			this.barManager1.MaxItemId = 1;
			// 
			// barDockControlTop
			// 
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
			this.barDockControlTop.Manager = this.barManager1;
			this.barDockControlTop.Size = new System.Drawing.Size(684, 22);
			// 
			// barDockControlBottom
			// 
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 428);
			this.barDockControlBottom.Manager = this.barManager1;
			this.barDockControlBottom.Size = new System.Drawing.Size(684, 0);
			// 
			// barDockControlLeft
			// 
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 22);
			this.barDockControlLeft.Manager = this.barManager1;
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 406);
			// 
			// barDockControlRight
			// 
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(684, 22);
			this.barDockControlRight.Manager = this.barManager1;
			this.barDockControlRight.Size = new System.Drawing.Size(0, 406);
			// 
			// bar2
			// 
			this.bar2.BarName = "Main menu";
			this.bar2.DockCol = 0;
			this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
			this.bar2.OptionsBar.MultiLine = true;
			this.bar2.OptionsBar.UseWholeRow = true;
			this.bar2.Text = "Main menu";
			// 
			// barButtonItem1
			// 
			this.barButtonItem1.Caption = "Show Report";
			this.barButtonItem1.Id = 0;
			this.barButtonItem1.Name = "barButtonItem1";
			// 
			// TrackListView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.gridControl1);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Name = "TrackListView";
			this.Size = new System.Drawing.Size(684, 428);
			((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

		private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumnId;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumnAlbum;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumnMediaType;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumnGenre;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumnComposer;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumnMilliseconds;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumnBytes;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarManager barManager1;
		private DevExpress.XtraBars.Bar bar2;
		private DevExpress.XtraBars.BarButtonItem barButtonItem1;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
	}
}
