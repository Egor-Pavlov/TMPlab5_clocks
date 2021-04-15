
namespace TMPlab5_clocks
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
            this.ShowTime1 = new System.Windows.Forms.Button();
            this.AnalogSeconds = new System.Windows.Forms.NumericUpDown();
            this.AnalogMinutes = new System.Windows.Forms.NumericUpDown();
            this.AnalogHours = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.DigitSeconds = new System.Windows.Forms.NumericUpDown();
            this.DigitMinutes = new System.Windows.Forms.NumericUpDown();
            this.DigitHours = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ShowTime2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AnalogSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnalogMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnalogHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DigitSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DigitMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DigitHours)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShowTime1
            // 
            this.ShowTime1.Location = new System.Drawing.Point(10, 173);
            this.ShowTime1.Name = "ShowTime1";
            this.ShowTime1.Size = new System.Drawing.Size(345, 62);
            this.ShowTime1.TabIndex = 9;
            this.ShowTime1.Text = "Показать время";
            this.ShowTime1.UseVisualStyleBackColor = true;
            this.ShowTime1.Click += new System.EventHandler(this.ShowTime1_Click);
            // 
            // AnalogSeconds
            // 
            this.AnalogSeconds.Location = new System.Drawing.Point(11, 128);
            this.AnalogSeconds.Maximum = new decimal(new int[] {
            359,
            0,
            0,
            0});
            this.AnalogSeconds.Name = "AnalogSeconds";
            this.AnalogSeconds.Size = new System.Drawing.Size(120, 27);
            this.AnalogSeconds.TabIndex = 8;
            // 
            // AnalogMinutes
            // 
            this.AnalogMinutes.Location = new System.Drawing.Point(11, 84);
            this.AnalogMinutes.Maximum = new decimal(new int[] {
            359,
            0,
            0,
            0});
            this.AnalogMinutes.Name = "AnalogMinutes";
            this.AnalogMinutes.Size = new System.Drawing.Size(120, 27);
            this.AnalogMinutes.TabIndex = 7;
            // 
            // AnalogHours
            // 
            this.AnalogHours.Location = new System.Drawing.Point(11, 40);
            this.AnalogHours.Maximum = new decimal(new int[] {
            359,
            0,
            0,
            0});
            this.AnalogHours.Name = "AnalogHours";
            this.AnalogHours.Size = new System.Drawing.Size(120, 27);
            this.AnalogHours.TabIndex = 6;
            this.AnalogHours.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(352, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Время в виде углов для стрелок(ч, м, с):";
            // 
            // DigitSeconds
            // 
            this.DigitSeconds.Location = new System.Drawing.Point(11, 128);
            this.DigitSeconds.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.DigitSeconds.Name = "DigitSeconds";
            this.DigitSeconds.Size = new System.Drawing.Size(120, 27);
            this.DigitSeconds.TabIndex = 4;
            // 
            // DigitMinutes
            // 
            this.DigitMinutes.Location = new System.Drawing.Point(11, 84);
            this.DigitMinutes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.DigitMinutes.Name = "DigitMinutes";
            this.DigitMinutes.Size = new System.Drawing.Size(120, 27);
            this.DigitMinutes.TabIndex = 3;
            // 
            // DigitHours
            // 
            this.DigitHours.Location = new System.Drawing.Point(11, 40);
            this.DigitHours.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.DigitHours.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DigitHours.Name = "DigitHours";
            this.DigitHours.Size = new System.Drawing.Size(120, 27);
            this.DigitHours.TabIndex = 1;
            this.DigitHours.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Время в виде целых чисел(ч, м, с):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(392, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(620, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(411, 274);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ShowTime1);
            this.tabPage1.Controls.Add(this.DigitHours);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.DigitMinutes);
            this.tabPage1.Controls.Add(this.DigitSeconds);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(403, 241);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Числовой формат";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ShowTime2);
            this.tabPage2.Controls.Add(this.AnalogSeconds);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.AnalogMinutes);
            this.tabPage2.Controls.Add(this.AnalogHours);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(403, 241);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Аналоговый формат";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ShowTime2
            // 
            this.ShowTime2.Location = new System.Drawing.Point(10, 171);
            this.ShowTime2.Name = "ShowTime2";
            this.ShowTime2.Size = new System.Drawing.Size(343, 64);
            this.ShowTime2.TabIndex = 9;
            this.ShowTime2.Text = "Показать время";
            this.ShowTime2.UseVisualStyleBackColor = true;
            this.ShowTime2.Click += new System.EventHandler(this.ShowTime2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 289);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Лабораторная работа №5";
            ((System.ComponentModel.ISupportInitialize)(this.AnalogSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnalogMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnalogHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DigitSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DigitMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DigitHours)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown DigitSeconds;
        private System.Windows.Forms.NumericUpDown DigitMinutes;
        private System.Windows.Forms.NumericUpDown DigitHours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ShowTime1;
        private System.Windows.Forms.NumericUpDown AnalogSeconds;
        private System.Windows.Forms.NumericUpDown AnalogMinutes;
        private System.Windows.Forms.NumericUpDown AnalogHours;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button ShowTime2;
    }
}

