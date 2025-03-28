using System.Drawing;
using System.Windows.Forms;

namespace Aplikasi_Pewaktu.GUI
{
    partial class FormStopwatch
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ButtonStopwatch = new System.Windows.Forms.Button();
            this.labelMinute = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelHour = new System.Windows.Forms.Label();
            this.labelSecond = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonStopwatch
            // 
            this.ButtonStopwatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ButtonStopwatch.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonStopwatch.Location = new System.Drawing.Point(67, 195);
            this.ButtonStopwatch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonStopwatch.Name = "ButtonStopwatch";
            this.ButtonStopwatch.Size = new System.Drawing.Size(153, 54);
            this.ButtonStopwatch.TabIndex = 0;
            this.ButtonStopwatch.Text = "Start\r\n";
            this.ButtonStopwatch.UseVisualStyleBackColor = false;
            // 
            // labelMinute
            // 
            this.labelMinute.AutoSize = true;
            this.labelMinute.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinute.Location = new System.Drawing.Point(293, 83);
            this.labelMinute.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMinute.Name = "labelMinute";
            this.labelMinute.Size = new System.Drawing.Size(86, 65);
            this.labelMinute.TabIndex = 1;
            this.labelMinute.Text = "00";
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonStop.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop.Location = new System.Drawing.Point(269, 195);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(140, 54);
            this.buttonStop.TabIndex = 2;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = false;
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonReset.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(455, 195);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(149, 54);
            this.buttonReset.TabIndex = 3;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHour.Location = new System.Drawing.Point(185, 83);
            this.labelHour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(86, 65);
            this.labelHour.TabIndex = 4;
            this.labelHour.Text = "00";
            // 
            // labelSecond
            // 
            this.labelSecond.AutoSize = true;
            this.labelSecond.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSecond.Location = new System.Drawing.Point(404, 83);
            this.labelSecond.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSecond.Name = "labelSecond";
            this.labelSecond.Size = new System.Drawing.Size(86, 65);
            this.labelSecond.TabIndex = 5;
            this.labelSecond.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 320);
            this.Controls.Add(this.labelSecond);
            this.Controls.Add(this.labelHour);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.labelMinute);
            this.Controls.Add(this.ButtonStopwatch);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormStopwatch";
            this.Text = "Stopwatch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ButtonStopwatch;
        private Label labelMinute;
        private System.Windows.Forms.Timer timer1;
        private Button buttonStop;
        private Button buttonReset;
        private Label labelHour;
        private Label labelSecond;
    }
}