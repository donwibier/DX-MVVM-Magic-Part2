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
			((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
			this.gridControl1.Location = new System.Drawing.Point(0, 0);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(684, 428);
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
			// TrackListView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.gridControl1);
			this.Name = "TrackListView";
			this.Size = new System.Drawing.Size(684, 428);
			((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.ResumeLayout(false);

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
	}
}
