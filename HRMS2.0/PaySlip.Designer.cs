namespace HRMS2._0
{
    partial class PaySlip
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblAward = new System.Windows.Forms.Label();
            this.txtSId = new System.Windows.Forms.TextBox();
            this.pnlAdddept = new System.Windows.Forms.Panel();
            this.txtDec = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEmp = new System.Windows.Forms.ComboBox();
            this.btnUpdateAW = new System.Windows.Forms.Button();
            this.btnAddAW = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSAmmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFindById = new System.Windows.Forms.TextBox();
            this.btnDash = new System.Windows.Forms.Button();
            this.btnAddDepartmentBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlAdddept.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(319, 196);
            this.dataGridView1.TabIndex = 31;
            // 
            // lblAward
            // 
            this.lblAward.AutoSize = true;
            this.lblAward.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAward.ForeColor = System.Drawing.Color.White;
            this.lblAward.Location = new System.Drawing.Point(50, 9);
            this.lblAward.Name = "lblAward";
            this.lblAward.Size = new System.Drawing.Size(58, 21);
            this.lblAward.TabIndex = 63;
            this.lblAward.Text = "slip Id";
            // 
            // txtSId
            // 
            this.txtSId.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSId.Location = new System.Drawing.Point(224, 4);
            this.txtSId.Name = "txtSId";
            this.txtSId.ReadOnly = true;
            this.txtSId.Size = new System.Drawing.Size(176, 26);
            this.txtSId.TabIndex = 62;
            // 
            // pnlAdddept
            // 
            this.pnlAdddept.BackColor = System.Drawing.Color.Black;
            this.pnlAdddept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlAdddept.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAdddept.Controls.Add(this.txtDec);
            this.pnlAdddept.Controls.Add(this.label3);
            this.pnlAdddept.Controls.Add(this.lblAward);
            this.pnlAdddept.Controls.Add(this.txtSId);
            this.pnlAdddept.Controls.Add(this.cmbEmp);
            this.pnlAdddept.Controls.Add(this.btnUpdateAW);
            this.pnlAdddept.Controls.Add(this.btnAddAW);
            this.pnlAdddept.Controls.Add(this.label1);
            this.pnlAdddept.Controls.Add(this.txtSAmmount);
            this.pnlAdddept.Controls.Add(this.label5);
            this.pnlAdddept.Controls.Add(this.label4);
            this.pnlAdddept.Controls.Add(this.txtSname);
            this.pnlAdddept.Location = new System.Drawing.Point(375, 107);
            this.pnlAdddept.Name = "pnlAdddept";
            this.pnlAdddept.Size = new System.Drawing.Size(420, 240);
            this.pnlAdddept.TabIndex = 32;
            // 
            // txtDec
            // 
            this.txtDec.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDec.Location = new System.Drawing.Point(224, 109);
            this.txtDec.Multiline = true;
            this.txtDec.Name = "txtDec";
            this.txtDec.Size = new System.Drawing.Size(176, 38);
            this.txtDec.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(49, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 21);
            this.label3.TabIndex = 64;
            this.label3.Text = "Description";
            // 
            // cmbEmp
            // 
            this.cmbEmp.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbEmp.FormattingEnabled = true;
            this.cmbEmp.Location = new System.Drawing.Point(224, 153);
            this.cmbEmp.Name = "cmbEmp";
            this.cmbEmp.Size = new System.Drawing.Size(176, 24);
            this.cmbEmp.TabIndex = 61;
            this.cmbEmp.Text = "    ---Select----";
            // 
            // btnUpdateAW
            // 
            this.btnUpdateAW.BackColor = System.Drawing.Color.Yellow;
            this.btnUpdateAW.BackgroundImage = global::HRMS2._0.Properties.Resources.expenses;
            this.btnUpdateAW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdateAW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateAW.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateAW.Location = new System.Drawing.Point(224, 198);
            this.btnUpdateAW.Name = "btnUpdateAW";
            this.btnUpdateAW.Size = new System.Drawing.Size(123, 35);
            this.btnUpdateAW.TabIndex = 14;
            this.btnUpdateAW.Text = "Update";
            this.btnUpdateAW.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateAW.UseVisualStyleBackColor = false;
            this.btnUpdateAW.Click += new System.EventHandler(this.btnUpdateAW_Click);
            // 
            // btnAddAW
            // 
            this.btnAddAW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddAW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddAW.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddAW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAW.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddAW.Image = global::HRMS2._0.Properties.Resources.expenses;
            this.btnAddAW.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAW.Location = new System.Drawing.Point(88, 198);
            this.btnAddAW.Name = "btnAddAW";
            this.btnAddAW.Size = new System.Drawing.Size(108, 35);
            this.btnAddAW.TabIndex = 9;
            this.btnAddAW.Text = "Add ";
            this.btnAddAW.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddAW.UseVisualStyleBackColor = false;
            this.btnAddAW.Click += new System.EventHandler(this.btnAddAW_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Slip-Name";
            // 
            // txtSAmmount
            // 
            this.txtSAmmount.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSAmmount.Location = new System.Drawing.Point(224, 68);
            this.txtSAmmount.Name = "txtSAmmount";
            this.txtSAmmount.Size = new System.Drawing.Size(176, 26);
            this.txtSAmmount.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(50, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Emp Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(49, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ammound";
            // 
            // txtSname
            // 
            this.txtSname.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSname.Location = new System.Drawing.Point(224, 36);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(176, 26);
            this.txtSname.TabIndex = 0;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFind.Location = new System.Drawing.Point(467, 51);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(88, 28);
            this.btnFind.TabIndex = 27;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(255, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 29;
            this.label2.Text = "Slip Id";
            // 
            // txtFindById
            // 
            this.txtFindById.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtFindById.Location = new System.Drawing.Point(329, 51);
            this.txtFindById.Name = "txtFindById";
            this.txtFindById.Size = new System.Drawing.Size(132, 26);
            this.txtFindById.TabIndex = 28;
            // 
            // btnDash
            // 
            this.btnDash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDash.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDash.Location = new System.Drawing.Point(17, 35);
            this.btnDash.Name = "btnDash";
            this.btnDash.Size = new System.Drawing.Size(157, 28);
            this.btnDash.TabIndex = 30;
            this.btnDash.Text = "Go to DashBoard";
            this.btnDash.UseVisualStyleBackColor = false;
            this.btnDash.Click += new System.EventHandler(this.btnDash_Click);
            // 
            // btnAddDepartmentBtn
            // 
            this.btnAddDepartmentBtn.BackColor = System.Drawing.Color.Green;
            this.btnAddDepartmentBtn.BackgroundImage = global::HRMS2._0.Properties.Resources.expenses;
            this.btnAddDepartmentBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddDepartmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDepartmentBtn.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddDepartmentBtn.Location = new System.Drawing.Point(561, 45);
            this.btnAddDepartmentBtn.Name = "btnAddDepartmentBtn";
            this.btnAddDepartmentBtn.Size = new System.Drawing.Size(141, 40);
            this.btnAddDepartmentBtn.TabIndex = 26;
            this.btnAddDepartmentBtn.Text = "Add";
            this.btnAddDepartmentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddDepartmentBtn.UseVisualStyleBackColor = false;
            this.btnAddDepartmentBtn.Click += new System.EventHandler(this.btnAddDepartmentBtn_Click);
            // 
            // PaySlip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 370);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnlAdddept);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFindById);
            this.Controls.Add(this.btnDash);
            this.Controls.Add(this.btnAddDepartmentBtn);
            this.Name = "PaySlip";
            this.Text = "PaySlip";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PaySlip_FormClosing);
            this.Load += new System.EventHandler(this.PaySlip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlAdddept.ResumeLayout(false);
            this.pnlAdddept.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblAward;
        private TextBox txtSId;
        private Panel pnlAdddept;
        private ComboBox cmbEmp;
        private Button btnUpdateAW;
        private Button btnAddAW;
        private Label label1;
        private TextBox txtSAmmount;
        private Label label5;
        private Label label4;
        private TextBox txtSname;
        private Button btnFind;
        private Label label2;
        private TextBox txtFindById;
        private Button btnDash;
        private Button btnAddDepartmentBtn;
        private TextBox txtDec;
        private Label label3;
    }
}