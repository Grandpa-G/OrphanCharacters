namespace OrphanCharacters
{
    partial class OrphanGUI
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
            this.dataOrphans = new System.Windows.Forms.DataGridView();
            this.gridSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gridAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridInventroy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblServerName = new System.Windows.Forms.Label();
            this.DeleteOrphans = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.refreshOrphans = new System.Windows.Forms.Button();
            this.selectAll = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.youOweMe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataOrphans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataOrphans
            // 
            this.dataOrphans.AllowUserToAddRows = false;
            this.dataOrphans.AllowUserToDeleteRows = false;
            this.dataOrphans.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataOrphans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOrphans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridSelect,
            this.gridAccount,
            this.gridInventroy});
            this.dataOrphans.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataOrphans.Location = new System.Drawing.Point(12, 145);
            this.dataOrphans.Name = "dataOrphans";
            this.dataOrphans.RowHeadersVisible = false;
            this.dataOrphans.Size = new System.Drawing.Size(902, 408);
            this.dataOrphans.TabIndex = 0;
            this.dataOrphans.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataOrphan_CellContentClick);
            // 
            // gridSelect
            // 
            this.gridSelect.HeaderText = "Delete?";
            this.gridSelect.Name = "gridSelect";
            this.gridSelect.Width = 80;
            // 
            // gridAccount
            // 
            this.gridAccount.HeaderText = "Account";
            this.gridAccount.Name = "gridAccount";
            this.gridAccount.ReadOnly = true;
            this.gridAccount.Width = 75;
            // 
            // gridInventroy
            // 
            this.gridInventroy.HeaderText = "Inventory";
            this.gridInventroy.Name = "gridInventroy";
            this.gridInventroy.ReadOnly = true;
            this.gridInventroy.Width = 700;
            // 
            // lblServerName
            // 
            this.lblServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerName.Location = new System.Drawing.Point(310, 33);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(349, 38);
            this.lblServerName.TabIndex = 3;
            this.lblServerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DeleteOrphans
            // 
            this.DeleteOrphans.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteOrphans.Location = new System.Drawing.Point(187, 110);
            this.DeleteOrphans.Name = "DeleteOrphans";
            this.DeleteOrphans.Size = new System.Drawing.Size(75, 23);
            this.DeleteOrphans.TabIndex = 264;
            this.DeleteOrphans.Text = "Delete";
            this.DeleteOrphans.UseVisualStyleBackColor = false;
            this.DeleteOrphans.Click += new System.EventHandler(this.DeleteOrphans_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::OrphanCharacters.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(12, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(282, 82);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // refreshOrphans
            // 
            this.refreshOrphans.Image = global::OrphanCharacters.Properties.Resources.refresh;
            this.refreshOrphans.Location = new System.Drawing.Point(884, 106);
            this.refreshOrphans.Name = "refreshOrphans";
            this.refreshOrphans.Size = new System.Drawing.Size(30, 30);
            this.refreshOrphans.TabIndex = 11;
            this.refreshOrphans.UseVisualStyleBackColor = true;
            this.refreshOrphans.Click += new System.EventHandler(this.refreshOrphans_Click);
            // 
            // selectAll
            // 
            this.selectAll.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.selectAll.Location = new System.Drawing.Point(12, 110);
            this.selectAll.Name = "selectAll";
            this.selectAll.Size = new System.Drawing.Size(75, 23);
            this.selectAll.TabIndex = 265;
            this.selectAll.Text = "Select All";
            this.selectAll.UseVisualStyleBackColor = false;
            this.selectAll.Click += new System.EventHandler(this.selectAll_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblVersion.Location = new System.Drawing.Point(466, 563);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(448, 15);
            this.lblVersion.TabIndex = 266;
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // youOweMe
            // 
            this.youOweMe.Location = new System.Drawing.Point(268, 110);
            this.youOweMe.Name = "youOweMe";
            this.youOweMe.Size = new System.Drawing.Size(323, 23);
            this.youOweMe.TabIndex = 267;
            this.youOweMe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrphanGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(926, 587);
            this.Controls.Add(this.youOweMe);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.selectAll);
            this.Controls.Add(this.DeleteOrphans);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.refreshOrphans);
            this.Controls.Add(this.lblServerName);
            this.Controls.Add(this.dataOrphans);
            this.Name = "OrphanGUI";
            this.Text = "Orphan Characters";
            ((System.ComponentModel.ISupportInitialize)(this.dataOrphans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataOrphans;
        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.Button refreshOrphans;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button DeleteOrphans;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gridSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridInventroy;
        private System.Windows.Forms.Button selectAll;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label youOweMe;
    }
}