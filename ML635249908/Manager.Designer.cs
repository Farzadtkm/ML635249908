﻿namespace ML635249908
{
    partial class Manager
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
            this.EditButton = new System.Windows.Forms.Button();
            this.InsertButton = new System.Windows.Forms.Button();
            this.TerminateButton = new System.Windows.Forms.Button();
            this.ManagerComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.ProvinceTextBox = new System.Windows.Forms.TextBox();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.PostalCodeTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.VoidButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.AmountOfMonthlyPayment = new System.Windows.Forms.TextBox();
            this.NumberOfMonthlyPayments = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.LeaseTerms = new System.Windows.Forms.TextBox();
            this.WhichVehicleLeaseFor = new System.Windows.Forms.TextBox();
            this.LeaseOwner = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.LeaseIDTextBox = new System.Windows.Forms.TextBox();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.LeaseDate = new System.Windows.Forms.DateTimePicker();
            this.FirstPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ChargeOfExtraMileage = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.MaximumKilometere = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.NumberOfYears = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.ReasonTextBox = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.DateTextBox = new System.Windows.Forms.DateTimePicker();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.ShowButton = new System.Windows.Forms.Button();
            this.KilometereOnOdometertxt = new System.Windows.Forms.TextBox();
            this.VehicleVinTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.EditButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.Location = new System.Drawing.Point(1287, 499);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(128, 29);
            this.EditButton.TabIndex = 1;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // InsertButton
            // 
            this.InsertButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.InsertButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertButton.Location = new System.Drawing.Point(1135, 499);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(128, 29);
            this.InsertButton.TabIndex = 2;
            this.InsertButton.Text = "Insert";
            this.InsertButton.UseVisualStyleBackColor = false;
            this.InsertButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // TerminateButton
            // 
            this.TerminateButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TerminateButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TerminateButton.Location = new System.Drawing.Point(1287, 569);
            this.TerminateButton.Name = "TerminateButton";
            this.TerminateButton.Size = new System.Drawing.Size(128, 29);
            this.TerminateButton.TabIndex = 3;
            this.TerminateButton.Text = "Terminate";
            this.TerminateButton.UseVisualStyleBackColor = false;
            this.TerminateButton.Click += new System.EventHandler(this.TerminateButton_Click);
            // 
            // ManagerComboBox
            // 
            this.ManagerComboBox.FormattingEnabled = true;
            this.ManagerComboBox.Items.AddRange(new object[] {
            "Customers",
            "Leases",
            "Payments"});
            this.ManagerComboBox.Location = new System.Drawing.Point(75, 9);
            this.ManagerComboBox.Name = "ManagerComboBox";
            this.ManagerComboBox.Size = new System.Drawing.Size(121, 21);
            this.ManagerComboBox.TabIndex = 4;
            this.ManagerComboBox.SelectedIndexChanged += new System.EventHandler(this.ManagerComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Go to";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 257);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1073, 354);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Full Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(601, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Postal Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(327, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Province";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(327, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "City";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(123, 48);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(182, 20);
            this.NameTextBox.TabIndex = 17;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(123, 90);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(182, 20);
            this.AddressTextBox.TabIndex = 18;
            this.AddressTextBox.TextChanged += new System.EventHandler(this.AddressTextBox_TextChanged);
            // 
            // ProvinceTextBox
            // 
            this.ProvinceTextBox.Location = new System.Drawing.Point(400, 89);
            this.ProvinceTextBox.Name = "ProvinceTextBox";
            this.ProvinceTextBox.Size = new System.Drawing.Size(182, 20);
            this.ProvinceTextBox.TabIndex = 19;
            this.ProvinceTextBox.TextChanged += new System.EventHandler(this.ProvinceTextBox_TextChanged);
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(400, 47);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(182, 20);
            this.CityTextBox.TabIndex = 20;
            this.CityTextBox.TextChanged += new System.EventHandler(this.CityTextBox_TextChanged);
            // 
            // PostalCodeTextBox
            // 
            this.PostalCodeTextBox.Location = new System.Drawing.Point(715, 49);
            this.PostalCodeTextBox.Name = "PostalCodeTextBox";
            this.PostalCodeTextBox.Size = new System.Drawing.Size(182, 20);
            this.PostalCodeTextBox.TabIndex = 21;
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(715, 89);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(182, 20);
            this.PhoneNumberTextBox.TabIndex = 22;
            this.PhoneNumberTextBox.TextChanged += new System.EventHandler(this.PhoneNumberTextBox_TextChanged);
            // 
            // VoidButton
            // 
            this.VoidButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.VoidButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VoidButton.Location = new System.Drawing.Point(1287, 534);
            this.VoidButton.Name = "VoidButton";
            this.VoidButton.Size = new System.Drawing.Size(128, 29);
            this.VoidButton.TabIndex = 24;
            this.VoidButton.Text = "Void";
            this.VoidButton.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(2, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(222, 19);
            this.label10.TabIndex = 25;
            this.label10.Text = "Date The Lease Contract Begin";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 19);
            this.label11.TabIndex = 26;
            this.label11.Text = "First Payment Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(370, 167);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(205, 19);
            this.label12.TabIndex = 27;
            this.label12.Text = "Amount Of Monthly Payment";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(370, 205);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(214, 19);
            this.label13.TabIndex = 30;
            this.label13.Text = "Number Of Monthly Payments";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(637, 168);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(223, 19);
            this.label14.TabIndex = 31;
            this.label14.Text = "Which Vehicle The Lease Is For";
            // 
            // AmountOfMonthlyPayment
            // 
            this.AmountOfMonthlyPayment.Location = new System.Drawing.Point(582, 167);
            this.AmountOfMonthlyPayment.Name = "AmountOfMonthlyPayment";
            this.AmountOfMonthlyPayment.Size = new System.Drawing.Size(58, 20);
            this.AmountOfMonthlyPayment.TabIndex = 32;
            // 
            // NumberOfMonthlyPayments
            // 
            this.NumberOfMonthlyPayments.Location = new System.Drawing.Point(582, 208);
            this.NumberOfMonthlyPayments.Name = "NumberOfMonthlyPayments";
            this.NumberOfMonthlyPayments.Size = new System.Drawing.Size(58, 20);
            this.NumberOfMonthlyPayments.TabIndex = 33;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1036, 164);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 19);
            this.label15.TabIndex = 34;
            this.label15.Text = "Lease Owner";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(647, 208);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(177, 19);
            this.label16.TabIndex = 35;
            this.label16.Text = "The Terms Of The Lease";
            // 
            // LeaseTerms
            // 
            this.LeaseTerms.Location = new System.Drawing.Point(857, 204);
            this.LeaseTerms.Name = "LeaseTerms";
            this.LeaseTerms.Size = new System.Drawing.Size(162, 20);
            this.LeaseTerms.TabIndex = 36;
            // 
            // WhichVehicleLeaseFor
            // 
            this.WhichVehicleLeaseFor.Location = new System.Drawing.Point(857, 169);
            this.WhichVehicleLeaseFor.Name = "WhichVehicleLeaseFor";
            this.WhichVehicleLeaseFor.Size = new System.Drawing.Size(162, 20);
            this.WhichVehicleLeaseFor.TabIndex = 37;
            // 
            // LeaseOwner
            // 
            this.LeaseOwner.Location = new System.Drawing.Point(1160, 165);
            this.LeaseOwner.Name = "LeaseOwner";
            this.LeaseOwner.Size = new System.Drawing.Size(156, 20);
            this.LeaseOwner.TabIndex = 38;
            this.LeaseOwner.TextChanged += new System.EventHandler(this.LeaseOwner_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(1148, 340);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 19);
            this.label17.TabIndex = 39;
            this.label17.Text = "Lease ID";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(1148, 372);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 19);
            this.label18.TabIndex = 40;
            this.label18.Text = "Date";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(1148, 404);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 19);
            this.label19.TabIndex = 41;
            this.label19.Text = "Amount";
            // 
            // LeaseIDTextBox
            // 
            this.LeaseIDTextBox.Location = new System.Drawing.Point(1242, 341);
            this.LeaseIDTextBox.Name = "LeaseIDTextBox";
            this.LeaseIDTextBox.Size = new System.Drawing.Size(158, 20);
            this.LeaseIDTextBox.TabIndex = 42;
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(1242, 405);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(158, 20);
            this.AmountTextBox.TabIndex = 44;
            this.AmountTextBox.Leave += new System.EventHandler(this.AmountTextBox_Leave);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.DeleteButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(1135, 569);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(128, 29);
            this.DeleteButton.TabIndex = 45;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(601, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 19);
            this.label8.TabIndex = 46;
            this.label8.Text = "Phone Number";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1135, 534);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 29);
            this.button1.TabIndex = 47;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LeaseDate
            // 
            this.LeaseDate.CustomFormat = "MMMM dd, yyyy";
            this.LeaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.LeaseDate.Location = new System.Drawing.Point(221, 166);
            this.LeaseDate.Name = "LeaseDate";
            this.LeaseDate.Size = new System.Drawing.Size(143, 20);
            this.LeaseDate.TabIndex = 186;
            // 
            // FirstPaymentDate
            // 
            this.FirstPaymentDate.CustomFormat = "MMMM dd, yyyy";
            this.FirstPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FirstPaymentDate.Location = new System.Drawing.Point(221, 207);
            this.FirstPaymentDate.Name = "FirstPaymentDate";
            this.FirstPaymentDate.Size = new System.Drawing.Size(143, 20);
            this.FirstPaymentDate.TabIndex = 187;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(564, 10);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(168, 20);
            this.SearchTextBox.TabIndex = 189;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(743, 4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(108, 29);
            this.SearchButton.TabIndex = 190;
            this.SearchButton.Text = "SEARCH";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ChargeOfExtraMileage
            // 
            this.ChargeOfExtraMileage.Location = new System.Drawing.Point(1254, 279);
            this.ChargeOfExtraMileage.Name = "ChargeOfExtraMileage";
            this.ChargeOfExtraMileage.Size = new System.Drawing.Size(139, 20);
            this.ChargeOfExtraMileage.TabIndex = 203;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(1104, 278);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(105, 19);
            this.label34.TabIndex = 202;
            this.label34.Text = "Perimum Rate";
            // 
            // MaximumKilometere
            // 
            this.MaximumKilometere.Location = new System.Drawing.Point(1254, 243);
            this.MaximumKilometere.Name = "MaximumKilometere";
            this.MaximumKilometere.Size = new System.Drawing.Size(139, 20);
            this.MaximumKilometere.TabIndex = 201;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(1100, 242);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(148, 19);
            this.label33.TabIndex = 200;
            this.label33.Text = "Maximum Kilometer";
            // 
            // NumberOfYears
            // 
            this.NumberOfYears.Location = new System.Drawing.Point(1160, 202);
            this.NumberOfYears.Name = "NumberOfYears";
            this.NumberOfYears.Size = new System.Drawing.Size(59, 20);
            this.NumberOfYears.TabIndex = 199;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(1036, 203);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(124, 19);
            this.label32.TabIndex = 198;
            this.label32.Text = "Number Of Years";
            // 
            // ReasonTextBox
            // 
            this.ReasonTextBox.Location = new System.Drawing.Point(1243, 436);
            this.ReasonTextBox.Name = "ReasonTextBox";
            this.ReasonTextBox.Size = new System.Drawing.Size(158, 20);
            this.ReasonTextBox.TabIndex = 207;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(1149, 435);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(60, 19);
            this.label35.TabIndex = 206;
            this.label35.Text = "Reason";
            // 
            // DateTextBox
            // 
            this.DateTextBox.CustomFormat = "MMMM dd, yyyy";
            this.DateTextBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTextBox.Location = new System.Drawing.Point(1242, 372);
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(158, 20);
            this.DateTextBox.TabIndex = 208;
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.ShowButton);
            this.GroupBox.Controls.Add(this.KilometereOnOdometertxt);
            this.GroupBox.Controls.Add(this.VehicleVinTxt);
            this.GroupBox.Controls.Add(this.label2);
            this.GroupBox.Controls.Add(this.label9);
            this.GroupBox.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox.Location = new System.Drawing.Point(1063, 30);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(338, 117);
            this.GroupBox.TabIndex = 209;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "VEHICLE Data To TERMINATE the Leases";
            // 
            // ShowButton
            // 
            this.ShowButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ShowButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowButton.Location = new System.Drawing.Point(128, 80);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(88, 29);
            this.ShowButton.TabIndex = 210;
            this.ShowButton.Text = "Show";
            this.ShowButton.UseVisualStyleBackColor = false;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // KilometereOnOdometertxt
            // 
            this.KilometereOnOdometertxt.Location = new System.Drawing.Point(191, 57);
            this.KilometereOnOdometertxt.Name = "KilometereOnOdometertxt";
            this.KilometereOnOdometertxt.Size = new System.Drawing.Size(141, 20);
            this.KilometereOnOdometertxt.TabIndex = 199;
            // 
            // VehicleVinTxt
            // 
            this.VehicleVinTxt.Location = new System.Drawing.Point(112, 28);
            this.VehicleVinTxt.Name = "VehicleVinTxt";
            this.VehicleVinTxt.Size = new System.Drawing.Size(220, 20);
            this.VehicleVinTxt.TabIndex = 198;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Kilometer On Odometere";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 19);
            this.label9.TabIndex = 16;
            this.label9.Text = "Vehicle Vin";
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 623);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.DateTextBox);
            this.Controls.Add(this.ReasonTextBox);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.ChargeOfExtraMileage);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.MaximumKilometere);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.NumberOfYears);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.FirstPaymentDate);
            this.Controls.Add(this.LeaseDate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.LeaseIDTextBox);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.LeaseOwner);
            this.Controls.Add(this.WhichVehicleLeaseFor);
            this.Controls.Add(this.LeaseTerms);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.NumberOfMonthlyPayments);
            this.Controls.Add(this.AmountOfMonthlyPayment);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.VoidButton);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.PostalCodeTextBox);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.ProvinceTextBox);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ManagerComboBox);
            this.Controls.Add(this.TerminateButton);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.EditButton);
            this.Name = "Manager";
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.Manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button TerminateButton;
        private System.Windows.Forms.ComboBox ManagerComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox ProvinceTextBox;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.TextBox PostalCodeTextBox;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.Button VoidButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox AmountOfMonthlyPayment;
        private System.Windows.Forms.TextBox NumberOfMonthlyPayments;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox LeaseTerms;
        private System.Windows.Forms.TextBox WhichVehicleLeaseFor;
        private System.Windows.Forms.TextBox LeaseOwner;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox LeaseIDTextBox;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker LeaseDate;
        private System.Windows.Forms.DateTimePicker FirstPaymentDate;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox ChargeOfExtraMileage;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox MaximumKilometere;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox NumberOfYears;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox ReasonTextBox;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.DateTimePicker DateTextBox;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox VehicleVinTxt;
        private System.Windows.Forms.TextBox KilometereOnOdometertxt;
        private System.Windows.Forms.Button ShowButton;
    }
}