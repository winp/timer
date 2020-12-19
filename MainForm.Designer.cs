namespace Timer
{
	partial class MainForm
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
			if ( disposing && (components != null) )
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.TimerMain = new System.Windows.Forms.Timer(this.components);
      this.THours = new System.Windows.Forms.TextBox();
      this.LHours = new System.Windows.Forms.Label();
      this.LMinutes = new System.Windows.Forms.Label();
      this.LSeconds = new System.Windows.Forms.Label();
      this.TMinutes = new System.Windows.Forms.TextBox();
      this.TSeconds = new System.Windows.Forms.TextBox();
      this.FileSound = new System.Windows.Forms.OpenFileDialog();
      this.BStart = new System.Windows.Forms.Button();
      this.BStop = new System.Windows.Forms.Button();
      this.BSound = new System.Windows.Forms.Button();
      this.LMessage = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // TimerMain
      // 
      this.TimerMain.Enabled = true;
      this.TimerMain.Tick += new System.EventHandler(this.TimerMain_Tick);
      // 
      // THours
      // 
      this.THours.Font = new System.Drawing.Font("Calibri Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.THours.Location = new System.Drawing.Point(21, 62);
      this.THours.Name = "THours";
      this.THours.Size = new System.Drawing.Size(93, 86);
      this.THours.TabIndex = 0;
      this.THours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.THours.TextChanged += new System.EventHandler(this.THours_TextChanged);
      // 
      // LHours
      // 
      this.LHours.AutoSize = true;
      this.LHours.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LHours.Location = new System.Drawing.Point(12, 9);
      this.LHours.Name = "LHours";
      this.LHours.Size = new System.Drawing.Size(114, 50);
      this.LHours.TabIndex = 1;
      this.LHours.Text = "Hours";
      // 
      // LMinutes
      // 
      this.LMinutes.AutoSize = true;
      this.LMinutes.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LMinutes.Location = new System.Drawing.Point(132, 9);
      this.LMinutes.Name = "LMinutes";
      this.LMinutes.Size = new System.Drawing.Size(145, 50);
      this.LMinutes.TabIndex = 2;
      this.LMinutes.Text = "Minutes";
      // 
      // LSeconds
      // 
      this.LSeconds.AutoSize = true;
      this.LSeconds.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LSeconds.Location = new System.Drawing.Point(283, 9);
      this.LSeconds.Name = "LSeconds";
      this.LSeconds.Size = new System.Drawing.Size(151, 50);
      this.LSeconds.TabIndex = 3;
      this.LSeconds.Text = "Seconds";
      // 
      // TMinutes
      // 
      this.TMinutes.Font = new System.Drawing.Font("Calibri Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.TMinutes.Location = new System.Drawing.Point(141, 62);
      this.TMinutes.Name = "TMinutes";
      this.TMinutes.Size = new System.Drawing.Size(123, 86);
      this.TMinutes.TabIndex = 4;
      this.TMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.TMinutes.TextChanged += new System.EventHandler(this.TMinutes_TextChanged);
      // 
      // TSeconds
      // 
      this.TSeconds.Font = new System.Drawing.Font("Calibri Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.TSeconds.Location = new System.Drawing.Point(292, 62);
      this.TSeconds.Name = "TSeconds";
      this.TSeconds.Size = new System.Drawing.Size(129, 86);
      this.TSeconds.TabIndex = 5;
      this.TSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.TSeconds.TextChanged += new System.EventHandler(this.TSeconds_TextChanged);
      // 
      // FileSound
      // 
      this.FileSound.FileName = "FileSound";
      this.FileSound.Filter = "All Files|*.*";
      // 
      // BStart
      // 
      this.BStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BStart.Location = new System.Drawing.Point(21, 175);
      this.BStart.Name = "BStart";
      this.BStart.Size = new System.Drawing.Size(93, 65);
      this.BStart.TabIndex = 6;
      this.BStart.Text = "Start";
      this.BStart.UseVisualStyleBackColor = true;
      this.BStart.Click += new System.EventHandler(this.BStart_Click);
      // 
      // BStop
      // 
      this.BStop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BStop.Location = new System.Drawing.Point(141, 175);
      this.BStop.Name = "BStop";
      this.BStop.Size = new System.Drawing.Size(123, 65);
      this.BStop.TabIndex = 7;
      this.BStop.Text = "Stop";
      this.BStop.UseVisualStyleBackColor = true;
      this.BStop.Click += new System.EventHandler(this.BStop_Click);
      // 
      // BSound
      // 
      this.BSound.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BSound.Location = new System.Drawing.Point(292, 175);
      this.BSound.Name = "BSound";
      this.BSound.Size = new System.Drawing.Size(129, 65);
      this.BSound.TabIndex = 8;
      this.BSound.Text = "Sound";
      this.BSound.UseVisualStyleBackColor = true;
      this.BSound.Click += new System.EventHandler(this.BSound_Click);
      // 
      // LMessage
      // 
      this.LMessage.AutoSize = true;
      this.LMessage.Location = new System.Drawing.Point(12, 260);
      this.LMessage.Name = "LMessage";
      this.LMessage.Size = new System.Drawing.Size(10, 13);
      this.LMessage.TabIndex = 9;
      this.LMessage.Text = " ";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(446, 283);
      this.Controls.Add(this.LMessage);
      this.Controls.Add(this.BSound);
      this.Controls.Add(this.BStop);
      this.Controls.Add(this.BStart);
      this.Controls.Add(this.TSeconds);
      this.Controls.Add(this.TMinutes);
      this.Controls.Add(this.LSeconds);
      this.Controls.Add(this.LMinutes);
      this.Controls.Add(this.LHours);
      this.Controls.Add(this.THours);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "MainForm";
      this.Text = "Timer";
      this.ResumeLayout(false);
      this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Timer TimerMain;
		private System.Windows.Forms.TextBox THours;
		private System.Windows.Forms.Label LHours;
		private System.Windows.Forms.Label LMinutes;
		private System.Windows.Forms.Label LSeconds;
		private System.Windows.Forms.TextBox TMinutes;
		private System.Windows.Forms.TextBox TSeconds;
		private System.Windows.Forms.OpenFileDialog FileSound;
		private System.Windows.Forms.Button BStart;
		private System.Windows.Forms.Button BStop;
		private System.Windows.Forms.Button BSound;
		private System.Windows.Forms.Label LMessage;
	}
}

