using IF.Lastfm.Core.Api;
using System;
using System.Windows.Forms;

namespace Scrubbler
{
  /// <summary>
  /// Windows form used to log in.
  /// </summary>
  public partial class LoginForm : Form
  {
    private LastfmClient _client;

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="client">Client to login.</param>
    public LoginForm(LastfmClient client)
    {
      InitializeComponent();
      _client = client;
    }

    /// <summary>
    /// Tries to log the client in with the given username and password.
    /// </summary>
    private async void Login(object sender, EventArgs e)
    {
      btnLogin.Enabled = false;
      var response = await _client.Auth.GetSessionTokenAsync(textBoxUsername.Text, textBoxPassword.Text);
      if (_client.Auth.Authenticated)
      {
        MessageBox.Show("Successfully logged in and authenticated.");
        this.Close();
      }
      else
      {
        MessageBox.Show("Failed to login or to authenticate.");
        btnLogin.Enabled = true;
      }
    }

    /// <summary>
    /// Checks if the user pressed the enter key in one of the textBoxes and if yes, tries to log in.
    /// </summary>
    private void textBoxUsername_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar == (char)13)
        Login(sender, e);
    }
  }
}