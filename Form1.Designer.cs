namespace WindowsFormsApp2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtusername = new Guna.UI.WinForms.GunaTextBox();
            this.btnsignin = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtpassword = new Guna.UI.WinForms.GunaTextBox();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Mongolian Baiti", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.CadetBlue;
            this.gunaLabel1.Location = new System.Drawing.Point(100, 58);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(130, 37);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "LOGIN";
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.Color.Transparent;
            this.txtusername.BaseColor = System.Drawing.Color.White;
            this.txtusername.BorderColor = System.Drawing.Color.CadetBlue;
            this.txtusername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtusername.FocusedBaseColor = System.Drawing.Color.White;
            this.txtusername.FocusedBorderColor = System.Drawing.Color.CadetBlue;
            this.txtusername.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtusername.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.ForeColor = System.Drawing.Color.CadetBlue;
            this.txtusername.Location = new System.Drawing.Point(34, 148);
            this.txtusername.Name = "txtusername";
            this.txtusername.PasswordChar = '\0';
            this.txtusername.Radius = 17;
            this.txtusername.SelectedText = "";
            this.txtusername.Size = new System.Drawing.Size(260, 43);
            this.txtusername.TabIndex = 1;
            this.txtusername.Text = "Username";
            this.txtusername.TextChanged += new System.EventHandler(this.gunaTextBox1_TextChanged);
            // 
            // btnsignin
            // 
            this.btnsignin.AnimationHoverSpeed = 0.07F;
            this.btnsignin.AnimationSpeed = 0.03F;
            this.btnsignin.BackColor = System.Drawing.Color.Transparent;
            this.btnsignin.BaseColor = System.Drawing.Color.CadetBlue;
            this.btnsignin.BorderColor = System.Drawing.Color.Black;
            this.btnsignin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnsignin.FocusedColor = System.Drawing.Color.Empty;
            this.btnsignin.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsignin.ForeColor = System.Drawing.Color.White;
            this.btnsignin.Image = null;
            this.btnsignin.ImageSize = new System.Drawing.Size(20, 20);
            this.btnsignin.Location = new System.Drawing.Point(103, 263);
            this.btnsignin.Name = "btnsignin";
            this.btnsignin.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnsignin.OnHoverBorderColor = System.Drawing.Color.CadetBlue;
            this.btnsignin.OnHoverForeColor = System.Drawing.Color.CadetBlue;
            this.btnsignin.OnHoverImage = null;
            this.btnsignin.OnPressedColor = System.Drawing.Color.Black;
            this.btnsignin.Radius = 19;
            this.btnsignin.Size = new System.Drawing.Size(127, 42);
            this.btnsignin.TabIndex = 2;
            this.btnsignin.Text = "   SIGN IN";
            this.btnsignin.Click += new System.EventHandler(this.btnsignin_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.CadetBlue;
            this.gunaLabel2.Location = new System.Drawing.Point(50, 110);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(225, 20);
            this.gunaLabel2.TabIndex = 3;
            this.gunaLabel2.Text = "Welcome! Please Log In.";
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.Transparent;
            this.txtpassword.BaseColor = System.Drawing.Color.White;
            this.txtpassword.BorderColor = System.Drawing.Color.CadetBlue;
            this.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtpassword.FocusedBorderColor = System.Drawing.Color.CadetBlue;
            this.txtpassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtpassword.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.ForeColor = System.Drawing.Color.CadetBlue;
            this.txtpassword.Location = new System.Drawing.Point(34, 197);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Radius = 17;
            this.txtpassword.SelectedText = "";
            this.txtpassword.Size = new System.Drawing.Size(260, 45);
            this.txtpassword.TabIndex = 4;
            this.txtpassword.Text = "Password";
            this.txtpassword.TextChanged += new System.EventHandler(this.gunaTextBox2_TextChanged);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 351);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.btnsignin);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txtusername;
        private Guna.UI.WinForms.GunaButton btnsignin;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox txtpassword;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
    }
}

