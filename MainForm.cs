using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using WMPLib;


namespace Timer {
  public partial class MainForm : Form {

    bool      Running;
    DateTime  EndTime;
    TimeSpan  Duration;
    WindowsMediaPlayer Player = new WindowsMediaPlayer();

    readonly string PAPP = "extra-timer";
    readonly string PSETTINGS = "settings.ini";
    readonly string PSOUND = "Default.wav";

    readonly Color CALERT = Color.LightCoral;
    readonly Color CMARK  = Color.LightSeaGreen;
    readonly Color CDEF   = default;


    public MainForm() {
      InitializeComponent();
      LoadSettings();
      SetValue(new TimeSpan(0, 0, 10));
      if (UpdateSoundColor())
        UpdateValueColor();
    }

    private void TimerMain_Tick(object sender, EventArgs e) {
      if (!Running) return;
      TimeSpan left = EndTime - DateTime.Now;
      SetValue(left + TimeSpan.FromSeconds(1));
      if (left > TimeSpan.Zero) return;
      try {
        Player.URL = FileSound.FileName;
        Player.controls.play();
        SetValue(TimeSpan.Zero);
        SetValueColor(CALERT);
        BStop.BackColor = CMARK;
      }
      catch (Exception) {}
      Running = false;
    }

    private void BStart_Click(object sender, EventArgs e) {
      if (Running) return;
      try {
        Duration = GetValue();
        EndTime = DateTime.Now + Duration;
        Running = true;
      }
      catch (Exception)
      { LMessage.Text = "Invalid Time"; }
    }

    private void BStop_Click(object sender, EventArgs e) {
      Running = false;
      Player.controls.stop();
      BStop.BackColor = CDEF;
      SetValueColor(CDEF);
    }

    private void BSound_Click(object sender, EventArgs e) {
      FileSound.ShowDialog();
      if (!File.Exists(FileSound.FileName))
        return;
      SaveSettings();
      BSound.BackColor = CDEF;
      UpdateValueColor();
    }

    private void LoadSettings() {
      string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
      string settings = Path.Combine(docs, PAPP, PSETTINGS);
      if (File.Exists(settings))
        FileSound.FileName = File.ReadAllText(settings);
      else if (File.Exists(PSOUND))
        FileSound.FileName = PSOUND;
    }

    private void SaveSettings() {
      string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
      string app = Path.Combine(docs, PAPP);
      if(!Directory.Exists(app))
        Directory.CreateDirectory(app);
      string settings = Path.Combine(app, PSETTINGS);
      File.WriteAllText(settings, FileSound.FileName);
    }

    private bool UpdateValueColor() {
      bool ok = GetValue() == TimeSpan.Zero;
      SetValueColor(ok ? CALERT : CDEF);
      return ok;
    }

    private bool UpdateSoundColor() {
      bool ok = File.Exists(FileSound.FileName);
      BSound.BackColor = ok ? CDEF : CALERT;
      return ok;
    }

    private TimeSpan GetValue() {
      int.TryParse(THours.Text, out int hours);
      int.TryParse(TMinutes.Text, out int minutes);
      int.TryParse(TSeconds.Text, out int seconds);
      return new TimeSpan(hours, minutes, seconds);
    }

    private void SetValue(TimeSpan x) {
      THours.Text = x.Hours.ToString();
      TMinutes.Text = x.Minutes.ToString();
      TSeconds.Text = x.Seconds.ToString();
    }
    private void SetValueColor(Color c) {
      THours.BackColor = c;
      TMinutes.BackColor = c;
      TSeconds.BackColor = c;
    }

    private void THours_TextChanged(object sender, EventArgs e) {
      bool ok = int.TryParse(THours.Text, out int hours);
      THours.BackColor = ok && hours >= 0 ? CDEF : CALERT;
    }

    private void TMinutes_TextChanged(object sender, EventArgs e) {
      bool ok = int.TryParse(TMinutes.Text, out int minutes);
      TMinutes.BackColor = ok && minutes >= 0 ? CDEF : CALERT;
    }

    private void TSeconds_TextChanged(object sender, EventArgs e) {
      bool ok = int.TryParse(TSeconds.Text, out int seconds);
      TSeconds.BackColor = ok && seconds >= 0 ? CDEF : CALERT;
    }
  }
}
