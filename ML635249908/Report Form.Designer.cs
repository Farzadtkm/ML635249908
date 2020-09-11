namespace ML635249908
{
    partial class Report_Form
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LeaseNameLable = new System.Windows.Forms.Label();
            this.PhoneNumberLabale = new System.Windows.Forms.Label();
            this.ModelLable = new System.Windows.Forms.Label();
            this.VehicleVINLable = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(143, 38);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(411, 38);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(368, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "TO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lease : ";
            // 
            // LeaseNameLable
            // 
            this.LeaseNameLable.AutoSize = true;
            this.LeaseNameLable.Location = new System.Drawing.Point(291, 107);
            this.LeaseNameLable.Name = "LeaseNameLable";
            this.LeaseNameLable.Size = new System.Drawing.Size(67, 13);
            this.LeaseNameLable.TabIndex = 4;
            this.LeaseNameLable.Text = "Lease Name";
            // 
            // PhoneNumberLabale
            // 
            this.PhoneNumberLabale.AutoSize = true;
            this.PhoneNumberLabale.Location = new System.Drawing.Point(141, 139);
            this.PhoneNumberLabale.Name = "PhoneNumberLabale";
            this.PhoneNumberLabale.Size = new System.Drawing.Size(78, 13);
            this.PhoneNumberLabale.TabIndex = 5;
            this.PhoneNumberLabale.Text = "Phone Number";
            // 
            // ModelLable
            // 
            this.ModelLable.AutoSize = true;
            this.ModelLable.Location = new System.Drawing.Point(141, 177);
            this.ModelLable.Name = "ModelLable";
            this.ModelLable.Size = new System.Drawing.Size(36, 13);
            this.ModelLable.TabIndex = 6;
            this.ModelLable.Text = "Model";
            // 
            // VehicleVINLable
            // 
            this.VehicleVINLable.AutoSize = true;
            this.VehicleVINLable.Location = new System.Drawing.Point(291, 177);
            this.VehicleVINLable.Name = "VehicleVINLable";
            this.VehicleVINLable.Size = new System.Drawing.Size(103, 13);
            this.VehicleVINLable.TabIndex = 7;
            this.VehicleVINLable.Text = "Vehicle VIN Number";
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(771, 38);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(103, 28);
            this.SearchButton.TabIndex = 8;
            this.SearchButton.Text = "SEARCH";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Payment Schedule";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(144, 261);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(716, 237);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Report_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 558);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.VehicleVINLable);
            this.Controls.Add(this.ModelLable);
            this.Controls.Add(this.PhoneNumberLabale);
            this.Controls.Add(this.LeaseNameLable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Report_Form";
            this.Text = "Report Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LeaseNameLable;
        private System.Windows.Forms.Label PhoneNumberLabale;
        private System.Windows.Forms.Label ModelLable;
        private System.Windows.Forms.Label VehicleVINLable;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}