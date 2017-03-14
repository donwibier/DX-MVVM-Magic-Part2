namespace DXMVVMSampleWinForms
{
	partial class MainWindow
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.trackListView1 = new DXMVVMSampleWinForms.Views.TrackListView();
			this.SuspendLayout();
			// 
			// trackListView1
			// 
			this.trackListView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.trackListView1.Location = new System.Drawing.Point(0, 0);
			this.trackListView1.Name = "trackListView1";
			this.trackListView1.Size = new System.Drawing.Size(811, 599);
			this.trackListView1.TabIndex = 0;
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(811, 599);
			this.Controls.Add(this.trackListView1);
			this.Name = "MainWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainWindow";
			this.ResumeLayout(false);

		}

		private Views.TrackListView trackListView1;

		#endregion

		//private Views.TrackListView trackListView1;
	}
}