﻿namespace lapTKB
{
    partial class Add_mon_2
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
            this.fmon_name_tb = new System.Windows.Forms.TextBox();
            this.fmon_sotiet_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fmon_add_bt = new System.Windows.Forms.Button();
            this.fmon_cancel_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fmon_name_tb
            // 
            this.fmon_name_tb.Location = new System.Drawing.Point(177, 35);
            this.fmon_name_tb.Name = "fmon_name_tb";
            this.fmon_name_tb.Size = new System.Drawing.Size(100, 20);
            this.fmon_name_tb.TabIndex = 0;
            // 
            // fmon_sotiet_tb
            // 
            this.fmon_sotiet_tb.Location = new System.Drawing.Point(177, 108);
            this.fmon_sotiet_tb.Name = "fmon_sotiet_tb";
            this.fmon_sotiet_tb.Size = new System.Drawing.Size(100, 20);
            this.fmon_sotiet_tb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "tên môn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "số tiết";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "số tín chỉ";
            // 
            // fmon_add_bt
            // 
            this.fmon_add_bt.Location = new System.Drawing.Point(177, 230);
            this.fmon_add_bt.Name = "fmon_add_bt";
            this.fmon_add_bt.Size = new System.Drawing.Size(75, 23);
            this.fmon_add_bt.TabIndex = 6;
            this.fmon_add_bt.Text = "add";
            this.fmon_add_bt.UseVisualStyleBackColor = true;
            this.fmon_add_bt.Click += new System.EventHandler(this.fmon_add_bt_Click);
            // 
            // fmon_cancel_bt
            // 
            this.fmon_cancel_bt.Location = new System.Drawing.Point(498, 230);
            this.fmon_cancel_bt.Name = "fmon_cancel_bt";
            this.fmon_cancel_bt.Size = new System.Drawing.Size(75, 23);
            this.fmon_cancel_bt.TabIndex = 7;
            this.fmon_cancel_bt.Text = "cancel";
            this.fmon_cancel_bt.UseVisualStyleBackColor = true;
            this.fmon_cancel_bt.Click += new System.EventHandler(this.fmon_cancel_bt_Click);
            // 
            // Add_mon_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fmon_cancel_bt);
            this.Controls.Add(this.fmon_add_bt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fmon_sotiet_tb);
            this.Controls.Add(this.fmon_name_tb);
            this.Name = "Add_mon_2";
            this.Text = "Add_mon_2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fmon_name_tb;
        private System.Windows.Forms.TextBox fmon_sotiet_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button fmon_add_bt;
        private System.Windows.Forms.Button fmon_cancel_bt;
    }
}