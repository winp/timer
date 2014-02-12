using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WMPLib;

namespace sw_Timer
{
	public partial class MainWin : Form
	{
		bool Running;
		DateTime EndTime;
		TimeSpan Duration;
		WindowsMediaPlayer wPlayer = new WindowsMediaPlayer();

		public MainWin()
		{
			InitializeComponent();
			LoadSettings();
		}
		private void tmrMain_Tick(object sender, EventArgs e)
		{
			if ( !Running ) return;
			TimeSpan timeLeft = EndTime - DateTime.Now;
			txtHours.Text = timeLeft.Hours.ToString();
			txtMinutes.Text = timeLeft.Minutes.ToString();
			txtSeconds.Text = (timeLeft.Seconds + 1).ToString();
			if ( timeLeft > TimeSpan.Zero ) return;
			try
			{
				wPlayer.URL = openFileSound.FileName;
				wPlayer.controls.play();
				txtSeconds.Text = "0";
			}
			catch ( Exception ) { }
			Running = false;
		}
		private void btnStart_Click(object sender, EventArgs e)
		{
			if ( Running ) return;
			try
			{
				int hours = int.Parse(txtHours.Text);
				int minutes = int.Parse(txtMinutes.Text);
				int seconds = int.Parse(txtSeconds.Text);
				Duration = new TimeSpan(hours, minutes, seconds);
				EndTime = DateTime.Now + Duration;
				Running = true;
			}
			catch ( Exception )
			{ lblMessage.Text = "Invalid Time"; }
		}
		private void btnStop_Click(object sender, EventArgs e)
		{
			Running = false;
			wPlayer.controls.stop();
		}
		private void btnSound_Click(object sender, EventArgs e)
		{
			openFileSound.ShowDialog();
			SaveSettings();
		}
		private void LoadSettings()
		{
			string myDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			string myAppSettings = Path.Combine(myDocs, "Timer\\settings.ini");
			if ( File.Exists(myAppSettings) )
				openFileSound.FileName = File.ReadAllText(myAppSettings);
			else
				openFileSound.FileName = "Sound\\def_sound.wav";
		}
		private void SaveSettings()
		{
			string settings = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			settings = Path.Combine(settings, "Timer");
			if(!Directory.Exists(settings))
				Directory.CreateDirectory(settings);
			settings = Path.Combine(settings, "settings.ini");
			File.WriteAllText(settings, openFileSound.FileName);
		}
	}
}
