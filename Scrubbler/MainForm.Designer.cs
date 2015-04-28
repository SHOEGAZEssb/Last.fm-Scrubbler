namespace Scrubbler
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
      if (disposing && (components != null))
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
      this.panelTopBar = new System.Windows.Forms.Panel();
      this.linkLabelStatus = new System.Windows.Forms.LinkLabel();
      this.lblLoginStatus = new System.Windows.Forms.Label();
      this.panelScrobble = new System.Windows.Forms.Panel();
      this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
      this.lblTime = new System.Windows.Forms.Label();
      this.lblDate = new System.Windows.Forms.Label();
      this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
      this.textBoxAlbum = new System.Windows.Forms.TextBox();
      this.lblAlbum = new System.Windows.Forms.Label();
      this.textBoxTrack = new System.Windows.Forms.TextBox();
      this.lblTrack = new System.Windows.Forms.Label();
      this.textBoxArtist = new System.Windows.Forms.TextBox();
      this.lblArtist = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.lblScrobbleStatusInfo = new System.Windows.Forms.Label();
      this.lblScrobbleStatus = new System.Windows.Forms.Label();
      this.btnScrobble = new System.Windows.Forms.Button();
      this.btnNow = new System.Windows.Forms.Button();
      this.panelTopBar.SuspendLayout();
      this.panelScrobble.SuspendLayout();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panelTopBar
      // 
      this.panelTopBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panelTopBar.Controls.Add(this.linkLabelStatus);
      this.panelTopBar.Controls.Add(this.lblLoginStatus);
      this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelTopBar.Location = new System.Drawing.Point(0, 0);
      this.panelTopBar.Name = "panelTopBar";
      this.panelTopBar.Size = new System.Drawing.Size(284, 21);
      this.panelTopBar.TabIndex = 2;
      // 
      // linkLabelStatus
      // 
      this.linkLabelStatus.AutoSize = true;
      this.linkLabelStatus.Location = new System.Drawing.Point(78, 3);
      this.linkLabelStatus.Name = "linkLabelStatus";
      this.linkLabelStatus.Size = new System.Drawing.Size(70, 13);
      this.linkLabelStatus.TabIndex = 3;
      this.linkLabelStatus.TabStop = true;
      this.linkLabelStatus.Text = "Not logged in";
      this.linkLabelStatus.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelStatus_LinkClicked);
      // 
      // lblLoginStatus
      // 
      this.lblLoginStatus.AutoSize = true;
      this.lblLoginStatus.Location = new System.Drawing.Point(3, 3);
      this.lblLoginStatus.Name = "lblLoginStatus";
      this.lblLoginStatus.Size = new System.Drawing.Size(69, 13);
      this.lblLoginStatus.TabIndex = 2;
      this.lblLoginStatus.Text = "Login Status:";
      // 
      // panelScrobble
      // 
      this.panelScrobble.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panelScrobble.Controls.Add(this.btnNow);
      this.panelScrobble.Controls.Add(this.dateTimePicker2);
      this.panelScrobble.Controls.Add(this.lblTime);
      this.panelScrobble.Controls.Add(this.lblDate);
      this.panelScrobble.Controls.Add(this.dateTimePicker1);
      this.panelScrobble.Controls.Add(this.textBoxAlbum);
      this.panelScrobble.Controls.Add(this.lblAlbum);
      this.panelScrobble.Controls.Add(this.textBoxTrack);
      this.panelScrobble.Controls.Add(this.lblTrack);
      this.panelScrobble.Controls.Add(this.textBoxArtist);
      this.panelScrobble.Controls.Add(this.lblArtist);
      this.panelScrobble.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelScrobble.Location = new System.Drawing.Point(0, 21);
      this.panelScrobble.Name = "panelScrobble";
      this.panelScrobble.Size = new System.Drawing.Size(284, 241);
      this.panelScrobble.TabIndex = 3;
      // 
      // dateTimePicker2
      // 
      this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
      this.dateTimePicker2.Location = new System.Drawing.Point(42, 108);
      this.dateTimePicker2.Name = "dateTimePicker2";
      this.dateTimePicker2.ShowUpDown = true;
      this.dateTimePicker2.Size = new System.Drawing.Size(148, 20);
      this.dateTimePicker2.TabIndex = 13;
      // 
      // lblTime
      // 
      this.lblTime.AutoSize = true;
      this.lblTime.Location = new System.Drawing.Point(3, 110);
      this.lblTime.Name = "lblTime";
      this.lblTime.Size = new System.Drawing.Size(33, 13);
      this.lblTime.TabIndex = 12;
      this.lblTime.Text = "Time:";
      // 
      // lblDate
      // 
      this.lblDate.AutoSize = true;
      this.lblDate.Location = new System.Drawing.Point(3, 85);
      this.lblDate.Name = "lblDate";
      this.lblDate.Size = new System.Drawing.Size(33, 13);
      this.lblDate.TabIndex = 11;
      this.lblDate.Text = "Date:";
      // 
      // dateTimePicker1
      // 
      this.dateTimePicker1.Location = new System.Drawing.Point(42, 82);
      this.dateTimePicker1.Name = "dateTimePicker1";
      this.dateTimePicker1.Size = new System.Drawing.Size(229, 20);
      this.dateTimePicker1.TabIndex = 10;
      // 
      // textBoxAlbum
      // 
      this.textBoxAlbum.Location = new System.Drawing.Point(42, 56);
      this.textBoxAlbum.Name = "textBoxAlbum";
      this.textBoxAlbum.Size = new System.Drawing.Size(229, 20);
      this.textBoxAlbum.TabIndex = 9;
      // 
      // lblAlbum
      // 
      this.lblAlbum.AutoSize = true;
      this.lblAlbum.Location = new System.Drawing.Point(3, 59);
      this.lblAlbum.Name = "lblAlbum";
      this.lblAlbum.Size = new System.Drawing.Size(39, 13);
      this.lblAlbum.TabIndex = 8;
      this.lblAlbum.Text = "Album:";
      // 
      // textBoxTrack
      // 
      this.textBoxTrack.Location = new System.Drawing.Point(42, 29);
      this.textBoxTrack.Name = "textBoxTrack";
      this.textBoxTrack.Size = new System.Drawing.Size(229, 20);
      this.textBoxTrack.TabIndex = 7;
      // 
      // lblTrack
      // 
      this.lblTrack.AutoSize = true;
      this.lblTrack.Location = new System.Drawing.Point(3, 32);
      this.lblTrack.Name = "lblTrack";
      this.lblTrack.Size = new System.Drawing.Size(38, 13);
      this.lblTrack.TabIndex = 6;
      this.lblTrack.Text = "Track:";
      // 
      // textBoxArtist
      // 
      this.textBoxArtist.Location = new System.Drawing.Point(42, 3);
      this.textBoxArtist.Name = "textBoxArtist";
      this.textBoxArtist.Size = new System.Drawing.Size(229, 20);
      this.textBoxArtist.TabIndex = 5;
      // 
      // lblArtist
      // 
      this.lblArtist.AutoSize = true;
      this.lblArtist.Location = new System.Drawing.Point(3, 6);
      this.lblArtist.Name = "lblArtist";
      this.lblArtist.Size = new System.Drawing.Size(33, 13);
      this.lblArtist.TabIndex = 4;
      this.lblArtist.Text = "Artist:";
      // 
      // panel1
      // 
      this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel1.Controls.Add(this.lblScrobbleStatusInfo);
      this.panel1.Controls.Add(this.lblScrobbleStatus);
      this.panel1.Controls.Add(this.btnScrobble);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel1.Location = new System.Drawing.Point(0, 231);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(284, 31);
      this.panel1.TabIndex = 4;
      // 
      // lblScrobbleStatusInfo
      // 
      this.lblScrobbleStatusInfo.AutoSize = true;
      this.lblScrobbleStatusInfo.Location = new System.Drawing.Point(161, 0);
      this.lblScrobbleStatusInfo.Name = "lblScrobbleStatusInfo";
      this.lblScrobbleStatusInfo.Size = new System.Drawing.Size(47, 13);
      this.lblScrobbleStatusInfo.TabIndex = 5;
      this.lblScrobbleStatusInfo.Text = "Nothing.";
      // 
      // lblScrobbleStatus
      // 
      this.lblScrobbleStatus.AutoSize = true;
      this.lblScrobbleStatus.Location = new System.Drawing.Point(81, 0);
      this.lblScrobbleStatus.Name = "lblScrobbleStatus";
      this.lblScrobbleStatus.Size = new System.Drawing.Size(85, 13);
      this.lblScrobbleStatus.TabIndex = 4;
      this.lblScrobbleStatus.Text = "Scrobble Status:";
      // 
      // btnScrobble
      // 
      this.btnScrobble.Dock = System.Windows.Forms.DockStyle.Left;
      this.btnScrobble.Enabled = false;
      this.btnScrobble.Location = new System.Drawing.Point(0, 0);
      this.btnScrobble.Name = "btnScrobble";
      this.btnScrobble.Size = new System.Drawing.Size(75, 29);
      this.btnScrobble.TabIndex = 0;
      this.btnScrobble.Text = "Scrobble!";
      this.btnScrobble.UseVisualStyleBackColor = true;
      this.btnScrobble.Click += new System.EventHandler(this.btnScrobble_Click);
      // 
      // btnNow
      // 
      this.btnNow.Location = new System.Drawing.Point(196, 108);
      this.btnNow.Name = "btnNow";
      this.btnNow.Size = new System.Drawing.Size(75, 20);
      this.btnNow.TabIndex = 14;
      this.btnNow.Text = "Now";
      this.btnNow.UseVisualStyleBackColor = true;
      this.btnNow.Click += new System.EventHandler(this.btnNow_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 262);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.panelScrobble);
      this.Controls.Add(this.panelTopBar);
      this.MaximumSize = new System.Drawing.Size(300, 300);
      this.Name = "MainForm";
      this.Text = "Scrubbler";
      this.panelTopBar.ResumeLayout(false);
      this.panelTopBar.PerformLayout();
      this.panelScrobble.ResumeLayout(false);
      this.panelScrobble.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panelTopBar;
    private System.Windows.Forms.LinkLabel linkLabelStatus;
    private System.Windows.Forms.Label lblLoginStatus;
    private System.Windows.Forms.Panel panelScrobble;
    private System.Windows.Forms.Label lblArtist;
    private System.Windows.Forms.TextBox textBoxTrack;
    private System.Windows.Forms.Label lblTrack;
    private System.Windows.Forms.TextBox textBoxArtist;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btnScrobble;
    private System.Windows.Forms.TextBox textBoxAlbum;
    private System.Windows.Forms.Label lblAlbum;
    private System.Windows.Forms.Label lblScrobbleStatusInfo;
    private System.Windows.Forms.Label lblScrobbleStatus;
    private System.Windows.Forms.Label lblDate;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;
    private System.Windows.Forms.DateTimePicker dateTimePicker2;
    private System.Windows.Forms.Label lblTime;
    private System.Windows.Forms.Button btnNow;
  }
}

