namespace sw_Timer
{
	partial class MainWin
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
			this.tmrMain = new System.Windows.Forms.Timer(this.components);
			this.txtHours = new System.Windows.Forms.TextBox();
			this.lblHours = new System.Windows.Forms.Label();
			this.lblMinutes = new System.Windows.Forms.Label();
			this.lblSeconds = new System.Windows.Forms.Label();
			this.txtMinutes = new System.Windows.Forms.TextBox();
			this.txtSeconds = new System.Windows.Forms.TextBox();
			this.openFileSound = new System.Windows.Forms.OpenFileDialog();
			this.btnStart = new System.Windows.Forms.Button();
			this.btnStop = new System.Windows.Forms.Button();
			this.btnSound = new System.Windows.Forms.Button();
			this.lblMessage = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// tmrMain
			// 
			this.tmrMain.Enabled = true;
			this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
			// 
			// txtHours
			// 
			this.txtHours.Font = new System.Drawing.Font("Calibri Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtHours.Location = new System.Drawing.Point(21, 62);
			this.txtHours.Name = "txtHours";
			this.txtHours.Size = new System.Drawing.Size(93, 86);
			this.txtHours.TabIndex = 0;
			this.txtHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblHours
			// 
			this.lblHours.AutoSize = true;
			this.lblHours.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHours.Location = new System.Drawing.Point(12, 9);
			this.lblHours.Name = "lblHours";
			this.lblHours.Size = new System.Drawing.Size(114, 50);
			this.lblHours.TabIndex = 1;
			this.lblHours.Text = "Hours";
			// 
			// lblMinutes
			// 
			this.lblMinutes.AutoSize = true;
			this.lblMinutes.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMinutes.Location = new System.Drawing.Point(132, 9);
			this.lblMinutes.Name = "lblMinutes";
			this.lblMinutes.Size = new System.Drawing.Size(145, 50);
			this.lblMinutes.TabIndex = 2;
			this.lblMinutes.Text = "Minutes";
			// 
			// lblSeconds
			// 
			this.lblSeconds.AutoSize = true;
			this.lblSeconds.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSeconds.Location = new System.Drawing.Point(283, 9);
			this.lblSeconds.Name = "lblSeconds";
			this.lblSeconds.Size = new System.Drawing.Size(151, 50);
			this.lblSeconds.TabIndex = 3;
			this.lblSeconds.Text = "Seconds";
			// 
			// txtMinutes
			// 
			this.txtMinutes.Font = new System.Drawing.Font("Calibri Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMinutes.Location = new System.Drawing.Point(141, 62);
			this.txtMinutes.Name = "txtMinutes";
			this.txtMinutes.Size = new System.Drawing.Size(123, 86);
			this.txtMinutes.TabIndex = 4;
			this.txtMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtSeconds
			// 
			this.txtSeconds.Font = new System.Drawing.Font("Calibri Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSeconds.Location = new System.Drawing.Point(292, 62);
			this.txtSeconds.Name = "txtSeconds";
			this.txtSeconds.Size = new System.Drawing.Size(129, 86);
			this.txtSeconds.TabIndex = 5;
			this.txtSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// openFileSound
			// 
			this.openFileSound.FileName = "openFileSound";
			this.openFileSound.Filter = "All Files|*.*";
			// 
			// btnStart
			// 
			this.btnStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStart.Location = new System.Drawing.Point(21, 175);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(93, 65);
			this.btnStart.TabIndex = 6;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// btnStop
			// 
			this.btnStop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStop.Location = new System.Drawing.Point(141, 175);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(123, 65);
			this.btnStop.TabIndex = 7;
			this.btnStop.Text = "Stop";
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// btnSound
			// 
			this.btnSound.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSound.Location = new System.Drawing.Point(292, 175);
			this.btnSound.Name = "btnSound";
			this.btnSound.Size = new System.Drawing.Size(129, 65);
			this.btnSound.TabIndex = 8;
			this.btnSound.Text = "Sound";
			this.btnSound.UseVisualStyleBackColor = true;
			this.btnSound.Click += new System.EventHandler(this.btnSound_Click);
			// 
			// lblMessage
			// 
			this.lblMessage.AutoSize = true;
			this.lblMessage.Location = new System.Drawing.Point(12, 260);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(10, 13);
			this.lblMessage.TabIndex = 9;
			this.lblMessage.Text = " ";
			// 
			// MainWin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(446, 283);
			this.Controls.Add(this.lblMessage);
			this.Controls.Add(this.btnSound);
			this.Controls.Add(this.btnStop);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.txtSeconds);
			this.Controls.Add(this.txtMinutes);
			this.Controls.Add(this.lblSeconds);
			this.Controls.Add(this.lblMinutes);
			this.Controls.Add(this.lblHours);
			this.Controls.Add(this.txtHours);
			this.Name = "MainWin";
			this.Text = "Timer";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Timer tmrMain;
		private System.Windows.Forms.TextBox txtHours;
		private System.Windows.Forms.Label lblHours;
		private System.Windows.Forms.Label lblMinutes;
		private System.Windows.Forms.Label lblSeconds;
		private System.Windows.Forms.TextBox txtMinutes;
		private System.Windows.Forms.TextBox txtSeconds;
		private System.Windows.Forms.OpenFileDialog openFileSound;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.Button btnSound;
		private System.Windows.Forms.Label lblMessage;
	}
}

