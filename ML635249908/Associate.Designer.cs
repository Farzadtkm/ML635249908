namespace ML635249908
{
    partial class Associate
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
            this.AssociateComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AssociatePhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.AssociatePostalCodeTextBox = new System.Windows.Forms.TextBox();
            this.AssociateCityTextBox = new System.Windows.Forms.TextBox();
            this.AssociateProvinceTextBox = new System.Windows.Forms.TextBox();
            this.AssociateAddressTextBox = new System.Windows.Forms.TextBox();
            this.AssociateNameTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LeaseOwner = new System.Windows.Forms.TextBox();
            this.WhichVehicleIsLeaseFor = new System.Windows.Forms.TextBox();
            this.LeaseTerms = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.NumberOfMonthly = new System.Windows.Forms.TextBox();
            this.AmountOfMonthly = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.KilometereOnOdometertxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.ModelTxt = new System.Windows.Forms.TextBox();
            this.VehicleVinTxt = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.BookValueTxt = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.LeaseIDTextBox = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ViewButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.VoidButton = new System.Windows.Forms.Button();
            this.TerminateButton = new System.Windows.Forms.Button();
            this.InsertButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.OptionComboBox = new System.Windows.Forms.ComboBox();
            this.TransmissionComboBox = new System.Windows.Forms.ComboBox();
            this.IsCarNewComboBox = new System.Windows.Forms.ComboBox();
            this.ColorComboBox = new System.Windows.Forms.ComboBox();
            this.cartype = new System.Windows.Forms.ComboBox();
            this.LeaseYearComboBox = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.BeginDate = new System.Windows.Forms.DateTimePicker();
            this.FirstPaymentDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Go to";
            // 
            // AssociateComboBox
            // 
            this.AssociateComboBox.FormattingEnabled = true;
            this.AssociateComboBox.Items.AddRange(new object[] {
            "Vehicles",
            "Customers",
            "Leases",
            "Payments"});
            this.AssociateComboBox.Location = new System.Drawing.Point(63, 7);
            this.AssociateComboBox.Name = "AssociateComboBox";
            this.AssociateComboBox.Size = new System.Drawing.Size(121, 21);
            this.AssociateComboBox.TabIndex = 6;
            this.AssociateComboBox.SelectedIndexChanged += new System.EventHandler(this.AssociateComboBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(593, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 19);
            this.label8.TabIndex = 58;
            this.label8.Text = "Phone Number";
            // 
            // AssociatePhoneNumberTextBox
            // 
            this.AssociatePhoneNumberTextBox.Location = new System.Drawing.Point(707, 89);
            this.AssociatePhoneNumberTextBox.Name = "AssociatePhoneNumberTextBox";
            this.AssociatePhoneNumberTextBox.Size = new System.Drawing.Size(182, 20);
            this.AssociatePhoneNumberTextBox.TabIndex = 57;
            this.AssociatePhoneNumberTextBox.TextChanged += new System.EventHandler(this.AssociatePhoneNumberTextBox_TextChanged);
            // 
            // AssociatePostalCodeTextBox
            // 
            this.AssociatePostalCodeTextBox.Location = new System.Drawing.Point(707, 57);
            this.AssociatePostalCodeTextBox.Name = "AssociatePostalCodeTextBox";
            this.AssociatePostalCodeTextBox.Size = new System.Drawing.Size(182, 20);
            this.AssociatePostalCodeTextBox.TabIndex = 56;
            // 
            // AssociateCityTextBox
            // 
            this.AssociateCityTextBox.Location = new System.Drawing.Point(392, 87);
            this.AssociateCityTextBox.Name = "AssociateCityTextBox";
            this.AssociateCityTextBox.Size = new System.Drawing.Size(182, 20);
            this.AssociateCityTextBox.TabIndex = 55;
            this.AssociateCityTextBox.TextChanged += new System.EventHandler(this.AssociateCityTextBox_TextChanged);
            // 
            // AssociateProvinceTextBox
            // 
            this.AssociateProvinceTextBox.Location = new System.Drawing.Point(392, 56);
            this.AssociateProvinceTextBox.Name = "AssociateProvinceTextBox";
            this.AssociateProvinceTextBox.Size = new System.Drawing.Size(182, 20);
            this.AssociateProvinceTextBox.TabIndex = 54;
            this.AssociateProvinceTextBox.TextChanged += new System.EventHandler(this.AssociateProvinceTextBox_TextChanged);
            // 
            // AssociateAddressTextBox
            // 
            this.AssociateAddressTextBox.Location = new System.Drawing.Point(115, 86);
            this.AssociateAddressTextBox.Name = "AssociateAddressTextBox";
            this.AssociateAddressTextBox.Size = new System.Drawing.Size(182, 20);
            this.AssociateAddressTextBox.TabIndex = 53;
            // 
            // AssociateNameTextBox
            // 
            this.AssociateNameTextBox.Location = new System.Drawing.Point(115, 56);
            this.AssociateNameTextBox.Name = "AssociateNameTextBox";
            this.AssociateNameTextBox.Size = new System.Drawing.Size(182, 20);
            this.AssociateNameTextBox.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(319, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 19);
            this.label7.TabIndex = 51;
            this.label7.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(319, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 50;
            this.label6.Text = "Province";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(593, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 19);
            this.label5.TabIndex = 49;
            this.label5.Text = "Postal Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 48;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 47;
            this.label3.Text = "Full Name";
            // 
            // LeaseOwner
            // 
            this.LeaseOwner.Location = new System.Drawing.Point(1042, 166);
            this.LeaseOwner.Name = "LeaseOwner";
            this.LeaseOwner.Size = new System.Drawing.Size(139, 20);
            this.LeaseOwner.TabIndex = 72;
            // 
            // WhichVehicleIsLeaseFor
            // 
            this.WhichVehicleIsLeaseFor.Location = new System.Drawing.Point(851, 141);
            this.WhichVehicleIsLeaseFor.Name = "WhichVehicleIsLeaseFor";
            this.WhichVehicleIsLeaseFor.Size = new System.Drawing.Size(176, 20);
            this.WhichVehicleIsLeaseFor.TabIndex = 71;
            // 
            // LeaseTerms
            // 
            this.LeaseTerms.Location = new System.Drawing.Point(851, 181);
            this.LeaseTerms.Name = "LeaseTerms";
            this.LeaseTerms.Size = new System.Drawing.Size(176, 20);
            this.LeaseTerms.TabIndex = 70;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(638, 182);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(177, 19);
            this.label16.TabIndex = 69;
            this.label16.Text = "The Terms Of The Lease";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1053, 144);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 19);
            this.label15.TabIndex = 68;
            this.label15.Text = "Lease Owner";
            // 
            // NumberOfMonthly
            // 
            this.NumberOfMonthly.Location = new System.Drawing.Point(571, 181);
            this.NumberOfMonthly.Name = "NumberOfMonthly";
            this.NumberOfMonthly.Size = new System.Drawing.Size(64, 20);
            this.NumberOfMonthly.TabIndex = 67;
            // 
            // AmountOfMonthly
            // 
            this.AmountOfMonthly.Location = new System.Drawing.Point(571, 141);
            this.AmountOfMonthly.Name = "AmountOfMonthly";
            this.AmountOfMonthly.Size = new System.Drawing.Size(64, 20);
            this.AmountOfMonthly.TabIndex = 66;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(632, 142);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(223, 19);
            this.label14.TabIndex = 65;
            this.label14.Text = "Which Vehicle The Lease Is For";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(353, 182);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(214, 19);
            this.label13.TabIndex = 64;
            this.label13.Text = "Number Of Monthly Payments";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(353, 141);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(205, 19);
            this.label12.TabIndex = 61;
            this.label12.Text = "Amount Of Monthly Payment";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(2, 181);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 19);
            this.label11.TabIndex = 60;
            this.label11.Text = "First Payment Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(2, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(222, 19);
            this.label10.TabIndex = 59;
            this.label10.Text = "Date The Lease Contract Begin";
            // 
            // KilometereOnOdometertxt
            // 
            this.KilometereOnOdometertxt.Location = new System.Drawing.Point(707, 275);
            this.KilometereOnOdometertxt.Name = "KilometereOnOdometertxt";
            this.KilometereOnOdometertxt.Size = new System.Drawing.Size(108, 20);
            this.KilometereOnOdometertxt.TabIndex = 84;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(525, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 19);
            this.label2.TabIndex = 83;
            this.label2.Text = "Kilometer On Odometere";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(847, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 19);
            this.label9.TabIndex = 82;
            this.label9.Text = "Is Car New";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(525, 248);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 19);
            this.label17.TabIndex = 79;
            this.label17.Text = "Lease Year";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(299, 280);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 19);
            this.label18.TabIndex = 78;
            this.label18.Text = "Color";
            // 
            // ModelTxt
            // 
            this.ModelTxt.Location = new System.Drawing.Point(134, 280);
            this.ModelTxt.Name = "ModelTxt";
            this.ModelTxt.Size = new System.Drawing.Size(159, 20);
            this.ModelTxt.TabIndex = 77;
            // 
            // VehicleVinTxt
            // 
            this.VehicleVinTxt.Location = new System.Drawing.Point(134, 249);
            this.VehicleVinTxt.Name = "VehicleVinTxt";
            this.VehicleVinTxt.Size = new System.Drawing.Size(161, 20);
            this.VehicleVinTxt.TabIndex = 76;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(301, 248);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 19);
            this.label19.TabIndex = 75;
            this.label19.Text = "Car Type";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(11, 280);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 19);
            this.label20.TabIndex = 74;
            this.label20.Text = "Model";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(11, 248);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(91, 19);
            this.label21.TabIndex = 73;
            this.label21.Text = "Vehicle VIN";
            // 
            // BookValueTxt
            // 
            this.BookValueTxt.Location = new System.Drawing.Point(948, 278);
            this.BookValueTxt.Name = "BookValueTxt";
            this.BookValueTxt.Size = new System.Drawing.Size(121, 20);
            this.BookValueTxt.TabIndex = 88;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(847, 278);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(87, 19);
            this.label22.TabIndex = 87;
            this.label22.Text = "Book Value";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(12, 306);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(119, 19);
            this.label23.TabIndex = 89;
            this.label23.Text = "Transmission ID";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(301, 308);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(61, 19);
            this.label24.TabIndex = 91;
            this.label24.Text = "Options";
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(105, 409);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(158, 20);
            this.AmountTextBox.TabIndex = 100;
            // 
            // DateTextBox
            // 
            this.DateTextBox.Location = new System.Drawing.Point(105, 383);
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(158, 20);
            this.DateTextBox.TabIndex = 99;
            // 
            // LeaseIDTextBox
            // 
            this.LeaseIDTextBox.Location = new System.Drawing.Point(105, 357);
            this.LeaseIDTextBox.Name = "LeaseIDTextBox";
            this.LeaseIDTextBox.Size = new System.Drawing.Size(158, 20);
            this.LeaseIDTextBox.TabIndex = 98;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(11, 408);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(61, 19);
            this.label26.TabIndex = 97;
            this.label26.Text = "Amount";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(11, 383);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(42, 19);
            this.label27.TabIndex = 96;
            this.label27.Text = "Date";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(11, 356);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(72, 19);
            this.label28.TabIndex = 95;
            this.label28.Text = "Lease ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(332, 335);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(862, 280);
            this.dataGridView1.TabIndex = 101;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ViewButton
            // 
            this.ViewButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ViewButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewButton.Location = new System.Drawing.Point(29, 481);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(128, 29);
            this.ViewButton.TabIndex = 107;
            this.ViewButton.Text = "View";
            this.ViewButton.UseVisualStyleBackColor = false;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.DeleteButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(29, 516);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(128, 29);
            this.DeleteButton.TabIndex = 106;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            // 
            // VoidButton
            // 
            this.VoidButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.VoidButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VoidButton.Location = new System.Drawing.Point(181, 481);
            this.VoidButton.Name = "VoidButton";
            this.VoidButton.Size = new System.Drawing.Size(128, 29);
            this.VoidButton.TabIndex = 105;
            this.VoidButton.Text = "Void";
            this.VoidButton.UseVisualStyleBackColor = false;
            // 
            // TerminateButton
            // 
            this.TerminateButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TerminateButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TerminateButton.Location = new System.Drawing.Point(181, 516);
            this.TerminateButton.Name = "TerminateButton";
            this.TerminateButton.Size = new System.Drawing.Size(128, 29);
            this.TerminateButton.TabIndex = 104;
            this.TerminateButton.Text = "Terminate";
            this.TerminateButton.UseVisualStyleBackColor = false;
            // 
            // InsertButton
            // 
            this.InsertButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.InsertButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertButton.Location = new System.Drawing.Point(29, 446);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(128, 29);
            this.InsertButton.TabIndex = 103;
            this.InsertButton.Text = "Insert";
            this.InsertButton.UseVisualStyleBackColor = false;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.EditButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.Location = new System.Drawing.Point(181, 446);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(128, 29);
            this.EditButton.TabIndex = 102;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // OptionComboBox
            // 
            this.OptionComboBox.FormattingEnabled = true;
            this.OptionComboBox.Items.AddRange(new object[] {
            "Air Condition",
            "Power Locks"});
            this.OptionComboBox.Location = new System.Drawing.Point(392, 306);
            this.OptionComboBox.Name = "OptionComboBox";
            this.OptionComboBox.Size = new System.Drawing.Size(108, 21);
            this.OptionComboBox.TabIndex = 108;
            // 
            // TransmissionComboBox
            // 
            this.TransmissionComboBox.FormattingEnabled = true;
            this.TransmissionComboBox.Items.AddRange(new object[] {
            "Auto",
            "Manual"});
            this.TransmissionComboBox.Location = new System.Drawing.Point(132, 309);
            this.TransmissionComboBox.Name = "TransmissionComboBox";
            this.TransmissionComboBox.Size = new System.Drawing.Size(161, 21);
            this.TransmissionComboBox.TabIndex = 109;
            // 
            // IsCarNewComboBox
            // 
            this.IsCarNewComboBox.FormattingEnabled = true;
            this.IsCarNewComboBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.IsCarNewComboBox.Location = new System.Drawing.Point(948, 248);
            this.IsCarNewComboBox.Name = "IsCarNewComboBox";
            this.IsCarNewComboBox.Size = new System.Drawing.Size(121, 21);
            this.IsCarNewComboBox.TabIndex = 110;
            // 
            // ColorComboBox
            // 
            this.ColorComboBox.FormattingEnabled = true;
            this.ColorComboBox.Items.AddRange(new object[] {
            "Deep Blue",
            "Racey Red",
            "Lemon Yellow",
            "Lime Green",
            "Silver Grey"});
            this.ColorComboBox.Location = new System.Drawing.Point(392, 278);
            this.ColorComboBox.Name = "ColorComboBox";
            this.ColorComboBox.Size = new System.Drawing.Size(108, 21);
            this.ColorComboBox.TabIndex = 111;
            // 
            // cartype
            // 
            this.cartype.FormattingEnabled = true;
            this.cartype.Items.AddRange(new object[] {
            "2dr Coupe",
            "4dr Coupe",
            "Truck",
            "SUV",
            "Van"});
            this.cartype.Location = new System.Drawing.Point(392, 249);
            this.cartype.Name = "cartype";
            this.cartype.Size = new System.Drawing.Size(108, 21);
            this.cartype.TabIndex = 112;
            // 
            // LeaseYearComboBox
            // 
            this.LeaseYearComboBox.FormattingEnabled = true;
            this.LeaseYearComboBox.Items.AddRange(new object[] {
            "12",
            "24",
            "36\t",
            "48"});
            this.LeaseYearComboBox.Location = new System.Drawing.Point(707, 246);
            this.LeaseYearComboBox.Name = "LeaseYearComboBox";
            this.LeaseYearComboBox.Size = new System.Drawing.Size(108, 21);
            this.LeaseYearComboBox.TabIndex = 113;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label25.Location = new System.Drawing.Point(1, 31);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(93, 20);
            this.label25.TabIndex = 114;
            this.label25.Text = "Customers";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label29.Location = new System.Drawing.Point(4, 121);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(64, 20);
            this.label29.TabIndex = 115;
            this.label29.Text = "Leases";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label30.Location = new System.Drawing.Point(4, 218);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(73, 20);
            this.label30.TabIndex = 116;
            this.label30.Text = "Vehicles";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label31.Location = new System.Drawing.Point(4, 335);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(84, 20);
            this.label31.TabIndex = 117;
            this.label31.Text = "Payments";
            // 
            // BeginDate
            // 
            this.BeginDate.CustomFormat = "MMMM dd, yyyy";
            this.BeginDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BeginDate.Location = new System.Drawing.Point(223, 144);
            this.BeginDate.Name = "BeginDate";
            this.BeginDate.Size = new System.Drawing.Size(126, 20);
            this.BeginDate.TabIndex = 184;
            // 
            // FirstPaymentDate
            // 
            this.FirstPaymentDate.CustomFormat = "MMMM dd, yyyy";
            this.FirstPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FirstPaymentDate.Location = new System.Drawing.Point(223, 179);
            this.FirstPaymentDate.Name = "FirstPaymentDate";
            this.FirstPaymentDate.Size = new System.Drawing.Size(126, 20);
            this.FirstPaymentDate.TabIndex = 185;
            // 
            // Associate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 627);
            this.Controls.Add(this.FirstPaymentDate);
            this.Controls.Add(this.BeginDate);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.LeaseYearComboBox);
            this.Controls.Add(this.cartype);
            this.Controls.Add(this.ColorComboBox);
            this.Controls.Add(this.IsCarNewComboBox);
            this.Controls.Add(this.TransmissionComboBox);
            this.Controls.Add(this.OptionComboBox);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.VoidButton);
            this.Controls.Add(this.TerminateButton);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.DateTextBox);
            this.Controls.Add(this.LeaseIDTextBox);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.BookValueTxt);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.KilometereOnOdometertxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.ModelTxt);
            this.Controls.Add(this.VehicleVinTxt);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.LeaseOwner);
            this.Controls.Add(this.WhichVehicleIsLeaseFor);
            this.Controls.Add(this.LeaseTerms);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.NumberOfMonthly);
            this.Controls.Add(this.AmountOfMonthly);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AssociatePhoneNumberTextBox);
            this.Controls.Add(this.AssociatePostalCodeTextBox);
            this.Controls.Add(this.AssociateCityTextBox);
            this.Controls.Add(this.AssociateProvinceTextBox);
            this.Controls.Add(this.AssociateAddressTextBox);
            this.Controls.Add(this.AssociateNameTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AssociateComboBox);
            this.Name = "Associate";
            this.Text = "Associate";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox AssociateComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox AssociatePhoneNumberTextBox;
        private System.Windows.Forms.TextBox AssociatePostalCodeTextBox;
        private System.Windows.Forms.TextBox AssociateCityTextBox;
        private System.Windows.Forms.TextBox AssociateProvinceTextBox;
        private System.Windows.Forms.TextBox AssociateAddressTextBox;
        private System.Windows.Forms.TextBox AssociateNameTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LeaseOwner;
        private System.Windows.Forms.TextBox WhichVehicleIsLeaseFor;
        private System.Windows.Forms.TextBox LeaseTerms;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox NumberOfMonthly;
        private System.Windows.Forms.TextBox AmountOfMonthly;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox KilometereOnOdometertxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox ModelTxt;
        private System.Windows.Forms.TextBox VehicleVinTxt;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox BookValueTxt;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.TextBox DateTextBox;
        private System.Windows.Forms.TextBox LeaseIDTextBox;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button VoidButton;
        private System.Windows.Forms.Button TerminateButton;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.ComboBox OptionComboBox;
        private System.Windows.Forms.ComboBox TransmissionComboBox;
        private System.Windows.Forms.ComboBox IsCarNewComboBox;
        private System.Windows.Forms.ComboBox ColorComboBox;
        private System.Windows.Forms.ComboBox cartype;
        private System.Windows.Forms.ComboBox LeaseYearComboBox;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.DateTimePicker BeginDate;
        private System.Windows.Forms.DateTimePicker FirstPaymentDate;
    }
}