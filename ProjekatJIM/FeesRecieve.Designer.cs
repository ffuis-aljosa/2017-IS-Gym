namespace ProjekatJIM
{
    partial class FrmFeesRecieve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFeesRecieve));
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.cmbFeesMode = new System.Windows.Forms.ComboBox();
            this.txtRecNo = new System.Windows.Forms.TextBox();
            this.lbRec_No = new System.Windows.Forms.Label();
            this.lbFeesMode = new System.Windows.Forms.Label();
            this.cmbWorkout = new System.Windows.Forms.ComboBox();
            this.lbMember = new System.Windows.Forms.Label();
            this.lbFees = new System.Windows.Forms.Label();
            this.txtFees = new System.Windows.Forms.TextBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btClose = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.lbAddMemberFees = new System.Windows.Forms.Label();
            this.btBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtName.Location = new System.Drawing.Point(158, 163);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(274, 20);
            this.txtName.TabIndex = 50;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbName.Location = new System.Drawing.Point(20, 165);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(68, 18);
            this.lbName.TabIndex = 49;
            this.lbName.Text = "Name :";
            // 
            // cmbFeesMode
            // 
            this.cmbFeesMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFeesMode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbFeesMode.FormattingEnabled = true;
            this.cmbFeesMode.Items.AddRange(new object[] {
            "Monthly",
            "2 Months",
            "Half Yearly",
            "Yearly"});
            this.cmbFeesMode.Location = new System.Drawing.Point(158, 279);
            this.cmbFeesMode.Name = "cmbFeesMode";
            this.cmbFeesMode.Size = new System.Drawing.Size(273, 21);
            this.cmbFeesMode.TabIndex = 65;
            // 
            // txtRecNo
            // 
            this.txtRecNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtRecNo.Location = new System.Drawing.Point(640, 166);
            this.txtRecNo.Name = "txtRecNo";
            this.txtRecNo.Size = new System.Drawing.Size(274, 20);
            this.txtRecNo.TabIndex = 64;
            // 
            // lbRec_No
            // 
            this.lbRec_No.AutoSize = true;
            this.lbRec_No.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRec_No.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbRec_No.Location = new System.Drawing.Point(496, 165);
            this.lbRec_No.Name = "lbRec_No";
            this.lbRec_No.Size = new System.Drawing.Size(88, 18);
            this.lbRec_No.TabIndex = 63;
            this.lbRec_No.Text = "Rec_No. :";
            // 
            // lbFeesMode
            // 
            this.lbFeesMode.AutoSize = true;
            this.lbFeesMode.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFeesMode.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbFeesMode.Location = new System.Drawing.Point(20, 282);
            this.lbFeesMode.Name = "lbFeesMode";
            this.lbFeesMode.Size = new System.Drawing.Size(108, 18);
            this.lbFeesMode.TabIndex = 62;
            this.lbFeesMode.Text = "Fees Mode :";
            // 
            // cmbWorkout
            // 
            this.cmbWorkout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWorkout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbWorkout.FormattingEnabled = true;
            this.cmbWorkout.Items.AddRange(new object[] {
            "Gym",
            "Cardio",
            "Personal Trainer"});
            this.cmbWorkout.Location = new System.Drawing.Point(641, 218);
            this.cmbWorkout.Name = "cmbWorkout";
            this.cmbWorkout.Size = new System.Drawing.Size(273, 21);
            this.cmbWorkout.TabIndex = 67;
            // 
            // lbMember
            // 
            this.lbMember.AutoSize = true;
            this.lbMember.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMember.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbMember.Location = new System.Drawing.Point(496, 221);
            this.lbMember.Name = "lbMember";
            this.lbMember.Size = new System.Drawing.Size(89, 18);
            this.lbMember.TabIndex = 66;
            this.lbMember.Text = "Workout :";
            // 
            // lbFees
            // 
            this.lbFees.AutoSize = true;
            this.lbFees.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFees.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbFees.Location = new System.Drawing.Point(20, 221);
            this.lbFees.Name = "lbFees";
            this.lbFees.Size = new System.Drawing.Size(59, 18);
            this.lbFees.TabIndex = 68;
            this.lbFees.Text = "Fees :";
            // 
            // txtFees
            // 
            this.txtFees.BackColor = System.Drawing.Color.White;
            this.txtFees.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtFees.Location = new System.Drawing.Point(158, 222);
            this.txtFees.Name = "txtFees";
            this.txtFees.Size = new System.Drawing.Size(274, 20);
            this.txtFees.TabIndex = 69;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbDate.Location = new System.Drawing.Point(496, 282);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(60, 18);
            this.lbDate.TabIndex = 70;
            this.lbDate.Text = "Date :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM-dd-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(641, 280);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(273, 20);
            this.dateTimePicker1.TabIndex = 71;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 362);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(854, 170);
            this.dataGridView1.TabIndex = 72;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btClose.Location = new System.Drawing.Point(896, 503);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(87, 29);
            this.btClose.TabIndex = 76;
            this.btClose.Text = "&Close";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btRemove
            // 
            this.btRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemove.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btRemove.Location = new System.Drawing.Point(896, 456);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(87, 29);
            this.btRemove.TabIndex = 75;
            this.btRemove.Text = "&Remove";
            this.btRemove.UseVisualStyleBackColor = false;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.Plum;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btSave.Location = new System.Drawing.Point(896, 362);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(87, 29);
            this.btSave.TabIndex = 74;
            this.btSave.Text = "&Save";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btEdit
            // 
            this.btEdit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btEdit.Location = new System.Drawing.Point(896, 412);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(87, 29);
            this.btEdit.TabIndex = 73;
            this.btEdit.Text = "&Edit";
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // lbAddMemberFees
            // 
            this.lbAddMemberFees.AutoSize = true;
            this.lbAddMemberFees.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddMemberFees.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbAddMemberFees.Location = new System.Drawing.Point(113, 30);
            this.lbAddMemberFees.Name = "lbAddMemberFees";
            this.lbAddMemberFees.Size = new System.Drawing.Size(200, 25);
            this.lbAddMemberFees.TabIndex = 78;
            this.lbAddMemberFees.Text = "Add Member Fees";
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.Transparent;
            this.btBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btBack.Cursor = System.Windows.Forms.Cursors.Default;
            this.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBack.Image = ((System.Drawing.Image)(resources.GetObject("btBack.Image")));
            this.btBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBack.Location = new System.Drawing.Point(12, 21);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(77, 49);
            this.btBack.TabIndex = 77;
            this.btBack.Text = "Back";
            this.btBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // FrmFeesRecieve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1012, 544);
            this.Controls.Add(this.lbAddMemberFees);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.txtFees);
            this.Controls.Add(this.lbFees);
            this.Controls.Add(this.cmbWorkout);
            this.Controls.Add(this.lbMember);
            this.Controls.Add(this.cmbFeesMode);
            this.Controls.Add(this.txtRecNo);
            this.Controls.Add(this.lbRec_No);
            this.Controls.Add(this.lbFeesMode);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbName);
            this.Name = "FrmFeesRecieve";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Fees Recieve";
            this.Load += new System.EventHandler(this.FrmFeesRecieve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.ComboBox cmbFeesMode;
        private System.Windows.Forms.TextBox txtRecNo;
        private System.Windows.Forms.Label lbRec_No;
        private System.Windows.Forms.Label lbFeesMode;
        private System.Windows.Forms.ComboBox cmbWorkout;
        private System.Windows.Forms.Label lbMember;
        private System.Windows.Forms.Label lbFees;
        private System.Windows.Forms.TextBox txtFees;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Label lbAddMemberFees;
        private System.Windows.Forms.Button btBack;
    }
}