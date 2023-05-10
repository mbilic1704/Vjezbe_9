namespace _14_Izvršeni_zadaci
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
            this.dgvOtvoreni = new System.Windows.Forms.DataGridView();
            this.dgvIzvrseni = new System.Windows.Forms.DataGridView();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.Opis = new System.Windows.Forms.Label();
            this.Priority = new System.Windows.Forms.Label();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btMark = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOtvoreni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvrseni)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOtvoreni
            // 
            this.dgvOtvoreni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOtvoreni.Location = new System.Drawing.Point(28, 49);
            this.dgvOtvoreni.Name = "dgvOtvoreni";
            this.dgvOtvoreni.RowHeadersWidth = 51;
            this.dgvOtvoreni.RowTemplate.Height = 24;
            this.dgvOtvoreni.Size = new System.Drawing.Size(1107, 310);
            this.dgvOtvoreni.TabIndex = 0;
            // 
            // dgvIzvrseni
            // 
            this.dgvIzvrseni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIzvrseni.Location = new System.Drawing.Point(28, 496);
            this.dgvIzvrseni.Name = "dgvIzvrseni";
            this.dgvIzvrseni.RowHeadersWidth = 51;
            this.dgvIzvrseni.RowTemplate.Height = 24;
            this.dgvIzvrseni.Size = new System.Drawing.Size(1107, 351);
            this.dgvIzvrseni.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(629, 411);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 22);
            this.txtDescription.TabIndex = 2;
            // 
            // Opis
            // 
            this.Opis.AutoSize = true;
            this.Opis.Location = new System.Drawing.Point(548, 414);
            this.Opis.Name = "Opis";
            this.Opis.Size = new System.Drawing.Size(75, 16);
            this.Opis.TabIndex = 3;
            this.Opis.Text = "Description";
            // 
            // Priority
            // 
            this.Priority.AutoSize = true;
            this.Priority.Location = new System.Drawing.Point(788, 414);
            this.Priority.Name = "Priority";
            this.Priority.Size = new System.Drawing.Size(48, 16);
            this.Priority.TabIndex = 4;
            this.Priority.Text = "Priority";
            // 
            // cmbPriority
            // 
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Location = new System.Drawing.Point(853, 409);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(121, 24);
            this.cmbPriority.TabIndex = 5;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(1020, 399);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(115, 52);
            this.btAdd.TabIndex = 6;
            this.btAdd.Text = "Add task";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btMark
            // 
            this.btMark.Location = new System.Drawing.Point(1163, 151);
            this.btMark.Name = "btMark";
            this.btMark.Size = new System.Drawing.Size(108, 66);
            this.btMark.TabIndex = 7;
            this.btMark.Text = "Mark as completed";
            this.btMark.UseVisualStyleBackColor = true;
            this.btMark.Click += new System.EventHandler(this.btMark_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 872);
            this.Controls.Add(this.btMark);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.cmbPriority);
            this.Controls.Add(this.Priority);
            this.Controls.Add(this.Opis);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.dgvIzvrseni);
            this.Controls.Add(this.dgvOtvoreni);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOtvoreni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvrseni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOtvoreni;
        private System.Windows.Forms.DataGridView dgvIzvrseni;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label Opis;
        private System.Windows.Forms.Label Priority;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btMark;
    }
}

