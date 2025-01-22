namespace Algorithm_Project
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDataSize = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRunAlgorithm = new System.Windows.Forms.Button();
            this.checkAllTypes = new System.Windows.Forms.CheckBox();
            this.btnGenerateData = new System.Windows.Forms.Button();
            this.cmbDataType = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDataSet = new System.Windows.Forms.TextBox();
            this.listResults = new System.Windows.Forms.ListBox();
            this.btnDataSet = new System.Windows.Forms.Button();
            this.btnResults = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chartBoth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.chartMemoryUsage = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnMemoryChart = new System.Windows.Forms.Button();
            this.btnTimeChart = new System.Windows.Forms.Button();
            this.chartTimeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBoth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMemoryUsage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTimeChart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(461, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(668, 98);
            this.label1.TabIndex = 0;
            this.label1.Text = "PERFORMANCE ANALYSIS OF SORTING \r\nALGORITHMS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(41, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Data Size : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(36, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Data Type : ";
            // 
            // txtDataSize
            // 
            this.txtDataSize.Location = new System.Drawing.Point(143, 16);
            this.txtDataSize.Name = "txtDataSize";
            this.txtDataSize.Size = new System.Drawing.Size(128, 32);
            this.txtDataSize.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnRunAlgorithm);
            this.panel1.Controls.Add(this.checkAllTypes);
            this.panel1.Controls.Add(this.btnGenerateData);
            this.panel1.Controls.Add(this.cmbDataType);
            this.panel1.Controls.Add(this.txtDataSize);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 200);
            this.panel1.TabIndex = 2;
            // 
            // btnRunAlgorithm
            // 
            this.btnRunAlgorithm.Location = new System.Drawing.Point(143, 144);
            this.btnRunAlgorithm.Name = "btnRunAlgorithm";
            this.btnRunAlgorithm.Size = new System.Drawing.Size(128, 43);
            this.btnRunAlgorithm.TabIndex = 6;
            this.btnRunAlgorithm.Text = "Run Algorithm";
            this.btnRunAlgorithm.UseVisualStyleBackColor = true;
            this.btnRunAlgorithm.Click += new System.EventHandler(this.btnRunAlgorithm_Click);
            // 
            // checkAllTypes
            // 
            this.checkAllTypes.AutoSize = true;
            this.checkAllTypes.Location = new System.Drawing.Point(277, 53);
            this.checkAllTypes.Name = "checkAllTypes";
            this.checkAllTypes.Size = new System.Drawing.Size(106, 28);
            this.checkAllTypes.TabIndex = 5;
            this.checkAllTypes.Text = "All Types";
            this.checkAllTypes.UseVisualStyleBackColor = true;
            this.checkAllTypes.CheckedChanged += new System.EventHandler(this.checkAllTypes_CheckedChanged);
            // 
            // btnGenerateData
            // 
            this.btnGenerateData.Location = new System.Drawing.Point(143, 95);
            this.btnGenerateData.Name = "btnGenerateData";
            this.btnGenerateData.Size = new System.Drawing.Size(128, 43);
            this.btnGenerateData.TabIndex = 4;
            this.btnGenerateData.Text = "Generate Data";
            this.btnGenerateData.UseVisualStyleBackColor = true;
            this.btnGenerateData.Click += new System.EventHandler(this.btnGenerateData_Click);
            // 
            // cmbDataType
            // 
            this.cmbDataType.FormattingEnabled = true;
            this.cmbDataType.Items.AddRange(new object[] {
            "Random",
            "Reverse",
            "Partially Sorted"});
            this.cmbDataType.Location = new System.Drawing.Point(143, 49);
            this.cmbDataType.Name = "cmbDataType";
            this.cmbDataType.Size = new System.Drawing.Size(128, 32);
            this.cmbDataType.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtDataSet);
            this.panel2.Controls.Add(this.listResults);
            this.panel2.Controls.Add(this.btnDataSet);
            this.panel2.Controls.Add(this.btnResults);
            this.panel2.Location = new System.Drawing.Point(12, 307);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 586);
            this.panel2.TabIndex = 3;
            // 
            // txtDataSet
            // 
            this.txtDataSet.Location = new System.Drawing.Point(2, 29);
            this.txtDataSet.Multiline = true;
            this.txtDataSet.Name = "txtDataSet";
            this.txtDataSet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDataSet.Size = new System.Drawing.Size(445, 555);
            this.txtDataSet.TabIndex = 4;
            // 
            // listResults
            // 
            this.listResults.FormattingEnabled = true;
            this.listResults.ItemHeight = 24;
            this.listResults.Location = new System.Drawing.Point(2, 29);
            this.listResults.Name = "listResults";
            this.listResults.Size = new System.Drawing.Size(445, 532);
            this.listResults.TabIndex = 3;
            // 
            // btnDataSet
            // 
            this.btnDataSet.Location = new System.Drawing.Point(224, 0);
            this.btnDataSet.Name = "btnDataSet";
            this.btnDataSet.Size = new System.Drawing.Size(225, 30);
            this.btnDataSet.TabIndex = 1;
            this.btnDataSet.Text = "DATA SET";
            this.btnDataSet.UseVisualStyleBackColor = true;
            this.btnDataSet.Click += new System.EventHandler(this.btnDataSet_Click);
            // 
            // btnResults
            // 
            this.btnResults.Location = new System.Drawing.Point(1, 0);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(225, 30);
            this.btnResults.TabIndex = 0;
            this.btnResults.Text = "RESULTS";
            this.btnResults.UseVisualStyleBackColor = true;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.chartBoth);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.chartMemoryUsage);
            this.panel3.Controls.Add(this.btnMemoryChart);
            this.panel3.Controls.Add(this.btnTimeChart);
            this.panel3.Controls.Add(this.chartTimeChart);
            this.panel3.Location = new System.Drawing.Point(468, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1000, 803);
            this.panel3.TabIndex = 4;
            // 
            // chartBoth
            // 
            chartArea1.Name = "ChartArea1";
            this.chartBoth.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartBoth.Legends.Add(legend1);
            this.chartBoth.Location = new System.Drawing.Point(1, 50);
            this.chartBoth.Name = "chartBoth";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartBoth.Series.Add(series1);
            this.chartBoth.Size = new System.Drawing.Size(998, 750);
            this.chartBoth.TabIndex = 5;
            this.chartBoth.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(450, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "BOTH";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chartMemoryUsage
            // 
            chartArea2.Name = "ChartArea1";
            this.chartMemoryUsage.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartMemoryUsage.Legends.Add(legend2);
            this.chartMemoryUsage.Location = new System.Drawing.Point(1, 50);
            this.chartMemoryUsage.Name = "chartMemoryUsage";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartMemoryUsage.Series.Add(series2);
            this.chartMemoryUsage.Size = new System.Drawing.Size(998, 750);
            this.chartMemoryUsage.TabIndex = 3;
            this.chartMemoryUsage.Text = "chart1";
            // 
            // btnMemoryChart
            // 
            this.btnMemoryChart.Location = new System.Drawing.Point(500, 0);
            this.btnMemoryChart.Name = "btnMemoryChart";
            this.btnMemoryChart.Size = new System.Drawing.Size(500, 50);
            this.btnMemoryChart.TabIndex = 2;
            this.btnMemoryChart.Text = "MEMORY CHART";
            this.btnMemoryChart.UseVisualStyleBackColor = true;
            this.btnMemoryChart.Click += new System.EventHandler(this.btnMemoryChart_Click);
            // 
            // btnTimeChart
            // 
            this.btnTimeChart.Location = new System.Drawing.Point(0, 0);
            this.btnTimeChart.Name = "btnTimeChart";
            this.btnTimeChart.Size = new System.Drawing.Size(500, 50);
            this.btnTimeChart.TabIndex = 1;
            this.btnTimeChart.Text = "TIME CHART";
            this.btnTimeChart.UseVisualStyleBackColor = true;
            this.btnTimeChart.Click += new System.EventHandler(this.btnTimeChart_Click);
            // 
            // chartTimeChart
            // 
            chartArea3.Name = "ChartArea1";
            this.chartTimeChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartTimeChart.Legends.Add(legend3);
            this.chartTimeChart.Location = new System.Drawing.Point(1, 50);
            this.chartTimeChart.Name = "chartTimeChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartTimeChart.Series.Add(series3);
            this.chartTimeChart.Size = new System.Drawing.Size(998, 750);
            this.chartTimeChart.TabIndex = 0;
            this.chartTimeChart.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1483, 922);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "PERFORMANCE ANALYSIS OF SORTING ALGORITHMS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartBoth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMemoryUsage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTimeChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDataSize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbDataType;
        private System.Windows.Forms.Button btnRunAlgorithm;
        private System.Windows.Forms.CheckBox checkAllTypes;
        private System.Windows.Forms.Button btnGenerateData;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDataSet;
        private System.Windows.Forms.Button btnResults;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnMemoryChart;
        private System.Windows.Forms.Button btnTimeChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTimeChart;
        private System.Windows.Forms.ListBox listResults;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMemoryUsage;
        private System.Windows.Forms.TextBox txtDataSet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBoth;
    }
}

