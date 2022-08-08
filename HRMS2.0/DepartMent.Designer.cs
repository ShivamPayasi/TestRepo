namespace HRMS2._0
{
    partial class DepartMent
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
            this.btnAddDepartmentBtn = new System.Windows.Forms.Button();
            this.pnlAdddept = new System.Windows.Forms.Panel();
            this.btnRemoveBtn = new System.Windows.Forms.Button();
            this.btnUpdateBtn = new System.Windows.Forms.Button();
            this.btnAddDept = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDeptDescription = new System.Windows.Forms.TextBox();
            this.txtDeptName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDeptId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFindById = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnDash = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlAdddept.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(219, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(358, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAddDepartmentBtn
            // 
            this.btnAddDepartmentBtn.BackColor = System.Drawing.Color.Green;
            this.btnAddDepartmentBtn.BackgroundImage = global::HRMS2._0.Properties.Resources.teamwork2;
            this.btnAddDepartmentBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddDepartmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDepartmentBtn.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddDepartmentBtn.Location = new System.Drawing.Point(545, 28);
            this.btnAddDepartmentBtn.Name = "btnAddDepartmentBtn";
            this.btnAddDepartmentBtn.Size = new System.Drawing.Size(141, 26);
            this.btnAddDepartmentBtn.TabIndex = 2;
            this.btnAddDepartmentBtn.Text = "Add";
            this.btnAddDepartmentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddDepartmentBtn.UseVisualStyleBackColor = false;
            this.btnAddDepartmentBtn.Click += new System.EventHandler(this.btnDepartment_Click);
            // 
            // pnlAdddept
            // 
            this.pnlAdddept.BackColor = System.Drawing.Color.Black;
            this.pnlAdddept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlAdddept.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAdddept.Controls.Add(this.btnRemoveBtn);
            this.pnlAdddept.Controls.Add(this.btnUpdateBtn);
            this.pnlAdddept.Controls.Add(this.btnAddDept);
            this.pnlAdddept.Controls.Add(this.label1);
            this.pnlAdddept.Controls.Add(this.txtDeptDescription);
            this.pnlAdddept.Controls.Add(this.txtDeptName);
            this.pnlAdddept.Controls.Add(this.label5);
            this.pnlAdddept.Controls.Add(this.label4);
            this.pnlAdddept.Controls.Add(this.txtDeptId);
            this.pnlAdddept.Location = new System.Drawing.Point(190, 85);
            this.pnlAdddept.Name = "pnlAdddept";
            this.pnlAdddept.Size = new System.Drawing.Size(420, 214);
            this.pnlAdddept.TabIndex = 3;
            // 
            // btnRemoveBtn
            // 
            this.btnRemoveBtn.BackColor = System.Drawing.Color.Red;
            this.btnRemoveBtn.BackgroundImage = global::HRMS2._0.Properties.Resources.teamwork2;
            this.btnRemoveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRemoveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveBtn.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveBtn.Location = new System.Drawing.Point(268, 165);
            this.btnRemoveBtn.Name = "btnRemoveBtn";
            this.btnRemoveBtn.Size = new System.Drawing.Size(123, 35);
            this.btnRemoveBtn.TabIndex = 15;
            this.btnRemoveBtn.Text = "Remove";
            this.btnRemoveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveBtn.UseVisualStyleBackColor = false;
            this.btnRemoveBtn.Click += new System.EventHandler(this.btnRemoveBtn_Click_1);
            // 
            // btnUpdateBtn
            // 
            this.btnUpdateBtn.BackColor = System.Drawing.Color.Yellow;
            this.btnUpdateBtn.BackgroundImage = global::HRMS2._0.Properties.Resources.teamwork2;
            this.btnUpdateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateBtn.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateBtn.Location = new System.Drawing.Point(130, 165);
            this.btnUpdateBtn.Name = "btnUpdateBtn";
            this.btnUpdateBtn.Size = new System.Drawing.Size(123, 35);
            this.btnUpdateBtn.TabIndex = 14;
            this.btnUpdateBtn.Text = "Update";
            this.btnUpdateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateBtn.UseVisualStyleBackColor = false;
            this.btnUpdateBtn.Click += new System.EventHandler(this.btnUpdateBtn_Click_1);
            // 
            // btnAddDept
            // 
            this.btnAddDept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddDept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddDept.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddDept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDept.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddDept.Image = global::HRMS2._0.Properties.Resources.teamwork2;
            this.btnAddDept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddDept.Location = new System.Drawing.Point(3, 165);
            this.btnAddDept.Name = "btnAddDept";
            this.btnAddDept.Size = new System.Drawing.Size(108, 35);
            this.btnAddDept.TabIndex = 9;
            this.btnAddDept.Text = "Add ";
            this.btnAddDept.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddDept.UseVisualStyleBackColor = false;
            this.btnAddDept.Click += new System.EventHandler(this.btnAddDept_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Department ID";
            // 
            // txtDeptDescription
            // 
            this.txtDeptDescription.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDeptDescription.Location = new System.Drawing.Point(224, 103);
            this.txtDeptDescription.Name = "txtDeptDescription";
            this.txtDeptDescription.Size = new System.Drawing.Size(132, 26);
            this.txtDeptDescription.TabIndex = 7;
            // 
            // txtDeptName
            // 
            this.txtDeptName.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDeptName.Location = new System.Drawing.Point(224, 70);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.Size = new System.Drawing.Size(132, 26);
            this.txtDeptName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(50, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(49, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Department Name";
            // 
            // txtDeptId
            // 
            this.txtDeptId.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDeptId.Location = new System.Drawing.Point(224, 36);
            this.txtDeptId.Name = "txtDeptId";
            this.txtDeptId.ReadOnly = true;
            this.txtDeptId.Size = new System.Drawing.Size(132, 26);
            this.txtDeptId.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(184, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Department ID";
            // 
            // txtFindById
            // 
            this.txtFindById.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtFindById.Location = new System.Drawing.Point(313, 28);
            this.txtFindById.Name = "txtFindById";
            this.txtFindById.Size = new System.Drawing.Size(132, 26);
            this.txtFindById.TabIndex = 10;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFind.Location = new System.Drawing.Point(451, 28);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(88, 28);
            this.btnFind.TabIndex = 10;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnDash
            // 
            this.btnDash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDash.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDash.Location = new System.Drawing.Point(1, 12);
            this.btnDash.Name = "btnDash";
            this.btnDash.Size = new System.Drawing.Size(157, 28);
            this.btnDash.TabIndex = 18;
            this.btnDash.Text = "Go to DashBoard";
            this.btnDash.UseVisualStyleBackColor = false;
            this.btnDash.Click += new System.EventHandler(this.btnDash_Click);
            // 
            // DepartMent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 324);
            this.Controls.Add(this.btnDash);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlAdddept);
            this.Controls.Add(this.txtFindById);
            this.Controls.Add(this.btnAddDepartmentBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DepartMent";
            this.Text = "DepartMent";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DepartMent_FormClosing);
            this.Load += new System.EventHandler(this.DepartMent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlAdddept.ResumeLayout(false);
            this.pnlAdddept.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAddDepartmentBtn;
        private Panel pnlAdddept;
        private TextBox txtDeptId;
        private Label label1;
        private TextBox txtDeptDescription;
        private TextBox txtDeptName;
        private Label label5;
        private Label label4;
        private Button btnAddDept;
        private Label label2;
        private TextBox txtFindById;
        private Button btnFind;
        private Button btnRemoveBtn;
        private Button btnUpdateBtn;
        private Button btnDash;
    }
}