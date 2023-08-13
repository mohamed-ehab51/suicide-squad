using System.Diagnostics;
using System.Text.RegularExpressions;
using WMPLib;


namespace suicide_squade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string videopath = "";
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Video files (*.mp4, *.avi, *.mov, *.wmv, *.flv, *.mkv, *.mpeg, *.mpg, *.rmvb, *.3g2)|*.mp4;*.avi;*.mov;*.wmv;*.flv;*.mkv;*.mpeg;*.mpg;*.rmvb;*.3g2";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                videopath = openFileDialog1.FileName;
                label9.Text = openFileDialog1.FileName;
            }
        }

        string outpath = "";
        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                outpath = folderBrowserDialog1.SelectedPath;
                label10.Text = folderBrowserDialog1.SelectedPath;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Boolean go = false;
            Boolean go2 = false;
            string fileName = textBox1.Text;
            fileName = fileName.Trim();
            if (fileName.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0 || fileName.Equals(""))
            {
                MessageBox.Show("please enter valid video name");
                return;
            }
            else
            {
                go = true;
            }
            string[] allowedExtensions = new string[] { "mp4", "avi", "mov", "wmv", "flv", "mkv", "mpeg", "mpg", "rmvb", "3g2", ".mp4", ".avi", ".mov", ".wmv", ".flv", ".mkv", ".mpeg", ".mpg", ".rmvb", ".3g2" };
            string fileExtension = textBox2.Text;
            if (allowedExtensions.Contains(fileExtension))
            {
                go2 = true;
            }
            else
            {
                MessageBox.Show("please enter valid video extension");
                return;
            }
            if (fileExtension[0] == '.')
            { fileExtension = fileExtension[1..]; }
            label11.Text = fileName + "." + fileExtension;
            fileName = fileName + "." + fileExtension;
            fileName = fileName.Trim();
            if (outpath != "" && videopath != "" && go && go2)
            {
                Boolean enter = true;
                label1.Text = "0 %";
                string filePath = videopath;
                string filePathy = outpath + "\\" + fileName;

                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = $"/c ffmpeg -i \"{filePath}\" \"{filePathy}\"";
                startInfo.RedirectStandardError = true;
                startInfo.UseShellExecute = false;
                startInfo.CreateNoWindow = true;
                progressBar1.Minimum = 0;
                progressBar1.Maximum = 100;
                progressBar1.Value = 0;

                var player = new WindowsMediaPlayer();
                var clip = player.newMedia(filePath);
                double durationInSeconds = clip.duration;

                Process process = new Process();
                process.StartInfo = startInfo;
                process.ErrorDataReceived += (sender, e) =>
                {
                    if (!string.IsNullOrEmpty(e.Data))
                    {
                        // Extract the progress information from the output
                        Match match = Regex.Match(e.Data, @"time=([0-9:.]+)");
                        if (match.Success)
                        {
                            string timeString = match.Groups[1].Value;
                            TimeSpan timeSpan = TimeSpan.Parse(timeString);
                            double totalSeconds = timeSpan.TotalSeconds;
                            double prog = totalSeconds / durationInSeconds;
                            prog *= 100;
                            if (prog >= 100) { prog = 100; }
                            progressBar1.Invoke(new Action(() => progressBar1.Value = (int)prog));
                            label1.Invoke(new Action(() => label1.Text = $"{(int)prog} %"));
                            if (progressBar1.Value == 100&&enter)
                            {
                                MessageBox.Show("Conversion complete!");
                                enter = false;
                            }
                        }
                    }
                };
                process.Start();
                process.BeginErrorReadLine();

            }
            else
            {
                MessageBox.Show("please check you inputs and try again");
                return;
            }



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}