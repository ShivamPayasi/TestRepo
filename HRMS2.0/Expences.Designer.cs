namespace HRMS2._0
{
    partial class Expences
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
            this.btnDash = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFindById = new System.Windows.Forms.TextBox();
            this.btnAddDepartmentBtn = new System.Windows.Forms.Button();
            this.pnlAdddept = new System.Windows.Forms.Panel();
            this.lblAward = new System.Windows.Forms.Label();
            this.txtExId = new System.Windows.Forms.TextBox();
            this.btnUpdateAW = new System.Windows.Forms.Button();
            this.btnAddAW = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtExDes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAmt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlAdddept.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDash
            // 
            this.btnDash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDash.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDash.Location = new System.Drawing.Point(12, 12);
            this.btnDash.Name = "btnDash";
            this.btnDash.Size = new System.Drawing.Size(157, 28);
            this.btnDash.TabIndex = 23;
            this.btnDash.Text = "Go to DashBoard";
            this.btnDash.UseVisualStyleBackColor = false;
            this.btnDash.Click += new System.EventHandler(this.btnDash_Click);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFind.Location = new System.Drawing.Point(462, 28);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(88, 28);
            this.btnFind.TabIndex = 20;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(222, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Expense Id";
            // 
            // txtFindById
            // 
            this.txtFindById.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtFindById.Location = new System.Drawing.Point(324, 28);
            this.txtFindById.Name = "txtFindById";
            this.txtFindById.Size = new System.Drawing.Size(132, 26);
            this.txtFindById.TabIndex = 21;
            // 
            // btnAddDepartmentBtn
            // 
            this.btnAddDepartmentBtn.BackColor = System.Drawing.Color.Green;
            this.btnAddDepartmentBtn.BackgroundImage = global::HRMS2._0.Properties.Resources.expenses;
            this.btnAddDepartmentBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddDepartmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDepartmentBtn.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddDepartmentBtn.Location = new System.Drawing.Point(556, 22);
            this.btnAddDepartmentBtn.Name = "btnAddDepartmentBtn";
            this.btnAddDepartmentBtn.Size = new System.Drawing.Size(141, 40);
            this.btnAddDepartmentBtn.TabIndex = 19;
            this.btnAddDepartmentBtn.Text = "Add";
            this.btnAddDepartmentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddDepartmentBtn.UseVisualStyleBackColor = false;
            this.btnAddDepartmentBtn.Click += new System.EventHandler(this.btnAddDepartmentBtn_Click);
            // 
            // pnlAdddept
            // 
            this.pnlAdddept.BackColor = System.Drawing.Color.Black;
            this.pnlAdddept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlAdddept.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAdddept.Controls.Add(this.lblAward);
            this.pnlAdddept.Controls.Add(this.txtExId);
            this.pnlAdddept.Controls.Add(this.btnUpdateAW);
            this.pnlAdddept.Controls.Add(this.btnAddAW);
            this.pnlAdddept.Controls.Add(this.label1);
            this.pnlAdddept.Controls.Add(this.txtExDes);
            this.pnlAdddept.Controls.Add(this.label4);
            this.pnlAdddept.Controls.Add(this.txtAmt);
            this.pnlAdddept.Location = new System.Drawing.Point(370, 110);
            this.pnlAdddept.Name = "pnlAdddept";
            this.pnlAdddept.Size = new System.Drawing.Size(420, 214);
            this.pnlAdddept.TabIndex = 25;
            // 
            // lblAward
            // 
            this.lblAward.AutoSize = true;
            this.lblAward.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAward.ForeColor = System.Drawing.Color.White;
            this.lblAward.Location = new System.Drawing.Point(50, 9);
            this.lblAward.Name = "lblAward";
            this.lblAward.Size = new System.Drawing.Size(103, 21);
            this.lblAward.TabIndex = 63;
            this.lblAward.Text = "Expences ID";
            // 
            // txtExId
            // 
            this.txtExId.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtExId.Location = new System.Drawing.Point(224, 4);
            this.txtExId.Name = "txtExId";
            this.txtExId.ReadOnly = true;
            this.txtExId.Size = new System.Drawing.Size(176, 26);
            this.txtExId.TabIndex = 62;
            // 
            // btnUpdateAW
            // 
            this.btnUpdateAW.BackColor = System.Drawing.Color.Yellow;
            this.btnUpdateAW.BackgroundImage = global::HRMS2._0.Properties.Resources.expenses;
            this.btnUpdateAW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdateAW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateAW.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateAW.Location = new System.Drawing.Point(230, 165);
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
            this.btnAddAW.Location = new System.Drawing.Point(94, 165);
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
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ammount";
            // 
            // txtExDes
            // 
            this.txtExDes.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtExDes.Location = new System.Drawing.Point(224, 68);
            this.txtExDes.Multiline = true;
            this.txtExDes.Name = "txtExDes";
            this.txtExDes.Size = new System.Drawing.Size(189, 80);
            this.txtExDes.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(49, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Description";
            // 
            // txtAmt
            // 
            this.txtAmt.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAmt.Location = new System.Drawing.Point(224, 36);
            this.txtAmt.Name = "txtAmt";
            this.txtAmt.Size = new System.Drawing.Size(176, 26);
            this.txtAmt.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(319, 196);
            this.dataGridView1.TabIndex = 24;
            // 
            // Expences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.pnlAdddept);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDash);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFindById);
            this.Controls.Add(this.btnAddDepartmentBtn);
            this.Name = "Expences";
            this.Text = "Expences";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Expences_FormClosing);
            this.Load += new System.EventHandler(this.Expences_Load);
            this.pnlAdddept.ResumeLayout(false);
            this.pnlAdddept.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDash;
        private Button btnFind;
        private Label label2;
        private TextBox txtFindById;
        private Button btnAddDepartmentBtn;
        private Panel pnlAdddept;
        private Label lblAward;
        private TextBox txtExId;
        private Button btnUpdateAW;
        private Button btnAddAW;
        private Label label1;
        private Label label4;
        private TextBox txtAmt;
        private DataGridView dataGridView1;
        private TextBox txtExDes;
    }
}