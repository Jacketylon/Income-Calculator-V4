
namespace Income_Calculator_V4
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
            this.label1 = new System.Windows.Forms.Label();
            this.rBtnInputYearly = new System.Windows.Forms.RadioButton();
            this.rBtnInputMonthly = new System.Windows.Forms.RadioButton();
            this.rBtnInputWeekly = new System.Windows.Forms.RadioButton();
            this.rBtnInputDaily = new System.Windows.Forms.RadioButton();
            this.rBtnInputHourly = new System.Windows.Forms.RadioButton();
            this.txtBoxInput = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.grpBoxInputTime = new System.Windows.Forms.GroupBox();
            this.chkBoxInputMealtime = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timeInputMeal = new System.Windows.Forms.DateTimePicker();
            this.timeInputEnd = new System.Windows.Forms.DateTimePicker();
            this.timeInputStart = new System.Windows.Forms.DateTimePicker();
            this.txtBoxOutput = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblEnter = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpBoxOutputTime = new System.Windows.Forms.GroupBox();
            this.chkBoxOutputMealtime = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.timeOutputMeal = new System.Windows.Forms.DateTimePicker();
            this.timeOutputEnd = new System.Windows.Forms.DateTimePicker();
            this.timeOutputStart = new System.Windows.Forms.DateTimePicker();
            this.rBtnOutputHourly = new System.Windows.Forms.RadioButton();
            this.rBtnOutputDaily = new System.Windows.Forms.RadioButton();
            this.rBtnOutputWeekly = new System.Windows.Forms.RadioButton();
            this.rBtnOutputMonthly = new System.Windows.Forms.RadioButton();
            this.rBtnOutputYearly = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxInput)).BeginInit();
            this.grpBoxInputTime.SuspendLayout();
            this.grpBoxOutputTime.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select your input option";
            // 
            // rBtnInputYearly
            // 
            this.rBtnInputYearly.AutoSize = true;
            this.rBtnInputYearly.Location = new System.Drawing.Point(9, 25);
            this.rBtnInputYearly.Name = "rBtnInputYearly";
            this.rBtnInputYearly.Size = new System.Drawing.Size(54, 17);
            this.rBtnInputYearly.TabIndex = 1;
            this.rBtnInputYearly.Text = "Yearly";
            this.rBtnInputYearly.UseVisualStyleBackColor = true;
            this.rBtnInputYearly.CheckedChanged += new System.EventHandler(this.rBtnInputYearly_CheckedChanged);
            // 
            // rBtnInputMonthly
            // 
            this.rBtnInputMonthly.AutoSize = true;
            this.rBtnInputMonthly.Checked = true;
            this.rBtnInputMonthly.Location = new System.Drawing.Point(9, 48);
            this.rBtnInputMonthly.Name = "rBtnInputMonthly";
            this.rBtnInputMonthly.Size = new System.Drawing.Size(62, 17);
            this.rBtnInputMonthly.TabIndex = 2;
            this.rBtnInputMonthly.TabStop = true;
            this.rBtnInputMonthly.Text = "Monthly";
            this.rBtnInputMonthly.UseVisualStyleBackColor = true;
            this.rBtnInputMonthly.CheckedChanged += new System.EventHandler(this.rBtnInputMonthly_CheckedChanged);
            // 
            // rBtnInputWeekly
            // 
            this.rBtnInputWeekly.AutoSize = true;
            this.rBtnInputWeekly.Location = new System.Drawing.Point(9, 71);
            this.rBtnInputWeekly.Name = "rBtnInputWeekly";
            this.rBtnInputWeekly.Size = new System.Drawing.Size(61, 17);
            this.rBtnInputWeekly.TabIndex = 3;
            this.rBtnInputWeekly.Text = "Weekly";
            this.rBtnInputWeekly.UseVisualStyleBackColor = true;
            this.rBtnInputWeekly.CheckedChanged += new System.EventHandler(this.rBtnInputWeekly_CheckedChanged);
            // 
            // rBtnInputDaily
            // 
            this.rBtnInputDaily.AutoSize = true;
            this.rBtnInputDaily.Location = new System.Drawing.Point(9, 94);
            this.rBtnInputDaily.Name = "rBtnInputDaily";
            this.rBtnInputDaily.Size = new System.Drawing.Size(48, 17);
            this.rBtnInputDaily.TabIndex = 4;
            this.rBtnInputDaily.Text = "Daily";
            this.rBtnInputDaily.UseVisualStyleBackColor = true;
            this.rBtnInputDaily.CheckedChanged += new System.EventHandler(this.rBtnInputDaily_CheckedChanged);
            // 
            // rBtnInputHourly
            // 
            this.rBtnInputHourly.AutoSize = true;
            this.rBtnInputHourly.Location = new System.Drawing.Point(9, 117);
            this.rBtnInputHourly.Name = "rBtnInputHourly";
            this.rBtnInputHourly.Size = new System.Drawing.Size(55, 17);
            this.rBtnInputHourly.TabIndex = 5;
            this.rBtnInputHourly.Text = "Hourly";
            this.rBtnInputHourly.UseVisualStyleBackColor = true;
            this.rBtnInputHourly.CheckedChanged += new System.EventHandler(this.rBtnInputHourly_CheckedChanged);
            // 
            // txtBoxInput
            // 
            this.txtBoxInput.DecimalPlaces = 2;
            this.txtBoxInput.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtBoxInput.Location = new System.Drawing.Point(27, 179);
            this.txtBoxInput.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.txtBoxInput.Name = "txtBoxInput";
            this.txtBoxInput.Size = new System.Drawing.Size(115, 20);
            this.txtBoxInput.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "R";
            // 
            // grpBoxInputTime
            // 
            this.grpBoxInputTime.Controls.Add(this.chkBoxInputMealtime);
            this.grpBoxInputTime.Controls.Add(this.label5);
            this.grpBoxInputTime.Controls.Add(this.label4);
            this.grpBoxInputTime.Controls.Add(this.label3);
            this.grpBoxInputTime.Controls.Add(this.timeInputMeal);
            this.grpBoxInputTime.Controls.Add(this.timeInputEnd);
            this.grpBoxInputTime.Controls.Add(this.timeInputStart);
            this.grpBoxInputTime.Location = new System.Drawing.Point(77, 62);
            this.grpBoxInputTime.Name = "grpBoxInputTime";
            this.grpBoxInputTime.Size = new System.Drawing.Size(290, 72);
            this.grpBoxInputTime.TabIndex = 9;
            this.grpBoxInputTime.TabStop = false;
            this.grpBoxInputTime.Text = "Based on working from";
            this.grpBoxInputTime.Visible = false;
            // 
            // chkBoxInputMealtime
            // 
            this.chkBoxInputMealtime.AutoSize = true;
            this.chkBoxInputMealtime.Location = new System.Drawing.Point(173, 22);
            this.chkBoxInputMealtime.Name = "chkBoxInputMealtime";
            this.chkBoxInputMealtime.Size = new System.Drawing.Size(111, 17);
            this.chkBoxInputMealtime.TabIndex = 6;
            this.chkBoxInputMealtime.Text = "Exclude meal time";
            this.chkBoxInputMealtime.UseVisualStyleBackColor = true;
            this.chkBoxInputMealtime.CheckedChanged += new System.EventHandler(this.chkBoxInputMealtime_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "excluded meal time";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "with";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "to";
            // 
            // timeInputMeal
            // 
            this.timeInputMeal.CustomFormat = "HH:mm";
            this.timeInputMeal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeInputMeal.Location = new System.Drawing.Point(38, 46);
            this.timeInputMeal.Name = "timeInputMeal";
            this.timeInputMeal.ShowUpDown = true;
            this.timeInputMeal.Size = new System.Drawing.Size(52, 20);
            this.timeInputMeal.TabIndex = 2;
            this.timeInputMeal.Value = new System.DateTime(2021, 6, 12, 0, 0, 0, 0);
            this.timeInputMeal.Visible = false;
            // 
            // timeInputEnd
            // 
            this.timeInputEnd.CustomFormat = "HH:mm";
            this.timeInputEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeInputEnd.Location = new System.Drawing.Point(86, 20);
            this.timeInputEnd.Name = "timeInputEnd";
            this.timeInputEnd.ShowUpDown = true;
            this.timeInputEnd.Size = new System.Drawing.Size(52, 20);
            this.timeInputEnd.TabIndex = 1;
            this.timeInputEnd.Value = new System.DateTime(2021, 6, 12, 17, 0, 0, 0);
            // 
            // timeInputStart
            // 
            this.timeInputStart.CustomFormat = "HH:mm";
            this.timeInputStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeInputStart.Location = new System.Drawing.Point(6, 20);
            this.timeInputStart.Name = "timeInputStart";
            this.timeInputStart.ShowUpDown = true;
            this.timeInputStart.Size = new System.Drawing.Size(52, 20);
            this.timeInputStart.TabIndex = 0;
            this.timeInputStart.Value = new System.DateTime(2021, 6, 12, 9, 0, 0, 0);
            // 
            // txtBoxOutput
            // 
            this.txtBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoxOutput.Location = new System.Drawing.Point(12, 399);
            this.txtBoxOutput.Name = "txtBoxOutput";
            this.txtBoxOutput.ReadOnly = true;
            this.txtBoxOutput.Size = new System.Drawing.Size(100, 20);
            this.txtBoxOutput.TabIndex = 10;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCalculate.Location = new System.Drawing.Point(12, 370);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 11;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Location = new System.Drawing.Point(9, 163);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(148, 13);
            this.lblEnter.TabIndex = 12;
            this.lblEnter.Text = "Enter your MONTHLY income";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Select your output option";
            // 
            // grpBoxOutputTime
            // 
            this.grpBoxOutputTime.Controls.Add(this.chkBoxOutputMealtime);
            this.grpBoxOutputTime.Controls.Add(this.label7);
            this.grpBoxOutputTime.Controls.Add(this.label8);
            this.grpBoxOutputTime.Controls.Add(this.label9);
            this.grpBoxOutputTime.Controls.Add(this.timeOutputMeal);
            this.grpBoxOutputTime.Controls.Add(this.timeOutputEnd);
            this.grpBoxOutputTime.Controls.Add(this.timeOutputStart);
            this.grpBoxOutputTime.Location = new System.Drawing.Point(84, 275);
            this.grpBoxOutputTime.Name = "grpBoxOutputTime";
            this.grpBoxOutputTime.Size = new System.Drawing.Size(290, 72);
            this.grpBoxOutputTime.TabIndex = 15;
            this.grpBoxOutputTime.TabStop = false;
            this.grpBoxOutputTime.Text = "Based on working from";
            this.grpBoxOutputTime.Visible = false;
            // 
            // chkBoxOutputMealtime
            // 
            this.chkBoxOutputMealtime.AutoSize = true;
            this.chkBoxOutputMealtime.Location = new System.Drawing.Point(173, 22);
            this.chkBoxOutputMealtime.Name = "chkBoxOutputMealtime";
            this.chkBoxOutputMealtime.Size = new System.Drawing.Size(111, 17);
            this.chkBoxOutputMealtime.TabIndex = 6;
            this.chkBoxOutputMealtime.Text = "Exclude meal time";
            this.chkBoxOutputMealtime.UseVisualStyleBackColor = true;
            this.chkBoxOutputMealtime.CheckedChanged += new System.EventHandler(this.chkBoxOutputMealtime_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(96, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "excluded meal time";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "with";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(64, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "to";
            // 
            // timeOutputMeal
            // 
            this.timeOutputMeal.CustomFormat = "HH:mm";
            this.timeOutputMeal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeOutputMeal.Location = new System.Drawing.Point(38, 46);
            this.timeOutputMeal.Name = "timeOutputMeal";
            this.timeOutputMeal.ShowUpDown = true;
            this.timeOutputMeal.Size = new System.Drawing.Size(52, 20);
            this.timeOutputMeal.TabIndex = 2;
            this.timeOutputMeal.Value = new System.DateTime(2021, 6, 12, 0, 0, 0, 0);
            this.timeOutputMeal.Visible = false;
            // 
            // timeOutputEnd
            // 
            this.timeOutputEnd.CustomFormat = "HH:mm";
            this.timeOutputEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeOutputEnd.Location = new System.Drawing.Point(86, 20);
            this.timeOutputEnd.Name = "timeOutputEnd";
            this.timeOutputEnd.ShowUpDown = true;
            this.timeOutputEnd.Size = new System.Drawing.Size(52, 20);
            this.timeOutputEnd.TabIndex = 1;
            this.timeOutputEnd.Value = new System.DateTime(2021, 6, 12, 17, 0, 0, 0);
            // 
            // timeOutputStart
            // 
            this.timeOutputStart.CustomFormat = "HH:mm";
            this.timeOutputStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeOutputStart.Location = new System.Drawing.Point(6, 20);
            this.timeOutputStart.Name = "timeOutputStart";
            this.timeOutputStart.ShowUpDown = true;
            this.timeOutputStart.Size = new System.Drawing.Size(52, 20);
            this.timeOutputStart.TabIndex = 0;
            this.timeOutputStart.Value = new System.DateTime(2021, 6, 12, 9, 0, 0, 0);
            // 
            // rBtnOutputHourly
            // 
            this.rBtnOutputHourly.AutoSize = true;
            this.rBtnOutputHourly.Location = new System.Drawing.Point(16, 330);
            this.rBtnOutputHourly.Name = "rBtnOutputHourly";
            this.rBtnOutputHourly.Size = new System.Drawing.Size(55, 17);
            this.rBtnOutputHourly.TabIndex = 14;
            this.rBtnOutputHourly.Text = "Hourly";
            this.rBtnOutputHourly.UseVisualStyleBackColor = true;
            this.rBtnOutputHourly.CheckedChanged += new System.EventHandler(this.rBtnOutputHourly_CheckedChanged);
            // 
            // rBtnOutputDaily
            // 
            this.rBtnOutputDaily.AutoSize = true;
            this.rBtnOutputDaily.Location = new System.Drawing.Point(16, 307);
            this.rBtnOutputDaily.Name = "rBtnOutputDaily";
            this.rBtnOutputDaily.Size = new System.Drawing.Size(48, 17);
            this.rBtnOutputDaily.TabIndex = 13;
            this.rBtnOutputDaily.Text = "Daily";
            this.rBtnOutputDaily.UseVisualStyleBackColor = true;
            // 
            // rBtnOutputWeekly
            // 
            this.rBtnOutputWeekly.AutoSize = true;
            this.rBtnOutputWeekly.Location = new System.Drawing.Point(16, 284);
            this.rBtnOutputWeekly.Name = "rBtnOutputWeekly";
            this.rBtnOutputWeekly.Size = new System.Drawing.Size(61, 17);
            this.rBtnOutputWeekly.TabIndex = 12;
            this.rBtnOutputWeekly.Text = "Weekly";
            this.rBtnOutputWeekly.UseVisualStyleBackColor = true;
            // 
            // rBtnOutputMonthly
            // 
            this.rBtnOutputMonthly.AutoSize = true;
            this.rBtnOutputMonthly.Location = new System.Drawing.Point(16, 261);
            this.rBtnOutputMonthly.Name = "rBtnOutputMonthly";
            this.rBtnOutputMonthly.Size = new System.Drawing.Size(62, 17);
            this.rBtnOutputMonthly.TabIndex = 11;
            this.rBtnOutputMonthly.Text = "Monthly";
            this.rBtnOutputMonthly.UseVisualStyleBackColor = true;
            // 
            // rBtnOutputYearly
            // 
            this.rBtnOutputYearly.AutoSize = true;
            this.rBtnOutputYearly.Location = new System.Drawing.Point(16, 238);
            this.rBtnOutputYearly.Name = "rBtnOutputYearly";
            this.rBtnOutputYearly.Size = new System.Drawing.Size(54, 17);
            this.rBtnOutputYearly.TabIndex = 10;
            this.rBtnOutputYearly.Text = "Yearly";
            this.rBtnOutputYearly.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rBtnInputYearly);
            this.panel1.Controls.Add(this.rBtnInputMonthly);
            this.panel1.Controls.Add(this.rBtnInputWeekly);
            this.panel1.Controls.Add(this.rBtnInputDaily);
            this.panel1.Controls.Add(this.rBtnInputHourly);
            this.panel1.Controls.Add(this.grpBoxInputTime);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(7, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 158);
            this.panel1.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(118, 402);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "per";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 431);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.grpBoxOutputTime);
            this.Controls.Add(this.rBtnOutputHourly);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rBtnOutputDaily);
            this.Controls.Add(this.lblEnter);
            this.Controls.Add(this.rBtnOutputWeekly);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.rBtnOutputMonthly);
            this.Controls.Add(this.txtBoxOutput);
            this.Controls.Add(this.rBtnOutputYearly);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxInput);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Income Calculator V4";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxInput)).EndInit();
            this.grpBoxInputTime.ResumeLayout(false);
            this.grpBoxInputTime.PerformLayout();
            this.grpBoxOutputTime.ResumeLayout(false);
            this.grpBoxOutputTime.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rBtnInputYearly;
        private System.Windows.Forms.RadioButton rBtnInputMonthly;
        private System.Windows.Forms.RadioButton rBtnInputWeekly;
        private System.Windows.Forms.RadioButton rBtnInputDaily;
        private System.Windows.Forms.RadioButton rBtnInputHourly;
        private System.Windows.Forms.NumericUpDown txtBoxInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpBoxInputTime;
        private System.Windows.Forms.DateTimePicker timeInputStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker timeInputMeal;
        private System.Windows.Forms.DateTimePicker timeInputEnd;
        private System.Windows.Forms.TextBox txtBoxOutput;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.CheckBox chkBoxInputMealtime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpBoxOutputTime;
        private System.Windows.Forms.CheckBox chkBoxOutputMealtime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker timeOutputMeal;
        private System.Windows.Forms.DateTimePicker timeOutputEnd;
        private System.Windows.Forms.DateTimePicker timeOutputStart;
        private System.Windows.Forms.RadioButton rBtnOutputHourly;
        private System.Windows.Forms.RadioButton rBtnOutputDaily;
        private System.Windows.Forms.RadioButton rBtnOutputWeekly;
        private System.Windows.Forms.RadioButton rBtnOutputMonthly;
        private System.Windows.Forms.RadioButton rBtnOutputYearly;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
    }
}

