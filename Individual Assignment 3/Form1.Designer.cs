﻿namespace Individual_Assignment_3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bmi_status_lbl = new System.Windows.Forms.Label();
            this.bmi_count_lbl = new System.Windows.Forms.Label();
            this.weight_input = new System.Windows.Forms.TextBox();
            this.height_input = new System.Windows.Forms.TextBox();
            this.calculate_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bmi_status_lbl);
            this.groupBox1.Controls.Add(this.bmi_count_lbl);
            this.groupBox1.Location = new System.Drawing.Point(67, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(683, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // bmi_status_lbl
            // 
            this.bmi_status_lbl.AutoSize = true;
            this.bmi_status_lbl.Location = new System.Drawing.Point(10, 53);
            this.bmi_status_lbl.Name = "bmi_status_lbl";
            this.bmi_status_lbl.Size = new System.Drawing.Size(47, 16);
            this.bmi_status_lbl.TabIndex = 1;
            this.bmi_status_lbl.Text = "Status:";
            // 
            // bmi_count_lbl
            // 
            this.bmi_count_lbl.AutoSize = true;
            this.bmi_count_lbl.Location = new System.Drawing.Point(7, 22);
            this.bmi_count_lbl.Name = "bmi_count_lbl";
            this.bmi_count_lbl.Size = new System.Drawing.Size(33, 16);
            this.bmi_count_lbl.TabIndex = 0;
            this.bmi_count_lbl.Text = "BMI:";
            // 
            // weight_input
            // 
            this.weight_input.Location = new System.Drawing.Point(218, 56);
            this.weight_input.Name = "weight_input";
            this.weight_input.Size = new System.Drawing.Size(100, 22);
            this.weight_input.TabIndex = 1;
            // 
            // height_input
            // 
            this.height_input.Location = new System.Drawing.Point(218, 106);
            this.height_input.Name = "height_input";
            this.height_input.Size = new System.Drawing.Size(100, 22);
            this.height_input.TabIndex = 2;
            // 
            // calculate_btn
            // 
            this.calculate_btn.Location = new System.Drawing.Point(359, 105);
            this.calculate_btn.Name = "calculate_btn";
            this.calculate_btn.Size = new System.Drawing.Size(116, 23);
            this.calculate_btn.TabIndex = 3;
            this.calculate_btn.Text = "Calculate";
            this.calculate_btn.UseVisualStyleBackColor = true;
            this.calculate_btn.Click += new System.EventHandler(this.calculate_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Weight (kilograms):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Height (meters):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculate_btn);
            this.Controls.Add(this.height_input);
            this.Controls.Add(this.weight_input);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox weight_input;
        private System.Windows.Forms.TextBox height_input;
        private System.Windows.Forms.Button calculate_btn;
        private System.Windows.Forms.Label bmi_status_lbl;
        private System.Windows.Forms.Label bmi_count_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

