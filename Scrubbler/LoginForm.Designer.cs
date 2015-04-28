namespace Scrubbler
{
  partial class LoginForm
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
      this.lblUsername = new System.Windows.Forms.Label();
      this.textBoxUsername = new System.Windows.Forms.TextBox();
      this.textBoxPassword = new System.Windows.Forms.TextBox();
      this.lblPassword = new System.Windows.Forms.Label();
      this.btnLogin = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lblUsername
      // 
      this.lblUsername.AutoSize = true;
      this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblUsername.Location = new System.Drawing.Point(0, 0);
      this.lblUsername.Name = "lblUsername";
      this.lblUsername.Size = new System.Drawing.Size(147, 31);
      this.lblUsername.TabIndex = 0;
      this.lblUsername.Text = "Username";
      // 
      // textBoxUsername
      // 
      this.textBoxUsername.Location = new System.Drawing.Point(6, 34);
      this.textBoxUsername.Name = "textBoxUsername";
      this.textBoxUsername.Size = new System.Drawing.Size(132, 20);
      this.textBoxUsername.TabIndex = 1;
      this.textBoxUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUsername_KeyPress);
      // 
      // textBoxPassword
      // 
      this.textBoxPassword.Location = new System.Drawing.Point(6, 111);
      this.textBoxPassword.Name = "textBoxPassword";
      this.textBoxPassword.Size = new System.Drawing.Size(132, 20);
      this.textBoxPassword.TabIndex = 3;
      this.textBoxPassword.UseSystemPasswordChar = true;
      this.textBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUsername_KeyPress);
      // 
      // lblPassword
      // 
      this.lblPassword.AutoSize = true;
      this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPassword.Location = new System.Drawing.Point(2, 77);
      this.lblPassword.Name = "lblPassword";
      this.lblPassword.Size = new System.Drawing.Size(142, 31);
      this.lblPassword.TabIndex = 2;
      this.lblPassword.Text = "Password";
      // 
      // btnLogin
      // 
      this.btnLogin.Location = new System.Drawing.Point(35, 137);
      this.btnLogin.Name = "btnLogin";
      this.btnLogin.Size = new System.Drawing.Size(75, 23);
      this.btnLogin.TabIndex = 4;
      this.btnLogin.Text = "Login";
      this.btnLogin.UseVisualStyleBackColor = true;
      this.btnLogin.Click += new System.EventHandler(this.Login);
      // 
      // LoginForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(147, 168);
      this.Controls.Add(this.btnLogin);
      this.Controls.Add(this.textBoxPassword);
      this.Controls.Add(this.lblPassword);
      this.Controls.Add(this.textBoxUsername);
      this.Controls.Add(this.lblUsername);
      this.MaximumSize = new System.Drawing.Size(163, 206);
      this.Name = "LoginForm";
      this.Text = "LoginForm";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblUsername;
    private System.Windows.Forms.TextBox textBoxUsername;
    private System.Windows.Forms.TextBox textBoxPassword;
    private System.Windows.Forms.Label lblPassword;
    private System.Windows.Forms.Button btnLogin;
  }
}