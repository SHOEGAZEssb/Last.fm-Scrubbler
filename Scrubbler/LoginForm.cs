using IF.Lastfm.Core.Api;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scrubbler
{
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

    private async void Login(object sender, EventArgs e)
    {
      var response = await _client.Auth.GetSessionTokenAsync(textBoxUsername.Text, textBoxPassword.Text);
      if (_client.Auth.Authenticated)
      {
        MessageBox.Show("Successfully logged in and authenticated.");
        this.Close();
      }
      else
        MessageBox.Show("Failed to login or to authenticate.");
    }
  }
}
