namespace GetOutOfBed
{
    partial class Form2
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
            this.askUser = new System.Windows.Forms.Label();
            this.hour = new System.Windows.Forms.NumericUpDown();
            this.ampmBox = new System.Windows.Forms.GroupBox();
            this.PM = new System.Windows.Forms.RadioButton();
            this.AM = new System.Windows.Forms.RadioButton();
            this.hourBox = new System.Windows.Forms.GroupBox();
            this.minuteBox = new System.Windows.Forms.GroupBox();
            this.minute = new System.Windows.Forms.NumericUpDown();
            this.addAlarm = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hour)).BeginInit();
            this.ampmBox.SuspendLayout();
            this.hourBox.SuspendLayout();
            this.minuteBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minute)).BeginInit();
            this.SuspendLayout();
            // 
            // askUser
            // 
            this.askUser.AutoSize = true;
            this.askUser.Location = new System.Drawing.Point(25, 13);
            this.askUser.Name = "askUser";
            this.askUser.Size = new System.Drawing.Size(166, 13);
            this.askUser.TabIndex = 0;
            this.askUser.Text = "Please enter a time for your alarm:";
            // 
            // hour
            // 
            this.hour.Location = new System.Drawing.Point(10, 16);
            this.hour.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.hour.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(36, 20);
            this.hour.TabIndex = 1;
            this.hour.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ampmBox
            // 
            this.ampmBox.Controls.Add(this.PM);
            this.ampmBox.Controls.Add(this.AM);
            this.ampmBox.Location = new System.Drawing.Point(187, 44);
            this.ampmBox.Name = "ampmBox";
            this.ampmBox.Size = new System.Drawing.Size(80, 69);
            this.ampmBox.TabIndex = 2;
            this.ampmBox.TabStop = false;
            this.ampmBox.Text = "AM or PM?";
            // 
            // PM
            // 
            this.PM.AutoSize = true;
            this.PM.Location = new System.Drawing.Point(7, 43);
            this.PM.Name = "PM";
            this.PM.Size = new System.Drawing.Size(41, 17);
            this.PM.TabIndex = 1;
            this.PM.TabStop = true;
            this.PM.Text = "PM";
            this.PM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PM.UseVisualStyleBackColor = true;
            // 
            // AM
            // 
            this.AM.AutoSize = true;
            this.AM.Location = new System.Drawing.Point(6, 19);
            this.AM.Name = "AM";
            this.AM.Size = new System.Drawing.Size(41, 17);
            this.AM.TabIndex = 0;
            this.AM.TabStop = true;
            this.AM.Text = "AM";
            this.AM.UseVisualStyleBackColor = true;
            // 
            // hourBox
            // 
            this.hourBox.Controls.Add(this.hour);
            this.hourBox.Location = new System.Drawing.Point(12, 44);
            this.hourBox.Name = "hourBox";
            this.hourBox.Size = new System.Drawing.Size(66, 47);
            this.hourBox.TabIndex = 3;
            this.hourBox.TabStop = false;
            this.hourBox.Text = "Hour";
            // 
            // minuteBox
            // 
            this.minuteBox.Controls.Add(this.minute);
            this.minuteBox.Location = new System.Drawing.Point(85, 44);
            this.minuteBox.Name = "minuteBox";
            this.minuteBox.Size = new System.Drawing.Size(96, 47);
            this.minuteBox.TabIndex = 4;
            this.minuteBox.TabStop = false;
            this.minuteBox.Text = "Minute";
            // 
            // minute
            // 
            this.minute.Location = new System.Drawing.Point(7, 16);
            this.minute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minute.Name = "minute";
            this.minute.Size = new System.Drawing.Size(83, 20);
            this.minute.TabIndex = 0;
            // 
            // addAlarm
            // 
            this.addAlarm.Location = new System.Drawing.Point(13, 98);
            this.addAlarm.Name = "addAlarm";
            this.addAlarm.Size = new System.Drawing.Size(75, 23);
            this.addAlarm.TabIndex = 5;
            this.addAlarm.Text = "Add Alarm";
            this.addAlarm.UseVisualStyleBackColor = true;
            this.addAlarm.Click += new System.EventHandler(this.addAlarm_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(94, 98);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 6;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 129);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.addAlarm);
            this.Controls.Add(this.minuteBox);
            this.Controls.Add(this.hourBox);
            this.Controls.Add(this.ampmBox);
            this.Controls.Add(this.askUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.hour)).EndInit();
            this.ampmBox.ResumeLayout(false);
            this.ampmBox.PerformLayout();
            this.hourBox.ResumeLayout(false);
            this.minuteBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label askUser;
        private System.Windows.Forms.NumericUpDown hour;
        private System.Windows.Forms.GroupBox ampmBox;
        private System.Windows.Forms.RadioButton PM;
        private System.Windows.Forms.RadioButton AM;
        private System.Windows.Forms.GroupBox hourBox;
        private System.Windows.Forms.GroupBox minuteBox;
        private System.Windows.Forms.NumericUpDown minute;
        private System.Windows.Forms.Button addAlarm;
        private System.Windows.Forms.Button cancel;
    }
}