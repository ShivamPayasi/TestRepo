namespace HRMS2._0
{
    partial class Award
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
            this.btnAddAward = new System.Windows.Forms.Button();
            this.pnlAdddept = new System.Windows.Forms.Panel();
            this.lblAward = new System.Windows.Forms.Label();
            this.txtAwrdId = new System.Windows.Forms.TextBox();
            this.cmbAwardTo = new System.Windows.Forms.ComboBox();
            this.btnRemoveAW = new System.Windows.Forms.Button();
            this.btnUpdateAW = new System.Windows.Forms.Button();
            this.btnAddAW = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAwardPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAwardName = new System.Windows.Forms.TextBox();
            this.btnFindById = new System.Windows.Forms.Button();
            this.txtFindById = new System.Windows.Forms.TextBox();
            this.btnDash = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlAdddept.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(339, 196);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAddAward
            // 
            this.btnAddAward.BackColor = System.Drawing.Color.White;
            this.btnAddAward.BackgroundImage = global::HRMS2._0.Properties.Resources.trophy;
            this.btnAddAward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddAward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAward.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddAward.Location = new System.Drawing.Point(668, 20);
            this.btnAddAward.Name = "btnAddAward";
            this.btnAddAward.Size = new System.Drawing.Size(147, 36);
            this.btnAddAward.TabIndex = 5;
            this.btnAddAward.Text = "Add Awards";
            this.btnAddAward.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddAward.UseVisualStyleBackColor = false;
            this.btnAddAward.Click += new System.EventHandler(this.btnAddAward_Click);
            // 
            // pnlAdddept
            // 
            this.pnlAdddept.BackColor = System.Drawing.Color.Black;
            this.pnlAdddept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlAdddept.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAdddept.Controls.Add(this.lblAward);
            this.pnlAdddept.Controls.Add(this.txtAwrdId);
            this.pnlAdddept.Controls.Add(this.cmbAwardTo);
            this.pnlAdddept.Controls.Add(this.btnRemoveAW);
            this.pnlAdddept.Controls.Add(this.btnUpdateAW);
            this.pnlAdddept.Controls.Add(this.btnAddAW);
            this.pnlAdddept.Controls.Add(this.label1);
            this.pnlAdddept.Controls.Add(this.txtAwardPrice);
            this.pnlAdddept.Controls.Add(this.label5);
            this.pnlAdddept.Controls.Add(this.label4);
            this.pnlAdddept.Controls.Add(this.txtAwardName);
            this.pnlAdddept.Location = new System.Drawing.Point(424, 88);
            this.pnlAdddept.Name = "pnlAdddept";
            this.pnlAdddept.Size = new System.Drawing.Size(420, 214);
            this.pnlAdddept.TabIndex = 6;
            // 
            // lblAward
            // 
            this.lblAward.AutoSize = true;
            this.lblAward.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAward.ForeColor = System.Drawing.Color.White;
            this.lblAward.Location = new System.Drawing.Point(50, 9);
            this.lblAward.Name = "lblAward";
            this.lblAward.Size = new System.Drawing.Size(80, 21);
            this.lblAward.TabIndex = 63;
            this.lblAward.Text = "Award ID";
            // 
            // txtAwrdId
            // 
            this.txtAwrdId.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAwrdId.Location = new System.Drawing.Point(224, 4);
            this.txtAwrdId.Name = "txtAwrdId";
            this.txtAwrdId.ReadOnly = true;
            this.txtAwrdId.Size = new System.Drawing.Size(176, 26);
            this.txtAwrdId.TabIndex = 62;
            this.txtAwrdId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmbAwardTo
            // 
            this.cmbAwardTo.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbAwardTo.FormattingEnabled = true;
            this.cmbAwardTo.Location = new System.Drawing.Point(224, 102);
            this.cmbAwardTo.Name = "cmbAwardTo";
            this.cmbAwardTo.Size = new System.Drawing.Size(176, 24);
            this.cmbAwardTo.TabIndex = 61;
            this.cmbAwardTo.Text = "    ---Select----";
            // 
            // btnRemoveAW
            // 
            this.btnRemoveAW.BackColor = System.Drawing.Color.Red;
            this.btnRemoveAW.BackgroundImage = global::HRMS2._0.Properties.Resources.trophy;
            this.btnRemoveAW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRemoveAW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveAW.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveAW.Location = new System.Drawing.Point(268, 165);
            this.btnRemoveAW.Name = "btnRemoveAW";
            this.btnRemoveAW.Size = new System.Drawing.Size(123, 35);
            this.btnRemoveAW.TabIndex = 15;
            this.btnRemoveAW.Text = "Remove";
            this.btnRemoveAW.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveAW.UseVisualStyleBackColor = false;
            this.btnRemoveAW.Click += new System.EventHandler(this.btnRemoveAW_Click);
            // 
            // btnUpdateAW
            // 
            this.btnUpdateAW.BackColor = System.Drawing.Color.Yellow;
            this.btnUpdateAW.BackgroundImage = global::HRMS2._0.Properties.Resources.trophy;
            this.btnUpdateAW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdateAW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateAW.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateAW.Location = new System.Drawing.Point(130, 165);
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
            this.btnAddAW.Image = global::HRMS2._0.Properties.Resources.trophy;
            this.btnAddAW.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAW.Location = new System.Drawing.Point(3, 165);
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
            this.label1.Size = new System.Drawing.Size(109, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Award Name";
            // 
            // txtAwardPrice
            // 
            this.txtAwardPrice.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAwardPrice.Location = new System.Drawing.Point(224, 68);
            this.txtAwardPrice.Name = "txtAwardPrice";
            this.txtAwardPrice.Size = new System.Drawing.Size(176, 26);
            this.txtAwardPrice.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(50, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Award TO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(49, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Award Price";
            // 
            // txtAwardName
            // 
            this.txtAwardName.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAwardName.Location = new System.Drawing.Point(224, 36);
            this.txtAwardName.Name = "txtAwardName";
            this.txtAwardName.Size = new System.Drawing.Size(176, 26);
            this.txtAwardName.TabIndex = 0;
            // 
            // btnFindById
            // 
            this.btnFindById.BackColor = System.Drawing.Color.White;
            this.btnFindById.BackgroundImage = global::HRMS2._0.Properties.Resources.trophy;
            this.btnFindById.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFindById.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindById.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFindById.Location = new System.Drawing.Point(509, 20);
            this.btnFindById.Name = "btnFindById";
            this.btnFindById.Size = new System.Drawing.Size(149, 36);
            this.btnFindById.TabIndex = 7;
            this.btnFindById.Text = "Find Awards";
            this.btnFindById.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFindById.UseVisualStyleBackColor = false;
            this.btnFindById.Click += new System.EventHandler(this.btnFindById_Click);
            // 
            // txtFindById
            // 
            this.txtFindById.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtFindById.Location = new System.Drawing.Point(340, 27);
            this.txtFindById.Name = "txtFindById";
            this.txtFindById.Size = new System.Drawing.Size(157, 26);
            this.txtFindById.TabIndex = 64;
            // 
            // btnDash
            // 
            this.btnDash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDash.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDash.Location = new System.Drawing.Point(22, 22);
            this.btnDash.Name = "btnDash";
            this.btnDash.Size = new System.Drawing.Size(157, 28);
            this.btnDash.TabIndex = 65;
            this.btnDash.Text = "Go to DashBoard";
            this.btnDash.UseVisualStyleBackColor = false;
            this.btnDash.Click += new System.EventHandler(this.btnDash_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(180, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 64;
            this.label2.Text = "Award ID";
            // 
            // Award
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 405);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDash);
            this.Controls.Add(this.txtFindById);
            this.Controls.Add(this.btnFindById);
            this.Controls.Add(this.pnlAdddept);
            this.Controls.Add(this.btnAddAward);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Award";
            this.Text = "Award";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Award_FormClosing);
            this.Load += new System.EventHandler(this.Award_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlAdddept.ResumeLayout(false);
            this.pnlAdddept.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAddAward;
        private Panel pnlAdddept;
        private Button btnRemoveAW;
        private Button btnUpdateAW;
        private Button btnAddAW;
        private Label label1;
        private TextBox txtAwardPrice;
        private Label label5;
        private Label label4;
        private TextBox txtAwardName;
        private ComboBox cmbAwardTo;
        private Label lblAward;
        private TextBox txtAwrdId;
        private Button btnFindById;
        private TextBox txtFindById;
        private Button btnDash;
        private Label label2;
    }
}