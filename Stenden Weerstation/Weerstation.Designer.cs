namespace Stenden_Weerstation
{
	partial class Weerstation
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Weerstation));
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.MainTabControl = new System.Windows.Forms.TabControl();
			this.ActueelTabPage = new System.Windows.Forms.TabPage();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.TrendTabPage = new System.Windows.Forms.TabPage();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.OptiesTabPage = new System.Windows.Forms.TabPage();
			this.PLaatsTextBox = new System.Windows.Forms.TextBox();
			this.WeergaveLabel = new System.Windows.Forms.Label();
			this.IntervalLabel = new System.Windows.Forms.Label();
			this.PLaatsLabel = new System.Windows.Forms.Label();
			this.BoxLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.IntervalTextBox = new System.Windows.Forms.TextBox();
			this.SecondenLabel = new System.Windows.Forms.Label();
			this.FahrenheitRadioButton = new System.Windows.Forms.RadioButton();
			this.CelciusRadioButton = new System.Windows.Forms.RadioButton();
			this.SaveSettingsButton = new System.Windows.Forms.Button();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.MainTabControl.SuspendLayout();
			this.ActueelTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.TrendTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.OptiesTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// MainTabControl
			// 
			this.MainTabControl.Controls.Add(this.ActueelTabPage);
			this.MainTabControl.Controls.Add(this.TrendTabPage);
			this.MainTabControl.Controls.Add(this.OptiesTabPage);
			this.MainTabControl.Location = new System.Drawing.Point(2, 1);
			this.MainTabControl.Name = "MainTabControl";
			this.MainTabControl.SelectedIndex = 0;
			this.MainTabControl.Size = new System.Drawing.Size(846, 595);
			this.MainTabControl.TabIndex = 0;
			// 
			// ActueelTabPage
			// 
			this.ActueelTabPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ActueelTabPage.BackgroundImage")));
			this.ActueelTabPage.Controls.Add(this.label4);
			this.ActueelTabPage.Controls.Add(this.label3);
			this.ActueelTabPage.Controls.Add(this.pictureBox3);
			this.ActueelTabPage.Location = new System.Drawing.Point(4, 22);
			this.ActueelTabPage.Name = "ActueelTabPage";
			this.ActueelTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.ActueelTabPage.Size = new System.Drawing.Size(838, 569);
			this.ActueelTabPage.TabIndex = 0;
			this.ActueelTabPage.Text = "Actueel";
			this.ActueelTabPage.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label4.Location = new System.Drawing.Point(50, 201);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(738, 326);
			this.label4.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Gill Sans MT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(133)))));
			this.label3.Location = new System.Drawing.Point(425, 112);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(275, 67);
			this.label3.TabIndex = 3;
			this.label3.Text = "Weerstation";
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
			this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBox3.Location = new System.Drawing.Point(134, 25);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(205, 154);
			this.pictureBox3.TabIndex = 2;
			this.pictureBox3.TabStop = false;
			// 
			// TrendTabPage
			// 
			this.TrendTabPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TrendTabPage.BackgroundImage")));
			this.TrendTabPage.Controls.Add(this.chart1);
			this.TrendTabPage.Controls.Add(this.label2);
			this.TrendTabPage.Controls.Add(this.pictureBox2);
			this.TrendTabPage.Location = new System.Drawing.Point(4, 22);
			this.TrendTabPage.Name = "TrendTabPage";
			this.TrendTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.TrendTabPage.Size = new System.Drawing.Size(838, 569);
			this.TrendTabPage.TabIndex = 1;
			this.TrendTabPage.Text = "Trend";
			this.TrendTabPage.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Gill Sans MT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(133)))));
			this.label2.Location = new System.Drawing.Point(425, 112);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(275, 67);
			this.label2.TabIndex = 2;
			this.label2.Text = "Weerstation";
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBox2.Location = new System.Drawing.Point(134, 25);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(205, 154);
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// OptiesTabPage
			// 
			this.OptiesTabPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OptiesTabPage.BackgroundImage")));
			this.OptiesTabPage.Controls.Add(this.SaveSettingsButton);
			this.OptiesTabPage.Controls.Add(this.CelciusRadioButton);
			this.OptiesTabPage.Controls.Add(this.FahrenheitRadioButton);
			this.OptiesTabPage.Controls.Add(this.SecondenLabel);
			this.OptiesTabPage.Controls.Add(this.IntervalTextBox);
			this.OptiesTabPage.Controls.Add(this.PLaatsTextBox);
			this.OptiesTabPage.Controls.Add(this.WeergaveLabel);
			this.OptiesTabPage.Controls.Add(this.IntervalLabel);
			this.OptiesTabPage.Controls.Add(this.PLaatsLabel);
			this.OptiesTabPage.Controls.Add(this.BoxLabel);
			this.OptiesTabPage.Controls.Add(this.label1);
			this.OptiesTabPage.Controls.Add(this.pictureBox1);
			this.OptiesTabPage.Location = new System.Drawing.Point(4, 22);
			this.OptiesTabPage.Name = "OptiesTabPage";
			this.OptiesTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.OptiesTabPage.Size = new System.Drawing.Size(838, 569);
			this.OptiesTabPage.TabIndex = 2;
			this.OptiesTabPage.Text = "Opties";
			this.OptiesTabPage.UseVisualStyleBackColor = true;
			// 
			// PLaatsTextBox
			// 
			this.PLaatsTextBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PLaatsTextBox.Location = new System.Drawing.Point(363, 265);
			this.PLaatsTextBox.Name = "PLaatsTextBox";
			this.PLaatsTextBox.Size = new System.Drawing.Size(255, 33);
			this.PLaatsTextBox.TabIndex = 6;
			// 
			// WeergaveLabel
			// 
			this.WeergaveLabel.AutoSize = true;
			this.WeergaveLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.WeergaveLabel.Location = new System.Drawing.Point(212, 431);
			this.WeergaveLabel.Name = "WeergaveLabel";
			this.WeergaveLabel.Size = new System.Drawing.Size(96, 26);
			this.WeergaveLabel.TabIndex = 5;
			this.WeergaveLabel.Text = "Weergave";
			// 
			// IntervalLabel
			// 
			this.IntervalLabel.AutoSize = true;
			this.IntervalLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.IntervalLabel.Location = new System.Drawing.Point(212, 348);
			this.IntervalLabel.Name = "IntervalLabel";
			this.IntervalLabel.Size = new System.Drawing.Size(76, 26);
			this.IntervalLabel.TabIndex = 4;
			this.IntervalLabel.Text = "Interval";
			// 
			// PLaatsLabel
			// 
			this.PLaatsLabel.AutoSize = true;
			this.PLaatsLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PLaatsLabel.Location = new System.Drawing.Point(212, 265);
			this.PLaatsLabel.Name = "PLaatsLabel";
			this.PLaatsLabel.Size = new System.Drawing.Size(63, 26);
			this.PLaatsLabel.TabIndex = 3;
			this.PLaatsLabel.Text = "Plaats";
			// 
			// BoxLabel
			// 
			this.BoxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.BoxLabel.Location = new System.Drawing.Point(50, 201);
			this.BoxLabel.Name = "BoxLabel";
			this.BoxLabel.Size = new System.Drawing.Size(738, 326);
			this.BoxLabel.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Gill Sans MT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(133)))));
			this.label1.Location = new System.Drawing.Point(425, 112);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(275, 67);
			this.label1.TabIndex = 1;
			this.label1.Text = "Weerstation";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBox1.Location = new System.Drawing.Point(134, 25);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(205, 154);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// IntervalTextBox
			// 
			this.IntervalTextBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.IntervalTextBox.Location = new System.Drawing.Point(363, 345);
			this.IntervalTextBox.Name = "IntervalTextBox";
			this.IntervalTextBox.Size = new System.Drawing.Size(67, 33);
			this.IntervalTextBox.TabIndex = 7;
			// 
			// SecondenLabel
			// 
			this.SecondenLabel.AutoSize = true;
			this.SecondenLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SecondenLabel.Location = new System.Drawing.Point(463, 354);
			this.SecondenLabel.Name = "SecondenLabel";
			this.SecondenLabel.Size = new System.Drawing.Size(93, 18);
			this.SecondenLabel.TabIndex = 8;
			this.SecondenLabel.Text = "(in seconden)";
			// 
			// FahrenheitRadioButton
			// 
			this.FahrenheitRadioButton.AutoSize = true;
			this.FahrenheitRadioButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FahrenheitRadioButton.Location = new System.Drawing.Point(363, 429);
			this.FahrenheitRadioButton.Name = "FahrenheitRadioButton";
			this.FahrenheitRadioButton.Size = new System.Drawing.Size(47, 30);
			this.FahrenheitRadioButton.TabIndex = 9;
			this.FahrenheitRadioButton.TabStop = true;
			this.FahrenheitRadioButton.Text = "°F";
			this.FahrenheitRadioButton.UseVisualStyleBackColor = true;
			// 
			// CelciusRadioButton
			// 
			this.CelciusRadioButton.AutoSize = true;
			this.CelciusRadioButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CelciusRadioButton.Location = new System.Drawing.Point(437, 429);
			this.CelciusRadioButton.Name = "CelciusRadioButton";
			this.CelciusRadioButton.Size = new System.Drawing.Size(48, 30);
			this.CelciusRadioButton.TabIndex = 10;
			this.CelciusRadioButton.TabStop = true;
			this.CelciusRadioButton.Text = "°C";
			this.CelciusRadioButton.UseVisualStyleBackColor = true;
			// 
			// SaveSettingsButton
			// 
			this.SaveSettingsButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SaveSettingsButton.Location = new System.Drawing.Point(611, 458);
			this.SaveSettingsButton.Name = "SaveSettingsButton";
			this.SaveSettingsButton.Size = new System.Drawing.Size(119, 43);
			this.SaveSettingsButton.TabIndex = 11;
			this.SaveSettingsButton.Text = "Toepassen";
			this.SaveSettingsButton.UseVisualStyleBackColor = true;
			// 
			// chart1
			// 
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(261, 223);
			this.chart1.Name = "chart1";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.chart1.Series.Add(series1);
			this.chart1.Size = new System.Drawing.Size(300, 300);
			this.chart1.TabIndex = 3;
			this.chart1.Text = "chart1";
			// 
			// Weerstation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(849, 597);
			this.Controls.Add(this.MainTabControl);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Weerstation";
			this.Text = "Stenden Weerstation";
			this.MainTabControl.ResumeLayout(false);
			this.ActueelTabPage.ResumeLayout(false);
			this.ActueelTabPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.TrendTabPage.ResumeLayout(false);
			this.TrendTabPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.OptiesTabPage.ResumeLayout(false);
			this.OptiesTabPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl MainTabControl;
		private System.Windows.Forms.TabPage ActueelTabPage;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.TabPage TrendTabPage;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.TabPage OptiesTabPage;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label BoxLabel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox PLaatsTextBox;
		private System.Windows.Forms.Label WeergaveLabel;
		private System.Windows.Forms.Label IntervalLabel;
		private System.Windows.Forms.Label PLaatsLabel;
		private System.Windows.Forms.TextBox IntervalTextBox;
		private System.Windows.Forms.Label SecondenLabel;
		private System.Windows.Forms.RadioButton CelciusRadioButton;
		private System.Windows.Forms.RadioButton FahrenheitRadioButton;
		private System.Windows.Forms.Button SaveSettingsButton;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
	}
}

