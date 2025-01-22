using Algorithm_Project.Algotihms;
using Algorithm_Project.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Algorithm_Project
{
    public partial class Form1 : Form
    {
        private List<int> _data;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chartTimeChart.Visible = false;
            chartMemoryUsage.Visible = false;
            chartBoth.Visible = false;
            listResults.Visible = false;
            txtDataSet.Visible = false;
        }

        private void btnGenerateData_Click(object sender, EventArgs e)
        {
            int dataSize = 0;
            if (txtDataSize.Text != "")
            {
                dataSize = int.Parse(txtDataSize.Text);
            }
            else
            {
                MessageBox.Show("Please write data number first.");
                return;
            }
            if (!checkAllTypes.Checked)
            {
                string dataType = cmbDataType.SelectedItem.ToString();

                _data = DataGenerator.GenerateData(dataSize, dataType);
                MessageBox.Show($"{dataSize} items generated as {dataType}.");
                // Veriyi TextBox'a yazdırıyoruz
                txtDataSet.Text = string.Join(Environment.NewLine, _data);
            }
            else //All types
            {
                string dataType = "Random";

                _data = DataGenerator.GenerateData(dataSize, dataType);
                MessageBox.Show($"{dataSize} items generated for all types.");
                txtDataSet.Text = string.Join(Environment.NewLine, _data);

            }

            txtDataSet.Visible = true;
            listResults.Visible = false;
        }

        private void btnRunAlgorithm_Click(object sender, EventArgs e)
        {
            if (_data == null || !_data.Any())
            {
                MessageBox.Show("Please generate data first.");
                return;
            }

            Dictionary<string, Action<List<int>>> algorithms = new Dictionary<string, Action<List<int>>>
            {
                { "Quick Sort", QuickSort.Sort },
                { "Heap Sort", HeapSort.Sort },
                { "Shell Sort", ShellSort.Sort },
                { "Merge Sort", MergeSort.Sort },
                { "Radix Sort", RadixSort.Sort }
            };

            if (checkAllTypes.Checked)
            {
                listResults.Items.Add($"---------All types {_data.Count} DATA---------");
                // Veri türleri (Random, Reverse, Partially Sorted)
                Dictionary<string, Func<int, List<int>>> dataTypes = new Dictionary<string, Func<int, List<int>>>
                {
                    { "Random", GenerateRandomData },
                    { "Reverse", GenerateReverseData },
                    { "Partially Sorted", GeneratePartiallySortedData }
                };

                // Chart temizleme
                chartMemoryUsage.Series.Clear();
                chartTimeChart.Series.Clear();
                chartBoth.Series.Clear();

                // Chart serilerini oluşturma
                foreach (var dataType in dataTypes.Keys)
                {

                    chartTimeChart.Series.Add(new Series(dataType) { ChartType = SeriesChartType.Column, BorderWidth = 2 });
                    chartMemoryUsage.Series.Add(new Series(dataType) { ChartType = SeriesChartType.Column, BorderWidth = 2 });

                    chartBoth.Series.Add(new Series(dataType + " Time") { ChartType = SeriesChartType.Column, BorderWidth = 2 });
                    chartBoth.Series.Add(new Series(dataType + " Memory") { ChartType = SeriesChartType.Column, BorderWidth = 2, YAxisType = AxisType.Secondary });


                }

                // Performans ölçüm sonuçlarını tutmak için
                var results = new Dictionary<string, Dictionary<string, (long time, long memory)>>();

                foreach (var algorithm in algorithms)
                {
                    results[algorithm.Key] = new Dictionary<string, (long time, long memory)>();

                    foreach (var dataType in dataTypes)
                    {
                        // Veri oluştur
                        var data = dataType.Value(_data.Count);

                        // Zaman ve hafıza ölçümü
                        var dataCopy = new List<int>(data);
                        long memoryUsed = MemoryProfiler.MeasureMemory(() => algorithm.Value(dataCopy), data);
                        var stopwatch = Stopwatch.StartNew();
                        algorithm.Value(dataCopy);
                        stopwatch.Stop();

                        results[algorithm.Key][dataType.Key] = (stopwatch.ElapsedMilliseconds, memoryUsed);

                        // Chart'a veri ekleme
                        chartTimeChart.Series[dataType.Key].Points.AddXY(algorithm.Key, stopwatch.ElapsedMilliseconds);
                        chartMemoryUsage.Series[dataType.Key].Points.AddXY(algorithm.Key, memoryUsed / 1024.0); // KB olarak göster

                        chartBoth.Series[dataType.Key + " Time"].Points.AddXY(algorithm.Key, stopwatch.ElapsedMilliseconds);
                        chartBoth.Series[dataType.Key + " Memory"].Points.AddXY(algorithm.Key, memoryUsed / 1024.0); // KB olarak göster
                    }
                }

                foreach (var algorithm in results)
                {
                    var bestCase = algorithm.Value.OrderBy(x => x.Value.time).First();
                    var worstCase = algorithm.Value.OrderByDescending(x => x.Value.time).First();

                    var averageCase = algorithm.Value.OrderBy(x => x.Value.time).ElementAt(1);

                    listResults.Items.Add($"Best Case for {algorithm.Key}: {bestCase.Key} with {bestCase.Value.time} ms");
                    listResults.Items.Add($"Average Case for {algorithm.Key}: {averageCase.Key} with {averageCase.Value.time} ms");
                    listResults.Items.Add($"Worst Case for {algorithm.Key}: {worstCase.Key} with {worstCase.Value.time} ms");


                    foreach (var dataType in dataTypes)
                    {
                        var algoritmResult = algorithm.Value.Where(x => x.Key == dataType.Key).FirstOrDefault();

                        listResults.Items.Add($"Time for {algorithm.Key} - {dataType.Key} : {algoritmResult.Value.time} ms,  Memory : {algoritmResult.Value.memory / 1024.0:F2} KB");

                    }


                    PrintThericalONotation(algorithm.Key);
                    listResults.Items.Add("");

                }
                listResults.Items.Add("------------------");
                chartBoth.ChartAreas[0].AxisY.Title = "Execution Time (ms)";
                chartBoth.ChartAreas[0].AxisY2.Title = "Memory Usage (KB)";
                chartBoth.ChartAreas[0].AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;


                chartMemoryUsage.ChartAreas[0].AxisY.Title = "Memory Usage (KB)";
                chartTimeChart.ChartAreas[0].AxisY.Title = "Execution Time (ms)";

            }
            else
            {
                var results = new Dictionary<string, Dictionary<string, (long time, long memory)>>();

                Dictionary<string, long> memoryResults = new Dictionary<string, long>();
                Dictionary<string, long> timeResults = new Dictionary<string, long>();

                listResults.Items.Add($"--------- {_data.Count} {cmbDataType.SelectedItem.ToString()} DATA---------");
                foreach (var algorithm in algorithms)
                {
                    var dataCopy = new List<int>(_data);


                    // Memory Measurement
                    long memoryUsed = MemoryProfiler.MeasureMemory(() => algorithm.Value(dataCopy), _data);
                    memoryResults[algorithm.Key] = memoryUsed;

                    // Time Measurement
                    var stopwatch = Stopwatch.StartNew();
                    algorithm.Value(dataCopy);
                    stopwatch.Stop();
                    timeResults[algorithm.Key] = stopwatch.ElapsedMilliseconds;


                    if (memoryUsed != 0)
                    {
                        listResults.Items.Add($"{algorithm.Key}: {stopwatch.ElapsedMilliseconds} ms, Memory: {memoryUsed / 1024.0:F2} KB");
                    }
                    else
                    {
                        listResults.Items.Add($"{algorithm.Key}: {stopwatch.ElapsedMilliseconds} ms, Memory: In-place sorting. 0 KB");

                    }
                }

                // Update the chart
                UpdateChart(memoryResults, timeResults);

                listResults.Items.Add("");


            }

            txtDataSet.Text = string.Join(Environment.NewLine, _data);

            txtDataSet.Visible = false;
            listResults.Visible = true;

        }

        private void UpdateChart(Dictionary<string, long> memoryResults, Dictionary<string, long> timeResults)
        {
            chartMemoryUsage.Series.Clear();
            chartTimeChart.Series.Clear();
            chartBoth.Series.Clear();

            // Memory Usage Series
            var memorySeries = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Memory Usage (KB)",
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
            };

            // Time Series
            var timeSeries = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Execution Time (ms)",
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column,
                YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary // İkinci eksene eklenir
            };

            chartMemoryUsage.Series.Add(memorySeries);
            chartTimeChart.Series.Add(timeSeries);
            chartBoth.Series.Add(memorySeries);
            chartBoth.Series.Add(timeSeries);

            long maxMemoryValue = 0;
            long maxTimeValue = 0;

            // Memory Usage Data
            foreach (var result in memoryResults)
            {
                double memoryInKB = result.Value / 1024.0; // KB olarak göster
                memorySeries.Points.AddXY(result.Key, memoryInKB);

                if (result.Value > maxMemoryValue)
                {
                    maxMemoryValue = result.Value;
                }
            }

            // Time Data
            foreach (var result in timeResults)
            {
                timeSeries.Points.AddXY(result.Key, result.Value); // Milisaniye olarak göster

                if (result.Value > maxTimeValue)
                {
                    maxTimeValue = result.Value;
                }
            }

            // Update chart max values if necessary
            UpdateChartMaxValues("Memory Usage(kb)", maxMemoryValue / 1024); // KB olarak gönder
            UpdateChartMaxValues("Execution Time (ms)", maxTimeValue);

            // Chart axis titles
            chartMemoryUsage.ChartAreas[0].AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartTimeChart.ChartAreas[0].AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartTimeChart.ChartAreas[0].AxisY2.Title = "Execution Time (ms)";
            chartMemoryUsage.ChartAreas[0].AxisY.Title = "Memory Usage (KB)";
            chartBoth.ChartAreas[0].AxisY.Title = "Execution Time (ms)";
            chartBoth.ChartAreas[0].AxisY2.Title = "Memory Usage (KB)";
        }


        private void UpdateChartMaxValues(string type,long value)
        {
            if(type == "Memory Usage(kb)")
            {
                if(value >= chartMemoryUsage.ChartAreas[0].AxisY.Maximum)
                {
                    chartMemoryUsage.ChartAreas[0].AxisY.Maximum = value * 1.1f;
                    chartBoth.ChartAreas[0].AxisY.Maximum = value * 1.1f;
                }
            }
            if(type == "Execution Time (ms)")
            {
                if (value >= chartTimeChart.ChartAreas[0].AxisY.Maximum)
                {
                    chartTimeChart.ChartAreas[0].AxisY.Maximum = value * 1.1f;
                    chartBoth.ChartAreas[0].AxisY2.Maximum = value * 1.1f;
                }
            }
        }

        private void PrintThericalONotation(string algorithm)
        {
            switch (algorithm)
            {
                case "Quick Sort":
                    listResults.Items.Add($"Theoretical Best case for {algorithm}: O(n*logn)");
                    listResults.Items.Add($"Theoretical Average case for {algorithm}: O(n*logn)");
                    listResults.Items.Add($"Theoretical Worst case for {algorithm}: O(n^2)");
                    break;

                case "Heap Sort":
                    listResults.Items.Add($"Theoretical Best case for {algorithm}: O(n*logn)");
                    listResults.Items.Add($"Theoretical Average case for {algorithm}: O(n*logn)");
                    listResults.Items.Add($"Theoretical Worst case for {algorithm}: O(n*logn)");
                    break;

                case "Shell Sort":
                    listResults.Items.Add($"Theoretical Best case for {algorithm}: O(n*logn)");
                    listResults.Items.Add($"Theoretical Average case for {algorithm}: Depends on gap sequence");
                    listResults.Items.Add($"Theoretical Worst case for {algorithm}: O(n^2)");
                    break;

                case "Merge Sort":
                    listResults.Items.Add($"Theoretical Best case for {algorithm}: O(n*logn)");
                    listResults.Items.Add($"Theoretical Average case for {algorithm}: O(n*logn)");
                    listResults.Items.Add($"Theoretical Worst case for {algorithm}: O(n*logn)");
                    break;

                case "Radix Sort":
                    listResults.Items.Add($"Theoretical Best case for {algorithm}: O(n*k)");
                    listResults.Items.Add($"Theoretical Average case for {algorithm}: O(n*k)");
                    listResults.Items.Add($"Theoretical Worst case for {algorithm}: O(n*k)");
                    listResults.Items.Add($"(where n = number of elements, k = number of digits)");
                    break;
            }

        }

        private List<int> GenerateRandomData(int size)
        {
            _data = DataGenerator.GenerateData(size, "Random");
            return _data;
        }

        private List<int> GenerateReverseData(int size)
        {
            _data = DataGenerator.GenerateData(size, "Reverse");
            return _data;
        }

        private List<int> GeneratePartiallySortedData(int size)
        {
            _data = DataGenerator.GenerateData(size, "Partially Sorted");
            return _data;
        }

        private void checkAllTypes_CheckedChanged(object sender, EventArgs e)
        {
            cmbDataType.Enabled = !checkAllTypes.Checked;
        }

        private void btnTimeChart_Click(object sender, EventArgs e)
        {
            chartTimeChart.Visible = true;
            chartMemoryUsage.Visible = false;
            chartBoth.Visible = false;
            btnTimeChart.BackColor = Color.White;
            button1.BackColor = Color.Gainsboro;
            btnMemoryChart.BackColor = Color.Gainsboro;
        }

        private void btnMemoryChart_Click(object sender, EventArgs e)
        {
            chartTimeChart.Visible = false;
            chartMemoryUsage.Visible = true;
            chartBoth.Visible = false;
            btnTimeChart.BackColor = Color.Gainsboro;
            button1.BackColor = Color.Gainsboro;
            btnMemoryChart.BackColor = Color.White;
        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            listResults.Visible = true;
            txtDataSet.Visible = false;
            btnDataSet.BackColor = Color.Gainsboro;
            btnResults.BackColor = Color.White;

        }

        private void btnDataSet_Click(object sender, EventArgs e)
        {
            listResults.Visible = false;
            txtDataSet.Visible = true;
            btnResults.BackColor = Color.Gainsboro;
            btnDataSet.BackColor = Color.White;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            chartTimeChart.Visible = false;
            chartMemoryUsage.Visible = false;
            chartBoth.Visible = true;
            btnTimeChart.BackColor = Color.Gainsboro;
            button1.BackColor = Color.White;
            btnMemoryChart.BackColor = Color.Gainsboro;
        }
    }
}