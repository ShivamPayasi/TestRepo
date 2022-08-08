namespace HRMS2._0
{
    partial class ForgotPassword
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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbQuest = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDash = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnShow2 = new System.Windows.Forms.Button();
            this.btnSHow = new System.Windows.Forms.Button();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAns = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(311, 30);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PlaceholderText = "User Name";
            this.txtUserName.Size = new System.Drawing.Size(160, 23);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(194, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(239, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Change Password";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbQuest
            // 
            this.cmbQuest.FormattingEnabled = true;
            this.cmbQuest.Items.AddRange(new object[] {
            "Childhood name",
            "favorit color",
            "pet name ",
            "primary school name",
            "favorit teacher name"});
            this.cmbQuest.Location = new System.Drawing.Point(311, 70);
            this.cmbQuest.Name = "cmbQuest";
            this.cmbQuest.Size = new System.Drawing.Size(160, 23);
            this.cmbQuest.TabIndex = 3;
            this.cmbQuest.Text = "------Choose Question----";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnDash);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.btnChange);
            this.panel1.Controls.Add(this.btnShow2);
            this.panel1.Controls.Add(this.btnSHow);
            this.panel1.Controls.Add(this.txtConfirmPass);
            this.panel1.Controls.Add(this.txtNewPass);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(131, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 170);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnDash
            // 
            this.btnDash.Location = new System.Drawing.Point(252, 100);
            this.btnDash.Name = "btnDash";
            this.btnDash.Size = new System.Drawing.Size(133, 23);
            this.btnDash.TabIndex = 7;
            this.btnDash.Text = "Go to Dashboard";
            this.btnDash.UseVisualStyleBackColor = true;
            this.btnDash.Click += new System.EventHandler(this.btnDash_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(159, 100);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Log-in";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(37, 100);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(101, 23);
            this.btnChange.TabIndex = 6;
            this.btnChange.Text = "Save Changes";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnShow2
            // 
            this.btnShow2.BackColor = System.Drawing.Color.White;
            this.btnShow2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnShow2.FlatAppearance.BorderSize = 0;
            this.btnShow2.Location = new System.Drawing.Point(313, 66);
            this.btnShow2.Name = "btnShow2";
            this.btnShow2.Size = new System.Drawing.Size(48, 23);
            this.btnShow2.TabIndex = 5;
            this.btnShow2.Text = "Show";
            this.btnShow2.UseVisualStyleBackColor = false;
            this.btnShow2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSHow
            // 
            this.btnSHow.BackColor = System.Drawing.Color.White;
            this.btnSHow.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSHow.FlatAppearance.BorderSize = 0;
            this.btnSHow.Location = new System.Drawing.Point(313, 33);
            this.btnSHow.Name = "btnSHow";
            this.btnSHow.Size = new System.Drawing.Size(48, 23);
            this.btnSHow.TabIndex = 4;
            this.btnSHow.Text = "Show";
            this.btnSHow.UseVisualStyleBackColor = false;
            this.btnSHow.Click += new System.EventHandler(this.btnSHow_Click);
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Location = new System.Drawing.Point(183, 66);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.PasswordChar = '*';
            this.txtConfirmPass.Size = new System.Drawing.Size(132, 23);
            this.txtConfirmPass.TabIndex = 3;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(183, 33);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(132, 23);
            this.txtNewPass.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(30, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Confirm New Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Enter New Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(183, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Security Question ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(213, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Answer";
            // 
            // txtAns
            // 
            this.txtAns.Location = new System.Drawing.Point(312, 105);
            this.txtAns.Name = "txtAns";
            this.txtAns.PlaceholderText = "Answer";
            this.txtAns.Size = new System.Drawing.Size(100, 23);
            this.txtAns.TabIndex = 7;
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(627, 213);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtAns);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbQuest);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUserName);
            this.Name = "ForgotPassword";
            this.Text = "ForgotPassword";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ForgotPassword_FormClosing);
            this.Load += new System.EventHandler(this.ForgotPassword_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtUserName;
        private Label label1;
        private Button button1;
        private ComboBox cmbQuest;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private TextBox txtAns;
        private Button btnLogin;
        private Button btnSHow;
        private TextBox txtConfirmPass;
        private TextBox txtNewPass;
        private Label label5;
        private Label label4;
        private Button btnDash;
        private Button btnChange;
        private Button btnShow2;
    }
}