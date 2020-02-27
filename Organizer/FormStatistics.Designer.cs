namespace Organizer
{
    partial class FormStatistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel1 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStatistics));
            this.chartTask = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.фактическиеЗатратыВремениTableAdapterStatistic = new Organizer.dbtaskDataSetTableAdapters.ФактическиеЗатратыВремениTableAdapter();
            this.dbtaskDataSetStatistic = new Organizer.dbtaskDataSet();
            this.планируемыеЗатратыВремениTableAdapterStatistic = new Organizer.dbtaskDataSetTableAdapters.ПланируемыеЗатратыВремениTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTimes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbtaskDataSetStatistic)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTask
            // 
            chartArea1.AxisY.CustomLabels.Add(customLabel1);
            chartArea1.Name = "ChartArea1";
            this.chartTask.ChartAreas.Add(chartArea1);
            this.chartTask.Location = new System.Drawing.Point(0, 80);
            this.chartTask.Name = "chartTask";
            this.chartTask.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.LegendText = "Время по плану";
            series1.Name = "SeriesPlan";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.LegendText = "Время по факту";
            series2.Name = "SeriesFakt";
            this.chartTask.Series.Add(series1);
            this.chartTask.Series.Add(series2);
            this.chartTask.Size = new System.Drawing.Size(616, 420);
            this.chartTask.TabIndex = 0;
            title1.Name = "TitleChart";
            this.chartTask.Titles.Add(title1);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(81, 51);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(165, 23);
            this.buttonLoad.TabIndex = 1;
            this.buttonLoad.Text = "Получить статистику";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStart.Location = new System.Drawing.Point(15, 25);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(130, 20);
            this.dateTimePickerStart.TabIndex = 3;
            this.dateTimePickerStart.Value = new System.DateTime(2019, 5, 18, 0, 0, 0, 0);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(170, 25);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(130, 20);
            this.dateTimePickerEnd.TabIndex = 4;
            this.dateTimePickerEnd.Value = new System.DateTime(2019, 5, 18, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Дата начала периода";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Дата окончания периода";
            // 
            // фактическиеЗатратыВремениTableAdapterStatistic
            // 
            this.фактическиеЗатратыВремениTableAdapterStatistic.ClearBeforeFill = true;
            // 
            // dbtaskDataSetStatistic
            // 
            this.dbtaskDataSetStatistic.DataSetName = "dbtaskDataSet";
            this.dbtaskDataSetStatistic.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // планируемыеЗатратыВремениTableAdapterStatistic
            // 
            this.планируемыеЗатратыВремениTableAdapterStatistic.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 7;
            // 
            // textBoxTimes
            // 
            this.textBoxTimes.AcceptsReturn = true;
            this.textBoxTimes.AcceptsTab = true;
            this.textBoxTimes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTimes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTimes.Location = new System.Drawing.Point(306, 7);
            this.textBoxTimes.Multiline = true;
            this.textBoxTimes.Name = "textBoxTimes";
            this.textBoxTimes.ReadOnly = true;
            this.textBoxTimes.ShortcutsEnabled = false;
            this.textBoxTimes.Size = new System.Drawing.Size(310, 67);
            this.textBoxTimes.TabIndex = 28;
            this.textBoxTimes.Text = "Общие временные затраты\r\nПлан:\r\nФакт:\r\nПроцент выполнения:\r\n";
            // 
            // FormStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 500);
            this.Controls.Add(this.textBoxTimes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.chartTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Статистика по задачам";
            this.Load += new System.EventHandler(this.FormStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbtaskDataSetStatistic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTask;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private dbtaskDataSetTableAdapters.ФактическиеЗатратыВремениTableAdapter фактическиеЗатратыВремениTableAdapterStatistic;
        private dbtaskDataSet dbtaskDataSetStatistic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private dbtaskDataSetTableAdapters.ПланируемыеЗатратыВремениTableAdapter планируемыеЗатратыВремениTableAdapterStatistic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTimes;
    }
}