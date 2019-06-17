namespace Stenden_Weerstation
{
	partial class SplashScreen
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
			this.SplashPictureBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.SplashPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// SplashPictureBox
			// 
			this.SplashPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SplashPictureBox.BackgroundImage")));
			this.SplashPictureBox.Location = new System.Drawing.Point(0, 0);
			this.SplashPictureBox.Margin = new System.Windows.Forms.Padding(0);
			this.SplashPictureBox.Name = "SplashPictureBox";
			this.SplashPictureBox.Size = new System.Drawing.Size(400, 375);
			this.SplashPictureBox.TabIndex = 0;
			this.SplashPictureBox.TabStop = false;
			// 
			// SplashScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(400, 375);
			this.ControlBox = false;
			this.Controls.Add(this.SplashPictureBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "SplashScreen";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SplashScreen";
			((System.ComponentModel.ISupportInitialize)(this.SplashPictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox SplashPictureBox;
	}
}