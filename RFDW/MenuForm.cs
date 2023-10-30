using Microsoft.VisualBasic.ApplicationServices;
using NAudio.Wave;
using RFDW.Properties;
using System.Drawing.Drawing2D;
using System.Media;
using System.Windows.Forms;


namespace RFDW
{
    public partial class MenuForm : Form
    {
        //private WaveOutEvent outputDevice;
        //private AudioFileReader audioFile;
        public MenuForm()
        {
            InitializeComponent();

            Console.Write("Это информация\nДЛЯ РОЗРОБОЧИКОВ!\nВсё равно не закрывайте консоль!!! (Игра крашнется)\n");

            //if (outputDevice == null)
            //{
            //    outputDevice = new WaveOutEvent();
            //}
            //if (audioFile == null)
            //{
            //    //audioFile = new AudioFileReader(@"C:\Users\8855\source\repos\RFDW\RFDW\Resources\Adventure.mp3");
            //    //outputDevice.Init(audioFile);
            //}
            ////outputDevice.Play();
        }
        SettingsForm settFrm = new();

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            if (settFrm != null && !settFrm.IsDisposed && settFrm.Visible)
            {
                settFrm.Close();
                return;
            }
            if (settFrm == null || settFrm.IsDisposed) settFrm = new SettingsForm();
            settFrm.Show();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            GameForm gameFrm = new();
            Dispose(false);
            gameFrm.Show();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonEditor_Click(object sender, EventArgs e)
        {
            EditorForm edtrFrm = new();
            //Dispose(false);
            edtrFrm.Show();
        }

        private void buttonConsole_Click(object sender, EventArgs e)
        {
            GameForm2 testFrm = new();
            Dispose(false);
            testFrm.Show();
        }
    }
}