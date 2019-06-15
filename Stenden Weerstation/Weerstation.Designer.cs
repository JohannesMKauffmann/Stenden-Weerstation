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
			this.ActueelMainLabel = new System.Windows.Forms.Label();
			this.WeerstationActueelLabel = new System.Windows.Forms.Label();
			this.StendenLogoActueelPictureBox = new System.Windows.Forms.PictureBox();
			this.TrendTabPage = new System.Windows.Forms.TabPage();
			this.WeatherTrendChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.WeerstationTrendLabel = new System.Windows.Forms.Label();
			this.StendenLogoTrendPictureBox = new System.Windows.Forms.PictureBox();
			this.OptiesTabPage = new System.Windows.Forms.TabPage();
			this.SaveSettingsButton = new System.Windows.Forms.Button();
			this.CelciusRadioButton = new System.Windows.Forms.RadioButton();
			this.FahrenheitRadioButton = new System.Windows.Forms.RadioButton();
			this.SecondenLabel = new System.Windows.Forms.Label();
			this.IntervalTextBox = new System.Windows.Forms.TextBox();
			this.PlaatsTextBox = new System.Windows.Forms.TextBox();
			this.WeergaveLabel = new System.Windows.Forms.Label();
			this.IntervalLabel = new System.Windows.Forms.Label();
			this.PlaatsLabel = new System.Windows.Forms.Label();
			this.OptiesMainLabel = new System.Windows.Forms.Label();
			this.WeerstationOptiesLabel = new System.Windows.Forms.Label();
			this.StendenLogoOptiesPictureBox = new System.Windows.Forms.PictureBox();
			this.MainTabControl.SuspendLayout();
			this.ActueelTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.StendenLogoActueelPictureBox)).BeginInit();
			this.TrendTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.WeatherTrendChart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.StendenLogoTrendPictureBox)).BeginInit();
			this.OptiesTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.StendenLogoOptiesPictureBox)).BeginInit();
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
			this.ActueelTabPage.Controls.Add(this.ActueelMainLabel);
			this.ActueelTabPage.Controls.Add(this.WeerstationActueelLabel);
			this.ActueelTabPage.Controls.Add(this.StendenLogoActueelPictureBox);
			this.ActueelTabPage.Location = new System.Drawing.Point(4, 22);
			this.ActueelTabPage.Name = "ActueelTabPage";
			this.ActueelTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.ActueelTabPage.Size = new System.Drawing.Size(838, 569);
			this.ActueelTabPage.TabIndex = 0;
			this.ActueelTabPage.Text = "Actueel";
			this.ActueelTabPage.UseVisualStyleBackColor = true;
			// 
			// ActueelMainLabel
			// 
			this.ActueelMainLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ActueelMainLabel.Location = new System.Drawing.Point(50, 201);
			this.ActueelMainLabel.Name = "ActueelMainLabel";
			this.ActueelMainLabel.Size = new System.Drawing.Size(738, 326);
			this.ActueelMainLabel.TabIndex = 4;
			// 
			// WeerstationActueelLabel
			// 
			this.WeerstationActueelLabel.AutoSize = true;
			this.WeerstationActueelLabel.Font = new System.Drawing.Font("Gill Sans MT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.WeerstationActueelLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(133)))));
			this.WeerstationActueelLabel.Location = new System.Drawing.Point(425, 112);
			this.WeerstationActueelLabel.Name = "WeerstationActueelLabel";
			this.WeerstationActueelLabel.Size = new System.Drawing.Size(275, 67);
			this.WeerstationActueelLabel.TabIndex = 3;
			this.WeerstationActueelLabel.Text = "Weerstation";
			// 
			// StendenLogoActueelPictureBox
			// 
			this.StendenLogoActueelPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StendenLogoActueelPictureBox.BackgroundImage")));
			this.StendenLogoActueelPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.StendenLogoActueelPictureBox.Location = new System.Drawing.Point(134, 25);
			this.StendenLogoActueelPictureBox.Name = "StendenLogoActueelPictureBox";
			this.StendenLogoActueelPictureBox.Size = new System.Drawing.Size(205, 154);
			this.StendenLogoActueelPictureBox.TabIndex = 2;
			this.StendenLogoActueelPictureBox.TabStop = false;
			// 
			// TrendTabPage
			// 
			this.TrendTabPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TrendTabPage.BackgroundImage")));
			this.TrendTabPage.Controls.Add(this.WeatherTrendChart);
			this.TrendTabPage.Controls.Add(this.WeerstationTrendLabel);
			this.TrendTabPage.Controls.Add(this.StendenLogoTrendPictureBox);
			this.TrendTabPage.Location = new System.Drawing.Point(4, 22);
			this.TrendTabPage.Name = "TrendTabPage";
			this.TrendTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.TrendTabPage.Size = new System.Drawing.Size(838, 569);
			this.TrendTabPage.TabIndex = 1;
			this.TrendTabPage.Text = "Trend";
			this.TrendTabPage.UseVisualStyleBackColor = true;
			// 
			// WeatherTrendChart
			// 
			chartArea1.Name = "ChartArea1";
			this.WeatherTrendChart.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.WeatherTrendChart.Legends.Add(legend1);
			this.WeatherTrendChart.Location = new System.Drawing.Point(261, 223);
			this.WeatherTrendChart.Name = "WeatherTrendChart";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.WeatherTrendChart.Series.Add(series1);
			this.WeatherTrendChart.Size = new System.Drawing.Size(300, 300);
			this.WeatherTrendChart.TabIndex = 3;
			this.WeatherTrendChart.Text = "chart1";
			// 
			// WeerstationTrendLabel
			// 
			this.WeerstationTrendLabel.AutoSize = true;
			this.WeerstationTrendLabel.Font = new System.Drawing.Font("Gill Sans MT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.WeerstationTrendLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(133)))));
			this.WeerstationTrendLabel.Location = new System.Drawing.Point(425, 112);
			this.WeerstationTrendLabel.Name = "WeerstationTrendLabel";
			this.WeerstationTrendLabel.Size = new System.Drawing.Size(275, 67);
			this.WeerstationTrendLabel.TabIndex = 2;
			this.WeerstationTrendLabel.Text = "Weerstation";
			// 
			// StendenLogoTrendPictureBox
			// 
			this.StendenLogoTrendPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StendenLogoTrendPictureBox.BackgroundImage")));
			this.StendenLogoTrendPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.StendenLogoTrendPictureBox.Location = new System.Drawing.Point(134, 25);
			this.StendenLogoTrendPictureBox.Name = "StendenLogoTrendPictureBox";
			this.StendenLogoTrendPictureBox.Size = new System.Drawing.Size(205, 154);
			this.StendenLogoTrendPictureBox.TabIndex = 1;
			this.StendenLogoTrendPictureBox.TabStop = false;
			// 
			// OptiesTabPage
			// 
			this.OptiesTabPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OptiesTabPage.BackgroundImage")));
			this.OptiesTabPage.Controls.Add(this.SaveSettingsButton);
			this.OptiesTabPage.Controls.Add(this.CelciusRadioButton);
			this.OptiesTabPage.Controls.Add(this.FahrenheitRadioButton);
			this.OptiesTabPage.Controls.Add(this.SecondenLabel);
			this.OptiesTabPage.Controls.Add(this.IntervalTextBox);
			this.OptiesTabPage.Controls.Add(this.PlaatsTextBox);
			this.OptiesTabPage.Controls.Add(this.WeergaveLabel);
			this.OptiesTabPage.Controls.Add(this.IntervalLabel);
			this.OptiesTabPage.Controls.Add(this.PlaatsLabel);
			this.OptiesTabPage.Controls.Add(this.OptiesMainLabel);
			this.OptiesTabPage.Controls.Add(this.WeerstationOptiesLabel);
			this.OptiesTabPage.Controls.Add(this.StendenLogoOptiesPictureBox);
			this.OptiesTabPage.Location = new System.Drawing.Point(4, 22);
			this.OptiesTabPage.Name = "OptiesTabPage";
			this.OptiesTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.OptiesTabPage.Size = new System.Drawing.Size(838, 569);
			this.OptiesTabPage.TabIndex = 2;
			this.OptiesTabPage.Text = "Opties";
			this.OptiesTabPage.UseVisualStyleBackColor = true;
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
			this.SaveSettingsButton.Click += new System.EventHandler(this.SaveSettingsButton_Click);
			// 
			// CelciusRadioButton
			// 
			this.CelciusRadioButton.AutoSize = true;
			this.CelciusRadioButton.Checked = true;
			this.CelciusRadioButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CelciusRadioButton.Location = new System.Drawing.Point(437, 429);
			this.CelciusRadioButton.Name = "CelciusRadioButton";
			this.CelciusRadioButton.Size = new System.Drawing.Size(48, 30);
			this.CelciusRadioButton.TabIndex = 10;
			this.CelciusRadioButton.TabStop = true;
			this.CelciusRadioButton.Text = "°C";
			this.CelciusRadioButton.UseVisualStyleBackColor = true;
			// 
			// FahrenheitRadioButton
			// 
			this.FahrenheitRadioButton.AutoSize = true;
			this.FahrenheitRadioButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FahrenheitRadioButton.Location = new System.Drawing.Point(363, 429);
			this.FahrenheitRadioButton.Name = "FahrenheitRadioButton";
			this.FahrenheitRadioButton.Size = new System.Drawing.Size(47, 30);
			this.FahrenheitRadioButton.TabIndex = 9;
			this.FahrenheitRadioButton.Text = "°F";
			this.FahrenheitRadioButton.UseVisualStyleBackColor = true;
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
			// IntervalTextBox
			// 
			this.IntervalTextBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.IntervalTextBox.Location = new System.Drawing.Point(363, 345);
			this.IntervalTextBox.Name = "IntervalTextBox";
			this.IntervalTextBox.Size = new System.Drawing.Size(67, 33);
			this.IntervalTextBox.TabIndex = 7;
			// 
			// PlaatsTextBox
			// 
			this.PlaatsTextBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PlaatsTextBox.Location = new System.Drawing.Point(363, 265);
			this.PlaatsTextBox.Name = "PlaatsTextBox";
			this.PlaatsTextBox.Size = new System.Drawing.Size(255, 33);
			this.PlaatsTextBox.TabIndex = 6;
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
			// PlaatsLabel
			// 
			this.PlaatsLabel.AutoSize = true;
			this.PlaatsLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PlaatsLabel.Location = new System.Drawing.Point(212, 265);
			this.PlaatsLabel.Name = "PlaatsLabel";
			this.PlaatsLabel.Size = new System.Drawing.Size(63, 26);
			this.PlaatsLabel.TabIndex = 3;
			this.PlaatsLabel.Text = "Plaats";
			// 
			// OptiesMainLabel
			// 
			this.OptiesMainLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.OptiesMainLabel.Location = new System.Drawing.Point(50, 201);
			this.OptiesMainLabel.Name = "OptiesMainLabel";
			this.OptiesMainLabel.Size = new System.Drawing.Size(738, 326);
			this.OptiesMainLabel.TabIndex = 2;
			// 
			// WeerstationOptiesLabel
			// 
			this.WeerstationOptiesLabel.AutoSize = true;
			this.WeerstationOptiesLabel.Font = new System.Drawing.Font("Gill Sans MT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.WeerstationOptiesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(133)))));
			this.WeerstationOptiesLabel.Location = new System.Drawing.Point(425, 112);
			this.WeerstationOptiesLabel.Name = "WeerstationOptiesLabel";
			this.WeerstationOptiesLabel.Size = new System.Drawing.Size(275, 67);
			this.WeerstationOptiesLabel.TabIndex = 1;
			this.WeerstationOptiesLabel.Text = "Weerstation";
			// 
			// StendenLogoOptiesPictureBox
			// 
			this.StendenLogoOptiesPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StendenLogoOptiesPictureBox.BackgroundImage")));
			this.StendenLogoOptiesPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.StendenLogoOptiesPictureBox.Location = new System.Drawing.Point(134, 25);
			this.StendenLogoOptiesPictureBox.Name = "StendenLogoOptiesPictureBox";
			this.StendenLogoOptiesPictureBox.Size = new System.Drawing.Size(205, 154);
			this.StendenLogoOptiesPictureBox.TabIndex = 0;
			this.StendenLogoOptiesPictureBox.TabStop = false;
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
			this.Load += new System.EventHandler(this.Weerstation_Load);
			this.MainTabControl.ResumeLayout(false);
			this.ActueelTabPage.ResumeLayout(false);
			this.ActueelTabPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.StendenLogoActueelPictureBox)).EndInit();
			this.TrendTabPage.ResumeLayout(false);
			this.TrendTabPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.WeatherTrendChart)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.StendenLogoTrendPictureBox)).EndInit();
			this.OptiesTabPage.ResumeLayout(false);
			this.OptiesTabPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.StendenLogoOptiesPictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl MainTabControl;
		private System.Windows.Forms.TabPage ActueelTabPage;
		private System.Windows.Forms.Label WeerstationActueelLabel;
		private System.Windows.Forms.PictureBox StendenLogoActueelPictureBox;
		private System.Windows.Forms.TabPage TrendTabPage;
		private System.Windows.Forms.Label WeerstationTrendLabel;
		private System.Windows.Forms.PictureBox StendenLogoTrendPictureBox;
		private System.Windows.Forms.TabPage OptiesTabPage;
		private System.Windows.Forms.Label WeerstationOptiesLabel;
		private System.Windows.Forms.PictureBox StendenLogoOptiesPictureBox;
		private System.Windows.Forms.Label OptiesMainLabel;
		private System.Windows.Forms.Label ActueelMainLabel;
		private System.Windows.Forms.TextBox PlaatsTextBox;
		private System.Windows.Forms.Label WeergaveLabel;
		private System.Windows.Forms.Label IntervalLabel;
		private System.Windows.Forms.Label PlaatsLabel;
		private System.Windows.Forms.TextBox IntervalTextBox;
		private System.Windows.Forms.Label SecondenLabel;
		private System.Windows.Forms.RadioButton CelciusRadioButton;
		private System.Windows.Forms.RadioButton FahrenheitRadioButton;
		private System.Windows.Forms.Button SaveSettingsButton;
		private System.Windows.Forms.DataVisualization.Charting.Chart WeatherTrendChart;
	}
}

