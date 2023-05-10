namespace _20
{
    partial class FrmGroupParticipants
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.dgvUnassigned = new System.Windows.Forms.DataGridView();
            this.dgvAssigned = new System.Windows.Forms.DataGridView();
            this.btAdd = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnassigned)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssigned)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Group name";
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(368, 51);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(100, 22);
            this.txtGroupName.TabIndex = 1;
            // 
            // dgvUnassigned
            // 
            this.dgvUnassigned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnassigned.Location = new System.Drawing.Point(12, 128);
            this.dgvUnassigned.Name = "dgvUnassigned";
            this.dgvUnassigned.RowHeadersWidth = 51;
            this.dgvUnassigned.RowTemplate.Height = 24;
            this.dgvUnassigned.Size = new System.Drawing.Size(331, 230);
            this.dgvUnassigned.TabIndex = 2;
            // 
            // dgvAssigned
            // 
            this.dgvAssigned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssigned.Location = new System.Drawing.Point(486, 128);
            this.dgvAssigned.Name = "dgvAssigned";
            this.dgvAssigned.RowHeadersWidth = 51;
            this.dgvAssigned.RowTemplate.Height = 24;
            this.dgvAssigned.Size = new System.Drawing.Size(331, 230);
            this.dgvAssigned.TabIndex = 3;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(379, 139);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(80, 48);
            this.btAdd.TabIndex = 4;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(379, 208);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(80, 48);
            this.btRemove.TabIndex = 5;
            this.btRemove.Text = "Remove";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(367, 380);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(101, 53);
            this.BtnClose.TabIndex = 6;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FrmGroupParticipants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 445);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.dgvAssigned);
            this.Controls.Add(this.dgvUnassigned);
            this.Controls.Add(this.txtGroupName);
            this.Controls.Add(this.label1);
            this.Name = "FrmGroupParticipants";
            this.Text = "FrmGroupParticipants";
            this.Load += new System.EventHandler(this.FrmGroupParticipants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnassigned)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssigned)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.DataGridView dgvUnassigned;
        private System.Windows.Forms.DataGridView dgvAssigned;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button BtnClose;
    }
}