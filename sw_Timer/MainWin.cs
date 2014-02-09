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
		DateTime StartTime;
		TimeSpan Duration;

		public MainWin()
		{
			InitializeComponent();
		}
		private void tmrMain_Tick(object sender, EventArgs e)
		{
			if ( !Running ) return;
		}
		private void btnStart_Click(object sender, EventArgs e)
		{
			if ( Running ) return;
			try
			{
				StartTime = DateTime.Now;
				int hours = int.Parse(txtHours.Text);
				int minutes = int.Parse(txtMinutes.Text);
				int seconds = int.Parse(txtMinutes.Text);
				Duration = new TimeSpan(hours, minutes, seconds);
				Running = true;
			}
			catch ( Exception )
			{ lblMessage.Text = "Invalid Time"; }
		}
		private void btnStop_Click(object sender, EventArgs e)
		{

		}
		private void btnSound_Click(object sender, EventArgs e)
		{
			openFileSound.ShowDialog();
		}
	}
}
