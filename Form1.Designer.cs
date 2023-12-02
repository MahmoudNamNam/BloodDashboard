namespace bloodDashBoard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNumReq = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNumDonors = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblNumPatients = new System.Windows.Forms.Label();
            this.labal = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelBloodTypeCount4 = new System.Windows.Forms.Label();
            this.labelBloodTypeCount5 = new System.Windows.Forms.Label();
            this.labelBloodTypeCount6 = new System.Windows.Forms.Label();
            this.labelBloodTypeCount3 = new System.Windows.Forms.Label();
            this.labelBloodTypeCount7 = new System.Windows.Forms.Label();
            this.labelBloodTypeCount1 = new System.Windows.Forms.Label();
            this.labelBloodTypeCount2 = new System.Windows.Forms.Label();
            this.lblTotalProducts = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bloodDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bloodDataSet = new bloodDashBoard.bloodDataSet();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvUnderStock = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bloodDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnderStock)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rakkas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1408, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 49);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(10)))), ((int)(((byte)(9)))));
            this.panel1.Controls.Add(this.lblNumReq);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 59);
            this.panel1.TabIndex = 9;
            // 
            // lblNumReq
            // 
            this.lblNumReq.AutoSize = true;
            this.lblNumReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumReq.Location = new System.Drawing.Point(160, 19);
            this.lblNumReq.Name = "lblNumReq";
            this.lblNumReq.Size = new System.Drawing.Size(79, 33);
            this.lblNumReq.TabIndex = 1;
            this.lblNumReq.Text = "1000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, -5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number of Requests";
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(899, 56);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(529, 262);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            title4.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title4.Name = "Title1";
            title4.Text = "Donor Ages";
            this.chart1.Titles.Add(title4);
            // 
            // chart2
            // 
            chartArea5.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea5);
            legend5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend5.Name = "Legend1";
            this.chart2.Legends.Add(legend5);
            this.chart2.Location = new System.Drawing.Point(7, 128);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            series5.IsValueShownAsLabel = true;
            series5.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(243)))), ((int)(((byte)(219)))));
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart2.Series.Add(series5);
            this.chart2.Size = new System.Drawing.Size(523, 499);
            this.chart2.TabIndex = 13;
            this.chart2.Text = "chart2";
            title5.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title5.Name = "Title1";
            title5.Text = "Top 5 Types";
            this.chart2.Titles.Add(title5);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(10)))), ((int)(((byte)(9)))));
            this.panel2.Controls.Add(this.lblNumDonors);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(287, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 59);
            this.panel2.TabIndex = 10;
            // 
            // lblNumDonors
            // 
            this.lblNumDonors.AutoSize = true;
            this.lblNumDonors.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumDonors.Location = new System.Drawing.Point(164, 19);
            this.lblNumDonors.Name = "lblNumDonors";
            this.lblNumDonors.Size = new System.Drawing.Size(79, 33);
            this.lblNumDonors.TabIndex = 1;
            this.lblNumDonors.Text = "1000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, -5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Number of Donors";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(10)))), ((int)(((byte)(9)))));
            this.panel3.Controls.Add(this.lblNumPatients);
            this.panel3.Controls.Add(this.labal);
            this.panel3.Location = new System.Drawing.Point(562, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(269, 59);
            this.panel3.TabIndex = 11;
            // 
            // lblNumPatients
            // 
            this.lblNumPatients.AutoSize = true;
            this.lblNumPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPatients.Location = new System.Drawing.Point(164, 19);
            this.lblNumPatients.Name = "lblNumPatients";
            this.lblNumPatients.Size = new System.Drawing.Size(79, 33);
            this.lblNumPatients.TabIndex = 1;
            this.lblNumPatients.Text = "1000";
            // 
            // labal
            // 
            this.labal.AutoSize = true;
            this.labal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labal.Location = new System.Drawing.Point(15, -5);
            this.labal.Name = "labal";
            this.labal.Size = new System.Drawing.Size(169, 24);
            this.labal.TabIndex = 0;
            this.labal.Text = "Number of Patients";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(10)))), ((int)(((byte)(9)))));
            this.panel4.Controls.Add(this.labelBloodTypeCount4);
            this.panel4.Controls.Add(this.labelBloodTypeCount5);
            this.panel4.Controls.Add(this.labelBloodTypeCount6);
            this.panel4.Controls.Add(this.labelBloodTypeCount3);
            this.panel4.Controls.Add(this.labelBloodTypeCount7);
            this.panel4.Controls.Add(this.labelBloodTypeCount1);
            this.panel4.Controls.Add(this.labelBloodTypeCount2);
            this.panel4.Controls.Add(this.lblTotalProducts);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(1183, 324);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(291, 303);
            this.panel4.TabIndex = 12;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // labelBloodTypeCount4
            // 
            this.labelBloodTypeCount4.AutoSize = true;
            this.labelBloodTypeCount4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBloodTypeCount4.Location = new System.Drawing.Point(27, 156);
            this.labelBloodTypeCount4.Name = "labelBloodTypeCount4";
            this.labelBloodTypeCount4.Size = new System.Drawing.Size(53, 24);
            this.labelBloodTypeCount4.TabIndex = 10;
            this.labelBloodTypeCount4.Text = "Type";
            // 
            // labelBloodTypeCount5
            // 
            this.labelBloodTypeCount5.AutoSize = true;
            this.labelBloodTypeCount5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBloodTypeCount5.Location = new System.Drawing.Point(27, 186);
            this.labelBloodTypeCount5.Name = "labelBloodTypeCount5";
            this.labelBloodTypeCount5.Size = new System.Drawing.Size(53, 24);
            this.labelBloodTypeCount5.TabIndex = 10;
            this.labelBloodTypeCount5.Text = "Type";
            // 
            // labelBloodTypeCount6
            // 
            this.labelBloodTypeCount6.AutoSize = true;
            this.labelBloodTypeCount6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBloodTypeCount6.Location = new System.Drawing.Point(27, 222);
            this.labelBloodTypeCount6.Name = "labelBloodTypeCount6";
            this.labelBloodTypeCount6.Size = new System.Drawing.Size(53, 24);
            this.labelBloodTypeCount6.TabIndex = 10;
            this.labelBloodTypeCount6.Text = "Type";
            // 
            // labelBloodTypeCount3
            // 
            this.labelBloodTypeCount3.AutoSize = true;
            this.labelBloodTypeCount3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBloodTypeCount3.Location = new System.Drawing.Point(27, 129);
            this.labelBloodTypeCount3.Name = "labelBloodTypeCount3";
            this.labelBloodTypeCount3.Size = new System.Drawing.Size(53, 24);
            this.labelBloodTypeCount3.TabIndex = 9;
            this.labelBloodTypeCount3.Text = "Type";
            // 
            // labelBloodTypeCount7
            // 
            this.labelBloodTypeCount7.AutoSize = true;
            this.labelBloodTypeCount7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBloodTypeCount7.Location = new System.Drawing.Point(27, 253);
            this.labelBloodTypeCount7.Name = "labelBloodTypeCount7";
            this.labelBloodTypeCount7.Size = new System.Drawing.Size(53, 24);
            this.labelBloodTypeCount7.TabIndex = 9;
            this.labelBloodTypeCount7.Text = "Type";
            // 
            // labelBloodTypeCount1
            // 
            this.labelBloodTypeCount1.AutoSize = true;
            this.labelBloodTypeCount1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBloodTypeCount1.Location = new System.Drawing.Point(27, 70);
            this.labelBloodTypeCount1.Name = "labelBloodTypeCount1";
            this.labelBloodTypeCount1.Size = new System.Drawing.Size(53, 24);
            this.labelBloodTypeCount1.TabIndex = 8;
            this.labelBloodTypeCount1.Text = "Type";
            // 
            // labelBloodTypeCount2
            // 
            this.labelBloodTypeCount2.AutoSize = true;
            this.labelBloodTypeCount2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBloodTypeCount2.Location = new System.Drawing.Point(27, 101);
            this.labelBloodTypeCount2.Name = "labelBloodTypeCount2";
            this.labelBloodTypeCount2.Size = new System.Drawing.Size(53, 24);
            this.labelBloodTypeCount2.TabIndex = 8;
            this.labelBloodTypeCount2.Text = "Type";
            // 
            // lblTotalProducts
            // 
            this.lblTotalProducts.AutoSize = true;
            this.lblTotalProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProducts.Location = new System.Drawing.Point(154, 25);
            this.lblTotalProducts.Name = "lblTotalProducts";
            this.lblTotalProducts.Size = new System.Drawing.Size(69, 29);
            this.lblTotalProducts.TabIndex = 7;
            this.lblTotalProducts.Text = "1000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, -6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total Stock";
            // 
            // bloodDataSetBindingSource
            // 
            this.bloodDataSetBindingSource.DataSource = this.bloodDataSet;
            this.bloodDataSetBindingSource.Position = 0;
            // 
            // bloodDataSet
            // 
            this.bloodDataSet.DataSetName = "bloodDataSet";
            this.bloodDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, -5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(187, 24);
            this.label12.TabIndex = 2;
            this.label12.Text = "Products UnderStock";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, -6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 31);
            this.label14.TabIndex = 0;
            // 
            // dgvUnderStock
            // 
            this.dgvUnderStock.AllowUserToOrderColumns = true;
            this.dgvUnderStock.AllowUserToResizeColumns = false;
            this.dgvUnderStock.AllowUserToResizeRows = false;
            this.dgvUnderStock.AutoGenerateColumns = false;
            this.dgvUnderStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvUnderStock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(8)))), ((int)(((byte)(4)))));
            this.dgvUnderStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUnderStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUnderStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(243)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(10)))), ((int)(((byte)(9)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(10)))), ((int)(((byte)(9)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(243)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUnderStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUnderStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnderStock.DataSource = this.bloodDataSetBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(10)))), ((int)(((byte)(9)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(243)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(243)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(10)))), ((int)(((byte)(9)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUnderStock.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUnderStock.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvUnderStock.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(243)))), ((int)(((byte)(219)))));
            this.dgvUnderStock.Location = new System.Drawing.Point(8, 28);
            this.dgvUnderStock.Name = "dgvUnderStock";
            this.dgvUnderStock.ReadOnly = true;
            this.dgvUnderStock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUnderStock.RowHeadersVisible = false;
            this.dgvUnderStock.RowHeadersWidth = 51;
            this.dgvUnderStock.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvUnderStock.RowTemplate.Height = 24;
            this.dgvUnderStock.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvUnderStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnderStock.ShowCellErrors = false;
            this.dgvUnderStock.ShowCellToolTips = false;
            this.dgvUnderStock.ShowEditingIcon = false;
            this.dgvUnderStock.ShowRowErrors = false;
            this.dgvUnderStock.Size = new System.Drawing.Size(378, 262);
            this.dgvUnderStock.TabIndex = 3;
            this.dgvUnderStock.VirtualMode = true;
            this.dgvUnderStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnderStock_CellContentClick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(10)))), ((int)(((byte)(9)))));
            this.panel5.Controls.Add(this.dgvUnderStock);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Location = new System.Drawing.Point(908, 327);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(269, 300);
            this.panel5.TabIndex = 13;
            // 
            // chart3
            // 
            chartArea6.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea6);
            legend6.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend6.Name = "Legend1";
            this.chart3.Legends.Add(legend6);
            this.chart3.Location = new System.Drawing.Point(536, 128);
            this.chart3.Name = "chart3";
            this.chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            series6.IsValueShownAsLabel = true;
            series6.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(243)))), ((int)(((byte)(219)))));
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart3.Series.Add(series6);
            this.chart3.Size = new System.Drawing.Size(344, 496);
            this.chart3.TabIndex = 14;
            this.chart3.Text = "chart3";
            title6.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title6.Name = "Title1";
            title6.Text = "Donors Gender";
            this.chart3.Titles.Add(title6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(8)))), ((int)(((byte)(4)))));
            this.ClientSize = new System.Drawing.Size(1479, 627);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(243)))), ((int)(((byte)(219)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bloodDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnderStock)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNumReq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNumDonors;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblNumPatients;
        private System.Windows.Forms.Label labal;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalProducts;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.BindingSource bloodDataSetBindingSource;
        private bloodDataSet bloodDataSet;
        private System.Windows.Forms.Label labelBloodTypeCount4;
        private System.Windows.Forms.Label labelBloodTypeCount5;
        private System.Windows.Forms.Label labelBloodTypeCount6;
        private System.Windows.Forms.Label labelBloodTypeCount3;
        private System.Windows.Forms.Label labelBloodTypeCount7;
        private System.Windows.Forms.Label labelBloodTypeCount1;
        private System.Windows.Forms.Label labelBloodTypeCount2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvUnderStock;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
    }
}

