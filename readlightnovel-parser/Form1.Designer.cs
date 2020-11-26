namespace readlightnovel_parser
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
            this.ListTitles = new System.Windows.Forms.ListBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxStartPoint = new System.Windows.Forms.TextBox();
            this.textBoxStopPoint = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListTitles
            // 
            this.ListTitles.FormattingEnabled = true;
            this.ListTitles.Location = new System.Drawing.Point(12, 12);
            this.ListTitles.Name = "ListTitles";
            this.ListTitles.Size = new System.Drawing.Size(261, 420);
            this.ListTitles.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(298, 132);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(100, 23);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(298, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "StartPoint";
            // 
            // textBoxStartPoint
            // 
            this.textBoxStartPoint.Enabled = false;
            this.textBoxStartPoint.Location = new System.Drawing.Point(298, 38);
            this.textBoxStartPoint.Name = "textBoxStartPoint";
            this.textBoxStartPoint.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartPoint.TabIndex = 3;
            this.textBoxStartPoint.Text = "1";
            // 
            // textBoxStopPoint
            // 
            this.textBoxStopPoint.Enabled = false;
            this.textBoxStopPoint.Location = new System.Drawing.Point(298, 98);
            this.textBoxStopPoint.Name = "textBoxStopPoint";
            this.textBoxStopPoint.Size = new System.Drawing.Size(100, 20);
            this.textBoxStopPoint.TabIndex = 5;
            this.textBoxStopPoint.Text = "2";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(298, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "EndPoint";
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(298, 161);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(100, 23);
            this.buttonStop.TabIndex = 6;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 450);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.textBoxStopPoint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxStartPoint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.ListTitles);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxStartPoint;
        private System.Windows.Forms.TextBox textBoxStopPoint;

        private System.Windows.Forms.ListBox ListTitles;

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}