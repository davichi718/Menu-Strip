using System.Drawing;
using System.Windows.Forms;

namespace Aplikasi_Pewaktu.GUI
{
    partial class FormTimer
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
            this.labelHour = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelMinute = new System.Windows.Forms.Label();
            this.labelSeconds = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonHourMin = new System.Windows.Forms.Button();
            this.buttonHourMax = new System.Windows.Forms.Button();
            this.buttonMinuteMax = new System.Windows.Forms.Button();
            this.buttonMinuteMin = new System.Windows.Forms.Button();
            this.buttonSecondsMax = new System.Windows.Forms.Button();
            this.buttonSecondsMin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.Font = new System.Drawing.Font("Bookman Old Style", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHour.Location = new System.Drawing.Point(256, 134);
            this.labelHour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(98, 66);
            this.labelHour.TabIndex = 0;
            this.labelHour.Text = "00";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(256, 303);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(106, 29);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(401, 303);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(106, 29);
            this.buttonStop.TabIndex = 2;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(541, 303);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(106, 29);
            this.buttonReset.TabIndex = 3;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // labelMinute
            // 
            this.labelMinute.AutoSize = true;
            this.labelMinute.Font = new System.Drawing.Font("Bookman Old Style", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinute.Location = new System.Drawing.Point(401, 134);
            this.labelMinute.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMinute.Name = "labelMinute";
            this.labelMinute.Size = new System.Drawing.Size(98, 66);
            this.labelMinute.TabIndex = 4;
            this.labelMinute.Text = "00";
            // 
            // labelSeconds
            // 
            this.labelSeconds.AutoSize = true;
            this.labelSeconds.Font = new System.Drawing.Font("Bookman Old Style", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeconds.Location = new System.Drawing.Point(554, 134);
            this.labelSeconds.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSeconds.Name = "labelSeconds";
            this.labelSeconds.Size = new System.Drawing.Size(98, 66);
            this.labelSeconds.TabIndex = 5;
            this.labelSeconds.Text = "00";
            // 
            // buttonHourMin
            // 
            this.buttonHourMin.Location = new System.Drawing.Point(256, 193);
            this.buttonHourMin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonHourMin.Name = "buttonHourMin";
            this.buttonHourMin.Size = new System.Drawing.Size(36, 28);
            this.buttonHourMin.TabIndex = 6;
            this.buttonHourMin.Text = "-";
            this.buttonHourMin.UseVisualStyleBackColor = true;
            // 
            // buttonHourMax
            // 
            this.buttonHourMax.Location = new System.Drawing.Point(311, 193);
            this.buttonHourMax.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonHourMax.Name = "buttonHourMax";
            this.buttonHourMax.Size = new System.Drawing.Size(36, 28);
            this.buttonHourMax.TabIndex = 7;
            this.buttonHourMax.Text = "+";
            this.buttonHourMax.UseVisualStyleBackColor = true;
            // 
            // buttonMinuteMax
            // 
            this.buttonMinuteMax.Location = new System.Drawing.Point(458, 193);
            this.buttonMinuteMax.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonMinuteMax.Name = "buttonMinuteMax";
            this.buttonMinuteMax.Size = new System.Drawing.Size(36, 28);
            this.buttonMinuteMax.TabIndex = 9;
            this.buttonMinuteMax.Text = "+";
            this.buttonMinuteMax.UseVisualStyleBackColor = true;
            // 
            // buttonMinuteMin
            // 
            this.buttonMinuteMin.Location = new System.Drawing.Point(401, 193);
            this.buttonMinuteMin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonMinuteMin.Name = "buttonMinuteMin";
            this.buttonMinuteMin.Size = new System.Drawing.Size(36, 28);
            this.buttonMinuteMin.TabIndex = 8;
            this.buttonMinuteMin.Text = "-";
            this.buttonMinuteMin.UseVisualStyleBackColor = true;
            // 
            // buttonSecondsMax
            // 
            this.buttonSecondsMax.Location = new System.Drawing.Point(611, 193);
            this.buttonSecondsMax.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSecondsMax.Name = "buttonSecondsMax";
            this.buttonSecondsMax.Size = new System.Drawing.Size(36, 28);
            this.buttonSecondsMax.TabIndex = 11;
            this.buttonSecondsMax.Text = "+";
            this.buttonSecondsMax.UseVisualStyleBackColor = true;
            // 
            // buttonSecondsMin
            // 
            this.buttonSecondsMin.Location = new System.Drawing.Point(554, 193);
            this.buttonSecondsMin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSecondsMin.Name = "buttonSecondsMin";
            this.buttonSecondsMin.Size = new System.Drawing.Size(36, 28);
            this.buttonSecondsMin.TabIndex = 10;
            this.buttonSecondsMin.Text = "-";
            this.buttonSecondsMin.UseVisualStyleBackColor = true;
            // 
            // FormTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.buttonSecondsMax);
            this.Controls.Add(this.buttonSecondsMin);
            this.Controls.Add(this.buttonMinuteMax);
            this.Controls.Add(this.buttonMinuteMin);
            this.Controls.Add(this.buttonHourMax);
            this.Controls.Add(this.buttonHourMin);
            this.Controls.Add(this.labelSeconds);
            this.Controls.Add(this.labelMinute);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelHour);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormTimer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormTimer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelHour;
        private Button buttonStart;
        private Button buttonStop;
        private Button buttonReset;
        private Label labelMinute;
        private Label labelSeconds;
        private System.Windows.Forms.Timer timer1;
        private Button buttonHourMin;
        private Button buttonHourMax;
        private Button buttonMinuteMax;
        private Button buttonMinuteMin;
        private Button buttonSecondsMax;
        private Button buttonSecondsMin;
    }
}