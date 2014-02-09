using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace sw_Timer
{
	public partial class MainWin : Form
	{
		bool Running;
		DateTime EndTime;
		TimeSpan Duration;

		public MainWin()
		{
			InitializeComponent();
		}
		private void tmrMain_Tick(object sender, EventArgs e)
		{
			if ( !Running ) return;
			TimeSpan timeLeft = EndTime - DateTime.Now;
			txtHours.Text = timeLeft.Hours.ToString();
			txtMinutes.Text = timeLeft.Minutes.ToString();
			txtSeconds.Text = timeLeft.Seconds.ToString();
			if ( timeLeft > TimeSpan.Zero ) return;
			for ( int i = 0; i < 1000; i++ )
			{ SystemSounds.Beep.Play(); }
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
		}
		private void btnSound_Click(object sender, EventArgs e)
		{
			openFileSound.ShowDialog();
		}
	}
}
