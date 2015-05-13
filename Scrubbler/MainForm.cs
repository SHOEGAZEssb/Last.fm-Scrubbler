using System;
using System.Windows.Forms;
using IF.Lastfm.Core.Api;
using IF.Lastfm.Core.Objects;
using IF.Lastfm.Core.Scrobblers;

namespace Scrubbler
{
  /// <summary>
  /// Form to enter track info and scrobble the track.
  /// </summary>
  public partial class MainForm : Form
  {
    private LastfmClient _client;
    private Scrobbler _scrobbler;
    private const string APIKEY = "a3629265939bfe7b7e631768118933bd";
    private const string APISECRET = "9857e9c9916a5e2c327a160d1d49d457";

    /// <summary>
    /// Constructor. Creates the client.
    /// </summary>
    public MainForm()
    {
      InitializeComponent();
      _client = new LastfmClient(APIKEY, APISECRET);
      dateTimePicker1.MinDate = dateTimePicker1.Value.AddDays(-14.0);
      dateTimePicker1.MaxDate = dateTimePicker1.Value;   
    }

    /// <summary>
    /// Opens the login form.
    /// </summary>
    private void linkLabelStatus_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      LoginForm lf = new LoginForm(_client);
      lf.ShowDialog();
      if (_client.Auth.Authenticated)
      {
        linkLabelStatus.Text = "Logged in as " + _client.Auth.UserSession.Username;
        _scrobbler = new Scrobbler(_client.Auth);
        btnScrobble.Enabled = true;
      }
      else
      {
        linkLabelStatus.Text = "Not logged in";
        btnScrobble.Enabled = false;
      }
    }

    /// <summary>
    /// Scrobbles the track entered in the textBoxes.
    /// </summary>
    private async void btnScrobble_Click(object sender, EventArgs e)
    {
      UpdateTimes(sender, e);
      lblScrobbleStatusInfo.Text = "Trying to scrobble.";  
      dateTimePicker1.Value = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, dateTimePicker2.Value.Hour, dateTimePicker2.Value.Minute, dateTimePicker2.Value.Second);
      Scrobble s = new Scrobble(textBoxArtist.Text, textBoxAlbum.Text, textBoxTrack.Text, dateTimePicker1.Value);
      var response = await _scrobbler.ScrobbleAsync(s);
      if(response.Success)
        lblScrobbleStatusInfo.Text = "Successfully scrobbled.";
      else
        lblScrobbleStatusInfo.Text = "Failed to scrobble.";
    }

    /// <summary>
    /// Updates the DateTimes.
    /// </summary>
    private void UpdateTimes(object sender, EventArgs e)
    {
      DateTime now = DateTime.Now;

      dateTimePicker1.MaxDate = now;
      dateTimePicker2.MaxDate = now;

      if (checkBoxCurrentTime.Checked)
      {
        dateTimePicker2.Value = now;
        dateTimePicker2.Enabled = false;
      }
      else
        dateTimePicker2.Enabled = true;
      if (checkBoxCurrentDate.Checked)
      {
        dateTimePicker1.Value = now;
        dateTimePicker1.Enabled = false;
      }
      else
        dateTimePicker1.Enabled = true;
    }
  }
}