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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Weerstation));
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.MainTabControl = new System.Windows.Forms.TabControl();
			this.ActueelTabPage = new System.Windows.Forms.TabPage();
			this.WeatherIconPictureBox = new System.Windows.Forms.PictureBox();
			this.DescriptionLabel = new System.Windows.Forms.Label();
			this.LocationLabel = new System.Windows.Forms.Label();
			this.LatestUpdateLabel = new System.Windows.Forms.Label();
			this.WindLabel = new System.Windows.Forms.Label();
			this.LuchtvochtigheidLabel = new System.Windows.Forms.Label();
			this.TemperatuurLabel = new System.Windows.Forms.Label();
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
			this.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.TempToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
			this.overToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.verversenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.optiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.sluitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.Timer = new System.Windows.Forms.Timer(this.components);
			this.MainTabControl.SuspendLayout();
			this.ActueelTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.WeatherIconPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.StendenLogoActueelPictureBox)).BeginInit();
			this.TrendTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.WeatherTrendChart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.StendenLogoTrendPictureBox)).BeginInit();
			this.OptiesTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.StendenLogoOptiesPictureBox)).BeginInit();
			this.ContextMenuStrip.SuspendLayout();
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
			this.ActueelTabPage.Controls.Add(this.WeatherIconPictureBox);
			this.ActueelTabPage.Controls.Add(this.DescriptionLabel);
			this.ActueelTabPage.Controls.Add(this.LocationLabel);
			this.ActueelTabPage.Controls.Add(this.LatestUpdateLabel);
			this.ActueelTabPage.Controls.Add(this.WindLabel);
			this.ActueelTabPage.Controls.Add(this.LuchtvochtigheidLabel);
			this.ActueelTabPage.Controls.Add(this.TemperatuurLabel);
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
			// WeatherIconPictureBox
			// 
			this.WeatherIconPictureBox.Location = new System.Drawing.Point(100, 391);
			this.WeatherIconPictureBox.Name = "WeatherIconPictureBox";
			this.WeatherIconPictureBox.Size = new System.Drawing.Size(122, 78);
			this.WeatherIconPictureBox.TabIndex = 11;
			this.WeatherIconPictureBox.TabStop = false;
			// 
			// DescriptionLabel
			// 
			this.DescriptionLabel.AutoSize = true;
			this.DescriptionLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DescriptionLabel.Location = new System.Drawing.Point(95, 329);
			this.DescriptionLabel.Name = "DescriptionLabel";
			this.DescriptionLabel.Size = new System.Drawing.Size(140, 26);
			this.DescriptionLabel.TabIndex = 10;
			this.DescriptionLabel.Text = "Vast wel regen";
			// 
			// LocationLabel
			// 
			this.LocationLabel.AutoSize = true;
			this.LocationLabel.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LocationLabel.Location = new System.Drawing.Point(94, 264);
			this.LocationLabel.Name = "LocationLabel";
			this.LocationLabel.Size = new System.Drawing.Size(100, 33);
			this.LocationLabel.TabIndex = 9;
			this.LocationLabel.Text = "Emmen";
			// 
			// LatestUpdateLabel
			// 
			this.LatestUpdateLabel.AutoSize = true;
			this.LatestUpdateLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LatestUpdateLabel.Location = new System.Drawing.Point(564, 504);
			this.LatestUpdateLabel.Name = "LatestUpdateLabel";
			this.LatestUpdateLabel.Size = new System.Drawing.Size(99, 14);
			this.LatestUpdateLabel.TabIndex = 8;
			this.LatestUpdateLabel.Text = "[Laatste update: ";
			// 
			// WindLabel
			// 
			this.WindLabel.AutoSize = true;
			this.WindLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.WindLabel.Location = new System.Drawing.Point(432, 443);
			this.WindLabel.Name = "WindLabel";
			this.WindLabel.Size = new System.Drawing.Size(64, 26);
			this.WindLabel.TabIndex = 7;
			this.WindLabel.Text = "Wind:";
			// 
			// LuchtvochtigheidLabel
			// 
			this.LuchtvochtigheidLabel.AutoSize = true;
			this.LuchtvochtigheidLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LuchtvochtigheidLabel.Location = new System.Drawing.Point(432, 359);
			this.LuchtvochtigheidLabel.Name = "LuchtvochtigheidLabel";
			this.LuchtvochtigheidLabel.Size = new System.Drawing.Size(164, 26);
			this.LuchtvochtigheidLabel.TabIndex = 6;
			this.LuchtvochtigheidLabel.Text = "Luchtvochtigheid:";
			// 
			// TemperatuurLabel
			// 
			this.TemperatuurLabel.AutoSize = true;
			this.TemperatuurLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TemperatuurLabel.Location = new System.Drawing.Point(432, 270);
			this.TemperatuurLabel.Name = "TemperatuurLabel";
			this.TemperatuurLabel.Size = new System.Drawing.Size(127, 26);
			this.TemperatuurLabel.TabIndex = 5;
			this.TemperatuurLabel.Text = "Temperatuur:";
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
			this.WeatherTrendChart.BackColor = System.Drawing.SystemColors.Control;
			chartArea2.Name = "ChartArea1";
			this.WeatherTrendChart.ChartAreas.Add(chartArea2);
			legend2.Name = "Legend1";
			this.WeatherTrendChart.Legends.Add(legend2);
			this.WeatherTrendChart.Location = new System.Drawing.Point(242, 211);
			this.WeatherTrendChart.Name = "WeatherTrendChart";
			series2.ChartArea = "ChartArea1";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series2.Legend = "Legend1";
			series2.Name = "Gemiddelde Temperatuur";
			series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
			series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			this.WeatherTrendChart.Series.Add(series2);
			this.WeatherTrendChart.Size = new System.Drawing.Size(400, 300);
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
			// ContextMenuStrip
			// 
			this.ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TempToolStripTextBox,
            this.overToolStripMenuItem,
            this.toolStripSeparator1,
            this.verversenToolStripMenuItem,
            this.toolStripSeparator2,
            this.optiesToolStripMenuItem,
            this.toolStripSeparator3,
            this.toolStripMenuItem1,
            this.sluitenToolStripMenuItem});
			this.ContextMenuStrip.Name = "ContextMenuStrip";
			this.ContextMenuStrip.ShowImageMargin = false;
			this.ContextMenuStrip.Size = new System.Drawing.Size(236, 179);
			// 
			// TempToolStripTextBox
			// 
			this.TempToolStripTextBox.BackColor = System.Drawing.Color.White;
			this.TempToolStripTextBox.Enabled = false;
			this.TempToolStripTextBox.ForeColor = System.Drawing.Color.Blue;
			this.TempToolStripTextBox.Name = "TempToolStripTextBox";
			this.TempToolStripTextBox.ReadOnly = true;
			this.TempToolStripTextBox.Size = new System.Drawing.Size(200, 23);
			// 
			// overToolStripMenuItem
			// 
			this.overToolStripMenuItem.Name = "overToolStripMenuItem";
			this.overToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
			this.overToolStripMenuItem.Text = "Over...";
			this.overToolStripMenuItem.Click += new System.EventHandler(this.overToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(232, 6);
			// 
			// verversenToolStripMenuItem
			// 
			this.verversenToolStripMenuItem.Name = "verversenToolStripMenuItem";
			this.verversenToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
			this.verversenToolStripMenuItem.Text = "Verversen...";
			this.verversenToolStripMenuItem.Click += new System.EventHandler(this.verversenToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(232, 6);
			// 
			// optiesToolStripMenuItem
			// 
			this.optiesToolStripMenuItem.Name = "optiesToolStripMenuItem";
			this.optiesToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
			this.optiesToolStripMenuItem.Text = "Opties...";
			this.optiesToolStripMenuItem.Click += new System.EventHandler(this.optiesToolStripMenuItem_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(232, 6);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(235, 22);
			this.toolStripMenuItem1.Text = "Open...";
			this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
			// 
			// sluitenToolStripMenuItem
			// 
			this.sluitenToolStripMenuItem.Name = "sluitenToolStripMenuItem";
			this.sluitenToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
			this.sluitenToolStripMenuItem.Text = "Sluiten";
			this.sluitenToolStripMenuItem.Click += new System.EventHandler(this.sluitenToolStripMenuItem_Click);
			// 
			// NotifyIcon
			// 
			this.NotifyIcon.ContextMenuStrip = this.ContextMenuStrip;
			this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
			this.NotifyIcon.Text = "NotifyIcon";
			this.NotifyIcon.Visible = true;
			this.NotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
			// 
			// Timer
			// 
			this.Timer.Enabled = true;
			this.Timer.Interval = 60000;
			this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
			// 
			// Weerstation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(849, 597);
			this.Controls.Add(this.MainTabControl);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Weerstation";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Stenden Weerstation";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Weerstation_FormClosing);
			this.Load += new System.EventHandler(this.Weerstation_Load);
			this.MainTabControl.ResumeLayout(false);
			this.ActueelTabPage.ResumeLayout(false);
			this.ActueelTabPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.WeatherIconPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.StendenLogoActueelPictureBox)).EndInit();
			this.TrendTabPage.ResumeLayout(false);
			this.TrendTabPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.WeatherTrendChart)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.StendenLogoTrendPictureBox)).EndInit();
			this.OptiesTabPage.ResumeLayout(false);
			this.OptiesTabPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.StendenLogoOptiesPictureBox)).EndInit();
			this.ContextMenuStrip.ResumeLayout(false);
			this.ContextMenuStrip.PerformLayout();
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
		private System.Windows.Forms.Label WindLabel;
		private System.Windows.Forms.Label LuchtvochtigheidLabel;
		private System.Windows.Forms.Label TemperatuurLabel;
		private System.Windows.Forms.Label LatestUpdateLabel;
		private System.Windows.Forms.Label DescriptionLabel;
		private System.Windows.Forms.Label LocationLabel;
		private System.Windows.Forms.PictureBox WeatherIconPictureBox;
		private new System.Windows.Forms.ContextMenuStrip ContextMenuStrip;
		private System.Windows.Forms.NotifyIcon NotifyIcon;
		private System.Windows.Forms.Timer Timer;
		private System.Windows.Forms.ToolStripMenuItem overToolStripMenuItem;
		private System.Windows.Forms.ToolStripTextBox TempToolStripTextBox;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem verversenToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem optiesToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem sluitenToolStripMenuItem;
	}
}

