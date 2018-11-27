using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyboardBiometrics
{
    public partial class RegisterForm : Form
    {
        bool isPasswordWritingStarted = false;
        DateTime startTime;
        DateTime pressStartTime;
        DateTime seekStartTime;
        int errorsCount;
        List<int> totalTimeList = new List<int>();
        List<int> pressTimeList = new List<int>();
        List<int> seekTimeList = new List<int>();
        List<int> errorsCountList = new List<int>();


        public RegisterForm()
        {
            InitializeComponent();
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            KeyboardBiometrics keyboardBiometrics = new KeyboardBiometrics();
            this.Hide();
            keyboardBiometrics.Show();
        }

        private void ClearData()
        {
            totalTimeList.Clear();
            pressTimeList.Clear();
            seekTimeList.Clear();
            errorsCountList.Clear();
        }

        private void AddRowToDataBase(string login, string pass, double totaltime, double presstime, double seektime, double errors)
        {
            // KeyboardBiometricsDatabaseDataSet db = new KeyboardBiometricsDatabaseDataSet();

            //Console.WriteLine(db.DataSetName);
            //KeyboardBiometricsDatabaseConnectionString
        }

        private void loginBox_Click(object sender, EventArgs e)
        {
            loginBox.Clear();
        }
        
        private void pass1Box_TextChanged(object sender, EventArgs e)
        {
            pass1Box.Clear();
        }

        private void pass2Box_TextChanged(object sender, EventArgs e)
        {
            pass2Box.Clear();
        }

        private void submitRegisterButton_Click(object sender, EventArgs e)
        {
            if(pass1Box.Text.Length < 12)
            {
                pass1Box.Text = "Password is too short";
            }
            else if(pass1Box.Text != pass2Box.Text)
            {
                ClearData();
                pass1Box.Text = "Passwords must match";
                pass2Box.Text = "Passwords must match";

            }
            else if (loginBox.Text == null || loginBox.Text == "")
            {
                loginBox.Text = "Login cannot be empty";
            }
            else
            {
                var averageTotalTime = totalTimeList.Average();
                Console.WriteLine(averageTotalTime);
                var averagePressTime = pressTimeList.Average();
                Console.WriteLine(averagePressTime);
                var averageSeekTime = seekTimeList.Average();
                Console.WriteLine(averageSeekTime);
                var averageErrorsCount = errorsCountList.Average();
                Console.WriteLine(averageErrorsCount);
                AddRowToDataBase(loginBox.Text, pass1Box.Text, averageTotalTime, averagePressTime, averageSeekTime, averageErrorsCount);
            }

        }

        private void pass1Box_KeyDown(object sender, KeyEventArgs e)
        {
            pressStartTime = DateTime.Now;
            
            if (isPasswordWritingStarted && e.KeyCode != Keys.ShiftKey && e.KeyCode != Keys.Menu && e.KeyCode != Keys.ControlKey && e.KeyCode != Keys.Tab && e.KeyCode != Keys.Back)
            {
                var totalSeekTime = DateTime.Now - seekStartTime;

                var totalMilisecondsTime = (int)totalSeekTime.TotalMilliseconds;
                if (totalMilisecondsTime < 0) totalMilisecondsTime = 0;
                seekTimeList.Add(totalMilisecondsTime);
            }
            else
            {
                startTime = pressStartTime;

                if (e.KeyCode != Keys.ShiftKey && e.KeyCode != Keys.Menu && e.KeyCode != Keys.ControlKey && e.KeyCode != Keys.Tab && e.KeyCode != Keys.Back)
                {
                    isPasswordWritingStarted = true;
                }
            }

            if(e.KeyCode == Keys.Back)
            {
                errorsCount++;
            }
        }

        private void pass1Box_Leave(object sender, EventArgs e)
        {
            isPasswordWritingStarted = false;
            var totalTime = DateTime.Now - startTime;
            var totalMilisecondsTime = (int)totalTime.TotalMilliseconds;
            totalTimeList.Add(totalMilisecondsTime);
            errorsCountList.Add(errorsCount);
        }

        private void pass1Box_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode != Keys.ShiftKey && e.KeyCode != Keys.Menu && e.KeyCode != Keys.ControlKey && e.KeyCode != Keys.Tab && e.KeyCode != Keys.Back)
            {
                seekStartTime = DateTime.Now;
            }
            var totalPressTime = DateTime.Now - pressStartTime;
            var totalMilisecondsTime = (int)totalPressTime.TotalMilliseconds;
            pressTimeList.Add(totalMilisecondsTime);
        }
    }
}
