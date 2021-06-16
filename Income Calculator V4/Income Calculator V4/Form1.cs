using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Income_Calculator_V4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = System.Globalization.RegionInfo.CurrentRegion.CurrencySymbol;
        }

        private void rBtnInputHourly_CheckedChanged(object sender, EventArgs e)
        {
            lblEnter.Text = "Enter your HOURLY income";
            txtBoxInput.Increment = 1;
            if (!grpBoxInputTime.Visible)
            {
                grpBoxInputTime.Visible = true;
            } else
            {
                grpBoxInputTime.Visible = false;
            }
        }

        private void chkBoxInputMealtime_CheckedChanged(object sender, EventArgs e)
        {
            if (!label4.Visible || !timeInputMeal.Visible || !label5.Visible)
            {
                label4.Visible = true;
                timeInputMeal.Visible = true;
                label5.Visible = true;
            } else
            {
                label4.Visible = false;
                timeInputMeal.Visible = false; 
                label5.Visible = false;
            }
        }

        private void rBtnInputYearly_CheckedChanged(object sender, EventArgs e)
        {
            lblEnter.Text = "Enter your YEARLY income";
            txtBoxInput.Increment = 10000;
        }

        private void rBtnInputMonthly_CheckedChanged(object sender, EventArgs e)
        {
            lblEnter.Text = "Enter your MONTHLY income";
            txtBoxInput.Increment = 1000;
        }

        private void rBtnInputWeekly_CheckedChanged(object sender, EventArgs e)
        {
            lblEnter.Text = "Enter your WEEKLY income";
            txtBoxInput.Increment = 100;
        }

        private void rBtnInputDaily_CheckedChanged(object sender, EventArgs e)
        {
            lblEnter.Text = "Enter your DAILY income";
            txtBoxInput.Increment = 10;
        }

        private void rBtnOutputHourly_CheckedChanged(object sender, EventArgs e)
        {
            if (!grpBoxOutputTime.Visible)
            {
                grpBoxOutputTime.Visible = true;
            } else
            {
                grpBoxOutputTime.Visible = false;
            }
        }

        private void chkBoxOutputMealtime_CheckedChanged(object sender, EventArgs e)
        {
            if (!label7.Visible || !timeOutputMeal.Visible || !label8.Visible)
            {
                label7.Visible = true;
                timeOutputMeal.Visible = true;
                label8.Visible = true;
            } else
            {
                label7.Visible = false;
                timeOutputMeal.Visible = false;
                label8.Visible = false;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //input
            Double input = 0;
            Double output = 0;
            Double monthlyInput = 0;
            input = Convert.ToDouble(txtBoxInput.Value);

            if (rBtnInputYearly.Checked)
            {
                monthlyInput = input / 12;
            }
            else if (rBtnInputMonthly.Checked)
            {
                monthlyInput = input;
            }
            else if (rBtnInputWeekly.Checked)
            {
                monthlyInput = (input * 52) / 12;
            }
            else if (rBtnInputDaily.Checked)
            {
                monthlyInput = input * 21.67;
            }
            else if (rBtnInputHourly.Checked)
            {
                //hourly input
                DateTime inputStart = timeInputStart.Value;
                DateTime inputEnd = timeInputEnd.Value;
                DateTime inputMeal = timeInputMeal.Value;

                //hourly processing
                int inputHoursWorked = inputEnd.Hour - inputStart.Hour;
                int inputMinutesWorked = inputEnd.Minute - inputStart.Minute;
                int inputHoursMeal = inputMeal.Hour;
                int inputMinutesMeal = inputMeal.Minute;

                Double inputMealTime = inputHoursMeal + (inputMinutesMeal / 60.00);
                Double inputWorkedTime = inputHoursWorked + (inputMinutesWorked / 60.00);
                if (inputWorkedTime < 0)
                {
                    inputWorkedTime += 24;
                }
                inputWorkedTime -= inputMealTime;

                //hourly output
                if (inputStart == inputEnd)
                {
                    MessageBox.Show("Your start and end times cannot be the same", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (chkBoxInputMealtime.Checked && inputWorkedTime <= 0)
                {
                    MessageBox.Show("Your meal time cannot be more than your working time", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    monthlyInput = (input * inputWorkedTime) * 21.67;
                }
            }

            //processing
            if (rBtnOutputYearly.Checked)
            {
                output = monthlyInput * 12;
                label10.Text = "per year";
            }
            else if (rBtnOutputMonthly.Checked)
            {
                output = monthlyInput;
                label10.Text = "per month";
            }
            else if (rBtnOutputWeekly.Checked)
            {
                output = (monthlyInput * 12) / 52;
                label10.Text = "per week";
            }
            else if (rBtnOutputDaily.Checked)
            {
                output = monthlyInput / 21.67;
                label10.Text = "per day";
            }
            else if (rBtnOutputHourly.Checked)
            {
                //hourly input
                DateTime outputStart = timeOutputStart.Value;
                DateTime outputEnd = timeOutputEnd.Value;
                DateTime outputMeal = timeOutputMeal.Value;

                //hourly processing
                int outputHoursWorked = outputEnd.Hour - outputStart.Hour;
                int outputMinutesWorked = outputEnd.Minute - outputStart.Minute;
                int outputHoursMeal = outputMeal.Hour;
                int outputMinutesMeal = outputMeal.Minute;

                Double outputMealTime = outputHoursMeal - (outputMinutesMeal / 60.00);
                Double outputWorkedTime = outputHoursWorked - (outputMinutesWorked / 60.00);
                if (outputWorkedTime < 0)
                {
                    outputWorkedTime += 24;
                }
                outputWorkedTime -= outputMealTime;

                //hourly output
                if (outputStart == outputEnd)
                {
                    MessageBox.Show("Your start and end times cannot be the same", "Output error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (chkBoxOutputMealtime.Checked && outputWorkedTime <= 0)
                {
                    MessageBox.Show("Your meal time cannot be more than your working time", "Output error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    output = (monthlyInput / 21.67) / outputWorkedTime;
                    if (chkBoxOutputMealtime.Checked)
                    {
                        label10.Text = "per hour excluding meal time";
                    } else
                    {
                        label10.Text = "per hour";
                    }
                }
            } else
            {
                MessageBox.Show("You have to select an option to calculate", "Output error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //output
            txtBoxOutput.Text = output.ToString("C2");
        }
    }
}
