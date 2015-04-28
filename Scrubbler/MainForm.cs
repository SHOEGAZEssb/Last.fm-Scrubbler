using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IF.Lastfm.Core.Api;
using IF.Lastfm.Core.Objects;

namespace Scrubbler
{
  public partial class MainForm : Form
  {
    private LastfmClient _client;
    private const string APIKEY = "a3629265939bfe7b7e631768118933bd";
    private const string APISECRET = "9857e9c9916a5e2c327a160d1d49d457";

    /// <summary>
    /// Constructor. Creates the client.
    /// </summary>
    public MainForm()
    {
      InitializeComponent();
      _client = new LastfmClient(APIKEY, APISECRET);
    }
  }
}
