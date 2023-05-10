namespace _16_Sensors2
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
            this.dgvSensors = new System.Windows.Forms.DataGridView();
            this.btAssignUnit = new System.Windows.Forms.Button();
            this.btAddSensor = new System.Windows.Forms.Button();
            this.btRemoveSensor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSensors)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSensors
            // 
            this.dgvSensors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSensors.Location = new System.Drawing.Point(21, 29);
            this.dgvSensors.Name = "dgvSensors";
            this.dgvSensors.RowHeadersWidth = 51;
            this.dgvSensors.RowTemplate.Height = 24;
            this.dgvSensors.Size = new System.Drawing.Size(747, 304);
            this.dgvSensors.TabIndex = 0;
            // 
            // btAssignUnit
            // 
            this.btAssignUnit.Location = new System.Drawing.Point(393, 368);
            this.btAssignUnit.Name = "btAssignUnit";
            this.btAssignUnit.Size = new System.Drawing.Size(121, 47);
            this.btAssignUnit.TabIndex = 1;
            this.btAssignUnit.Text = "Assign unit";
            this.btAssignUnit.UseVisualStyleBackColor = true;
            this.btAssignUnit.Click += new System.EventHandler(this.btAssignUnit_Click);
            // 
            // btAddSensor
            // 
            this.btAddSensor.Location = new System.Drawing.Point(520, 368);
            this.btAddSensor.Name = "btAddSensor";
            this.btAddSensor.Size = new System.Drawing.Size(121, 47);
            this.btAddSensor.TabIndex = 2;
            this.btAddSensor.Text = "Add sensor";
            this.btAddSensor.UseVisualStyleBackColor = true;
            this.btAddSensor.Click += new System.EventHandler(this.btAddSensor_Click);
            // 
            // btRemoveSensor
            // 
            this.btRemoveSensor.Location = new System.Drawing.Point(647, 368);
            this.btRemoveSensor.Name = "btRemoveSensor";
            this.btRemoveSensor.Size = new System.Drawing.Size(121, 47);
            this.btRemoveSensor.TabIndex = 3;
            this.btRemoveSensor.Text = "Remove sensor";
            this.btRemoveSensor.UseVisualStyleBackColor = true;
            this.btRemoveSensor.Click += new System.EventHandler(this.btRemoveSensor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btRemoveSensor);
            this.Controls.Add(this.btAddSensor);
            this.Controls.Add(this.btAssignUnit);
            this.Controls.Add(this.dgvSensors);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSensors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSensors;
        private System.Windows.Forms.Button btAssignUnit;
        private System.Windows.Forms.Button btAddSensor;
        private System.Windows.Forms.Button btRemoveSensor;
    }
}

