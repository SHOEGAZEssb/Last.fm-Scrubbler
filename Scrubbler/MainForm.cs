using System;
using System.Windows.Forms;
using IF.Lastfm.Core.Api;
using IF.Lastfm.Core.Objects;
using IF.Lastfm.Core.Scrobblers;

namespace Scrubbler
{
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

    private void linkLabelStatus_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      LoginForm lf = new LoginForm(_client);
      lf.ShowDialog();
      if (_client.Auth.Authenticated)
      {
        linkLabelStatus.Text = "Logged in";
        _scrobbler = new Scrobbler(_client.Auth);
        btnScrobble.Enabled = true;
      }
      else
      {
        linkLabelStatus.Text = "Not logged in";
        btnScrobble.Enabled = false;
      }
    }

    private async void btnScrobble_Click(object sender, EventArgs e)
    {
      lblScrobbleStatusInfo.Text = "Trying to scrobble.";  
      dateTimePicker1.Value = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, dateTimePicker2.Value.Hour, dateTimePicker2.Value.Minute, dateTimePicker2.Value.Second);
      Scrobble s = new Scrobble(textBoxArtist.Text, textBoxAlbum.Text, textBoxTrack.Text, dateTimePicker1.Value);
      var response = await _scrobbler.ScrobbleAsync(s);
      if(response.Success)
        lblScrobbleStatusInfo.Text = "Successfully scrobbled.";
      else
        lblScrobbleStatusInfo.Text = "Failed to scrobble.";
    }

    private void btnNow_Click(object sender, EventArgs e)
    {
      dateTimePicker1.MaxDate = DateTime.Now;
      dateTimePicker2.Value = DateTime.Now;
    }
  }
}
