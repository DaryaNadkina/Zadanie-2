namespace WindowsFormsApp1_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Calculate = new System.Windows.Forms.Button();
            this.velocityTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.angleTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.stepTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(97, 120);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(630, 357);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Calculate
            // 
            this.Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Calculate.Location = new System.Drawing.Point(354, 72);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(123, 30);
            this.Calculate.TabIndex = 17;
            this.Calculate.Text = "Вычислить";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // velocityTB
            // 
            this.velocityTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.velocityTB.Location = new System.Drawing.Point(402, 26);
            this.velocityTB.Name = "velocityTB";
            this.velocityTB.Size = new System.Drawing.Size(38, 26);
            this.velocityTB.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(315, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Скорость";
            // 
            // angleTB
            // 
            this.angleTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.angleTB.Location = new System.Drawing.Point(264, 25);
            this.angleTB.Name = "angleTB";
            this.angleTB.Size = new System.Drawing.Size(38, 26);
            this.angleTB.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(212, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Угол";
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.l1.Location = new System.Drawing.Point(52, 509);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(318, 20);
            this.l1.TabIndex = 18;
            this.l1.Text = "Дальность полета численным методом:";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.l2.Location = new System.Drawing.Point(467, 509);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(239, 20);
            this.l2.TabIndex = 19;
            this.l2.Text = "Дальность полета формулой:";
            // 
            // stepTB
            // 
            this.stepTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.stepTB.Location = new System.Drawing.Point(522, 26);
            this.stepTB.Name = "stepTB";
            this.stepTB.Size = new System.Drawing.Size(38, 26);
            this.stepTB.TabIndex = 21;
            this.stepTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stepTB_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(469, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Шаг";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 574);
            this.Controls.Add(this.stepTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.velocityTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.angleTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "2";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.TextBox velocityTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox angleTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.TextBox stepTB;
        private System.Windows.Forms.Label label3;
    }
}

