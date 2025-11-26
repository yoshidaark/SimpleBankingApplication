using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace SimpleBankingApplication
{
    public partial class OTPForm : Form
    {

        private string otp;
        private System.Windows.Forms.Timer timer;
        private int otpCountdown = 60;
        public OTPForm() // make label to link label to copy it to the clipboard
                        // make the otp time bounded
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; 
            timer.Tick += Tick_Timer;
            timer.Start();
            this.FormClosing += OTPForm_FormClosing;
        }

        public void Tick_Timer(object sender, EventArgs e)
        {
            if (otpCountdown > 0)
            {
                otpCountdown--;
                lblOTPTimer.Text = otpCountdown.ToString();
            }
            else {
                otpCountdown = 60;
                otp = string.Concat(generateOTP().Select(x => x.ToString())); //convert arr to string
                storeOTP(otp);
                linkLblOTP.Text = otp;
            }
        }

        public int[] generateOTP()
        {
            int[] arrOTP = new int[6];

            for (int i = 0; i < 6; i++)
            {
                Random random = new Random();
                int min = 0;
                int max = 9;
                int randomNum = random.Next(min, max);
                arrOTP[i] = randomNum;
                Thread.Sleep(1);
            }

            
            return arrOTP;
        }

        public void storeOTP(string otp) {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "OTP.txt");
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.Write(otp);
                    writer.WriteLine();// Write text to the file
                    writer.Flush();

                }

            }
            catch (IOException ex)  // Specific to I/O errors
            {
                Console.WriteLine($"I/O Error: {ex.Message}");
            }
        }

        private void OTPForm_Load(object sender, EventArgs e)
        {
            lblClipboard.Visible = false;
            lblOTPTimer.Text = otpCountdown.ToString();
            otp = string.Concat(generateOTP().Select(x => x.ToString())); //convert arr to string
            storeOTP(otp);
            linkLblOTP.Text = otp;
        }

        private void OTPForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            this.Dispose();
            timer.Stop();
        }

        private void linkLblOTP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblClipboard.Visible = true;
            Clipboard.SetText(otp);
            
        }

        
    }
}
