namespace ProjekatJIM
{
    partial class FrmAddMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddMember));
            this.btClose = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbWorkout = new System.Windows.Forms.ComboBox();
            this.cmbFeesMode = new System.Windows.Forms.ComboBox();
            this.cmbMember = new System.Windows.Forms.ComboBox();
            this.cmbBatch = new System.Windows.Forms.ComboBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtRecNo = new System.Windows.Forms.TextBox();
            this.lbRec_No = new System.Windows.Forms.Label();
            this.lbFeesMode = new System.Windows.Forms.Label();
            this.lbmem = new System.Windows.Forms.Label();
            this.lbMember = new System.Windows.Forms.Label();
            this.lbBatch = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbContact = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbHeight = new System.Windows.Forms.Label();
            this.lbWeight = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.btBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btClose.Location = new System.Drawing.Point(898, 505);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(87, 29);
            this.btClose.TabIndex = 67;
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
            this.btRemove.Location = new System.Drawing.Point(898, 458);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(87, 29);
            this.btRemove.TabIndex = 66;
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
            this.btSave.Location = new System.Drawing.Point(898, 364);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(87, 29);
            this.btSave.TabIndex = 65;
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
            this.btEdit.Location = new System.Drawing.Point(898, 414);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(87, 29);
            this.btEdit.TabIndex = 64;
            this.btEdit.Text = "&Edit";
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 364);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(854, 170);
            this.dataGridView1.TabIndex = 63;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.cmbWorkout.Location = new System.Drawing.Point(710, 213);
            this.cmbWorkout.Name = "cmbWorkout";
            this.cmbWorkout.Size = new System.Drawing.Size(273, 21);
            this.cmbWorkout.TabIndex = 62;
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
            this.cmbFeesMode.Location = new System.Drawing.Point(710, 261);
            this.cmbFeesMode.Name = "cmbFeesMode";
            this.cmbFeesMode.Size = new System.Drawing.Size(273, 21);
            this.cmbFeesMode.TabIndex = 61;
            // 
            // cmbMember
            // 
            this.cmbMember.BackColor = System.Drawing.SystemColors.Window;
            this.cmbMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMember.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbMember.FormattingEnabled = true;
            this.cmbMember.Items.AddRange(new object[] {
            "New ",
            "Old"});
            this.cmbMember.Location = new System.Drawing.Point(710, 162);
            this.cmbMember.Name = "cmbMember";
            this.cmbMember.Size = new System.Drawing.Size(273, 21);
            this.cmbMember.TabIndex = 60;
            // 
            // cmbBatch
            // 
            this.cmbBatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBatch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbBatch.FormattingEnabled = true;
            this.cmbBatch.Items.AddRange(new object[] {
            "AM ",
            "PM"});
            this.cmbBatch.Location = new System.Drawing.Point(710, 106);
            this.cmbBatch.Name = "cmbBatch";
            this.cmbBatch.Size = new System.Drawing.Size(273, 21);
            this.cmbBatch.TabIndex = 59;
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(187, 159);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(273, 21);
            this.cmbGender.TabIndex = 58;
            // 
            // txtRecNo
            // 
            this.txtRecNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtRecNo.Location = new System.Drawing.Point(710, 308);
            this.txtRecNo.Name = "txtRecNo";
            this.txtRecNo.Size = new System.Drawing.Size(274, 20);
            this.txtRecNo.TabIndex = 57;
            // 
            // lbRec_No
            // 
            this.lbRec_No.AutoSize = true;
            this.lbRec_No.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRec_No.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbRec_No.Location = new System.Drawing.Point(565, 313);
            this.lbRec_No.Name = "lbRec_No";
            this.lbRec_No.Size = new System.Drawing.Size(88, 18);
            this.lbRec_No.TabIndex = 56;
            this.lbRec_No.Text = "Rec_No. :";
            // 
            // lbFeesMode
            // 
            this.lbFeesMode.AutoSize = true;
            this.lbFeesMode.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFeesMode.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbFeesMode.Location = new System.Drawing.Point(565, 262);
            this.lbFeesMode.Name = "lbFeesMode";
            this.lbFeesMode.Size = new System.Drawing.Size(108, 18);
            this.lbFeesMode.TabIndex = 55;
            this.lbFeesMode.Text = "Fees Mode :";
            // 
            // lbmem
            // 
            this.lbmem.AutoSize = true;
            this.lbmem.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbmem.Location = new System.Drawing.Point(565, 161);
            this.lbmem.Name = "lbmem";
            this.lbmem.Size = new System.Drawing.Size(85, 18);
            this.lbmem.TabIndex = 54;
            this.lbmem.Text = "Member :";
            // 
            // lbMember
            // 
            this.lbMember.AutoSize = true;
            this.lbMember.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMember.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbMember.Location = new System.Drawing.Point(565, 212);
            this.lbMember.Name = "lbMember";
            this.lbMember.Size = new System.Drawing.Size(90, 18);
            this.lbMember.TabIndex = 53;
            this.lbMember.Text = "Workout :";
            // 
            // lbBatch
            // 
            this.lbBatch.AutoSize = true;
            this.lbBatch.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBatch.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbBatch.Location = new System.Drawing.Point(565, 109);
            this.lbBatch.Name = "lbBatch";
            this.lbBatch.Size = new System.Drawing.Size(67, 18);
            this.lbBatch.TabIndex = 52;
            this.lbBatch.Text = "Batch :";
            // 
            // txtContact
            // 
            this.txtContact.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtContact.Location = new System.Drawing.Point(185, 306);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(274, 20);
            this.txtContact.TabIndex = 51;
            // 
            // txtWeight
            // 
            this.txtWeight.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtWeight.Location = new System.Drawing.Point(186, 257);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(274, 20);
            this.txtWeight.TabIndex = 50;
            // 
            // txtHeight
            // 
            this.txtHeight.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtHeight.Location = new System.Drawing.Point(186, 210);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(274, 20);
            this.txtHeight.TabIndex = 49;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtName.Location = new System.Drawing.Point(186, 107);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(274, 20);
            this.txtName.TabIndex = 48;
            // 
            // lbContact
            // 
            this.lbContact.AutoSize = true;
            this.lbContact.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContact.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbContact.Location = new System.Drawing.Point(26, 305);
            this.lbContact.Name = "lbContact";
            this.lbContact.Size = new System.Drawing.Size(84, 18);
            this.lbContact.TabIndex = 47;
            this.lbContact.Text = "Contact :";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbGender.Location = new System.Drawing.Point(26, 158);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(79, 18);
            this.lbGender.TabIndex = 46;
            this.lbGender.Text = "Gender :";
            // 
            // lbHeight
            // 
            this.lbHeight.AutoSize = true;
            this.lbHeight.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeight.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbHeight.Location = new System.Drawing.Point(26, 209);
            this.lbHeight.Name = "lbHeight";
            this.lbHeight.Size = new System.Drawing.Size(75, 18);
            this.lbHeight.TabIndex = 45;
            this.lbHeight.Text = "Height :";
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWeight.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbWeight.Location = new System.Drawing.Point(26, 257);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(80, 18);
            this.lbWeight.TabIndex = 44;
            this.lbWeight.Text = "Weight :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(125, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 25);
            this.label1.TabIndex = 43;
            this.label1.Text = "Add Member Details";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbName.Location = new System.Drawing.Point(26, 103);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(68, 18);
            this.lbName.TabIndex = 42;
            this.lbName.Text = "Name :";
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
            this.btBack.Location = new System.Drawing.Point(24, 12);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(77, 49);
            this.btBack.TabIndex = 41;
            this.btBack.Text = "Back";
            this.btBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // FrmAddMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1011, 543);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbWorkout);
            this.Controls.Add(this.cmbFeesMode);
            this.Controls.Add(this.cmbMember);
            this.Controls.Add(this.cmbBatch);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.txtRecNo);
            this.Controls.Add(this.lbRec_No);
            this.Controls.Add(this.lbFeesMode);
            this.Controls.Add(this.lbmem);
            this.Controls.Add(this.lbMember);
            this.Controls.Add(this.lbBatch);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbContact);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.lbHeight);
            this.Controls.Add(this.lbWeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btBack);
            this.Name = "FrmAddMember";
            this.ShowIcon = false;
            this.Text = "Add Member";
            this.Load += new System.EventHandler(this.FrmAddMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbWorkout;
        private System.Windows.Forms.ComboBox cmbFeesMode;
        private System.Windows.Forms.ComboBox cmbMember;
        private System.Windows.Forms.ComboBox cmbBatch;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtRecNo;
        private System.Windows.Forms.Label lbRec_No;
        private System.Windows.Forms.Label lbFeesMode;
        private System.Windows.Forms.Label lbmem;
        private System.Windows.Forms.Label lbMember;
        private System.Windows.Forms.Label lbBatch;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbContact;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbHeight;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btBack;
    }
}