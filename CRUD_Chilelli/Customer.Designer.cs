
namespace CRUD_Chilelli
{
    partial class Customer
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
            this.CustomerGridView = new System.Windows.Forms.DataGridView();
            this.IDText = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.IDLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.titleText = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.fNameLabel = new System.Windows.Forms.Label();
            this.grabInfo = new System.Windows.Forms.Button();
            this.middleNameText = new System.Windows.Forms.TextBox();
            this.middleNameLabel = new System.Windows.Forms.Label();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.suffixText = new System.Windows.Forms.TextBox();
            this.suffixLabel = new System.Windows.Forms.Label();
            this.adressLine2Text = new System.Windows.Forms.TextBox();
            this.adressLine2Label = new System.Windows.Forms.Label();
            this.adressLine1Text = new System.Windows.Forms.TextBox();
            this.adressLine1Label = new System.Windows.Forms.Label();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.emailAdressText = new System.Windows.Forms.TextBox();
            this.emailAdressLabel = new System.Windows.Forms.Label();
            this.salesPersonText = new System.Windows.Forms.TextBox();
            this.salesPersonLabel = new System.Windows.Forms.Label();
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.companyNameText = new System.Windows.Forms.TextBox();
            this.countryRegionText = new System.Windows.Forms.TextBox();
            this.countryRegionLabel = new System.Windows.Forms.Label();
            this.stateProvinceText = new System.Windows.Forms.TextBox();
            this.stateProvinceLabel = new System.Windows.Forms.Label();
            this.cityText = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.postalCodeLabel = new System.Windows.Forms.Label();
            this.postalCodeText = new System.Windows.Forms.TextBox();
            this.addressTypeText = new System.Windows.Forms.TextBox();
            this.addressTypeLabel = new System.Windows.Forms.Label();
            this.helpButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerGridView
            // 
            this.CustomerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerGridView.Dock = System.Windows.Forms.DockStyle.Right;
            this.CustomerGridView.Location = new System.Drawing.Point(358, 0);
            this.CustomerGridView.Name = "CustomerGridView";
            this.CustomerGridView.Size = new System.Drawing.Size(552, 684);
            this.CustomerGridView.TabIndex = 0;
            // 
            // IDText
            // 
            this.IDText.Location = new System.Drawing.Point(12, 25);
            this.IDText.Name = "IDText";
            this.IDText.Size = new System.Drawing.Size(100, 20);
            this.IDText.TabIndex = 1;
            this.IDText.MouseClick += new System.Windows.Forms.MouseEventHandler(this.IDText_MouseClick);
            this.IDText.Leave += new System.EventHandler(this.IDText_Leave);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.IndianRed;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButton.Location = new System.Drawing.Point(241, 49);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(111, 308);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(12, 9);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(18, 13);
            this.IDLabel.TabIndex = 3;
            this.IDLabel.Text = "ID";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(12, 48);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(27, 13);
            this.TitleLabel.TabIndex = 4;
            this.TitleLabel.Text = "Title";
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(12, 64);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(100, 20);
            this.titleText.TabIndex = 5;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.LightGreen;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateButton.Location = new System.Drawing.Point(131, 204);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(104, 152);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(12, 103);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(100, 20);
            this.firstNameText.TabIndex = 8;
            // 
            // fNameLabel
            // 
            this.fNameLabel.AutoSize = true;
            this.fNameLabel.Location = new System.Drawing.Point(12, 87);
            this.fNameLabel.Name = "fNameLabel";
            this.fNameLabel.Size = new System.Drawing.Size(57, 13);
            this.fNameLabel.TabIndex = 7;
            this.fNameLabel.Text = "First Name";
            // 
            // grabInfo
            // 
            this.grabInfo.BackColor = System.Drawing.Color.Aquamarine;
            this.grabInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grabInfo.Location = new System.Drawing.Point(131, 360);
            this.grabInfo.Name = "grabInfo";
            this.grabInfo.Size = new System.Drawing.Size(221, 309);
            this.grabInfo.TabIndex = 9;
            this.grabInfo.Text = "Populate Textboxes";
            this.grabInfo.UseVisualStyleBackColor = false;
            this.grabInfo.Click += new System.EventHandler(this.grabInfo_Click);
            // 
            // middleNameText
            // 
            this.middleNameText.Location = new System.Drawing.Point(12, 142);
            this.middleNameText.Name = "middleNameText";
            this.middleNameText.Size = new System.Drawing.Size(100, 20);
            this.middleNameText.TabIndex = 11;
            // 
            // middleNameLabel
            // 
            this.middleNameLabel.AutoSize = true;
            this.middleNameLabel.Location = new System.Drawing.Point(12, 126);
            this.middleNameLabel.Name = "middleNameLabel";
            this.middleNameLabel.Size = new System.Drawing.Size(69, 13);
            this.middleNameLabel.TabIndex = 10;
            this.middleNameLabel.Text = "Middle Name";
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(12, 181);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(100, 20);
            this.lastNameText.TabIndex = 13;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(12, 165);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.TabIndex = 12;
            this.lastNameLabel.Text = "Last Name";
            // 
            // suffixText
            // 
            this.suffixText.Location = new System.Drawing.Point(12, 220);
            this.suffixText.Name = "suffixText";
            this.suffixText.Size = new System.Drawing.Size(100, 20);
            this.suffixText.TabIndex = 15;
            // 
            // suffixLabel
            // 
            this.suffixLabel.AutoSize = true;
            this.suffixLabel.Location = new System.Drawing.Point(12, 204);
            this.suffixLabel.Name = "suffixLabel";
            this.suffixLabel.Size = new System.Drawing.Size(33, 13);
            this.suffixLabel.TabIndex = 14;
            this.suffixLabel.Text = "Suffix";
            // 
            // adressLine2Text
            // 
            this.adressLine2Text.Location = new System.Drawing.Point(12, 493);
            this.adressLine2Text.Name = "adressLine2Text";
            this.adressLine2Text.Size = new System.Drawing.Size(100, 20);
            this.adressLine2Text.TabIndex = 27;
            // 
            // adressLine2Label
            // 
            this.adressLine2Label.AutoSize = true;
            this.adressLine2Label.Location = new System.Drawing.Point(12, 477);
            this.adressLine2Label.Name = "adressLine2Label";
            this.adressLine2Label.Size = new System.Drawing.Size(71, 13);
            this.adressLine2Label.TabIndex = 26;
            this.adressLine2Label.Text = "Adress Line 2";
            // 
            // adressLine1Text
            // 
            this.adressLine1Text.Location = new System.Drawing.Point(12, 454);
            this.adressLine1Text.Name = "adressLine1Text";
            this.adressLine1Text.Size = new System.Drawing.Size(100, 20);
            this.adressLine1Text.TabIndex = 25;
            // 
            // adressLine1Label
            // 
            this.adressLine1Label.AutoSize = true;
            this.adressLine1Label.Location = new System.Drawing.Point(12, 438);
            this.adressLine1Label.Name = "adressLine1Label";
            this.adressLine1Label.Size = new System.Drawing.Size(71, 13);
            this.adressLine1Label.TabIndex = 24;
            this.adressLine1Label.Text = "Adress Line 1";
            // 
            // phoneText
            // 
            this.phoneText.Location = new System.Drawing.Point(12, 376);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(100, 20);
            this.phoneText.TabIndex = 23;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(12, 360);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(38, 13);
            this.phoneLabel.TabIndex = 22;
            this.phoneLabel.Text = "Phone";
            // 
            // emailAdressText
            // 
            this.emailAdressText.Location = new System.Drawing.Point(12, 337);
            this.emailAdressText.Name = "emailAdressText";
            this.emailAdressText.Size = new System.Drawing.Size(100, 20);
            this.emailAdressText.TabIndex = 21;
            // 
            // emailAdressLabel
            // 
            this.emailAdressLabel.AutoSize = true;
            this.emailAdressLabel.Location = new System.Drawing.Point(12, 321);
            this.emailAdressLabel.Name = "emailAdressLabel";
            this.emailAdressLabel.Size = new System.Drawing.Size(73, 13);
            this.emailAdressLabel.TabIndex = 20;
            this.emailAdressLabel.Text = "Email Address";
            // 
            // salesPersonText
            // 
            this.salesPersonText.Location = new System.Drawing.Point(12, 298);
            this.salesPersonText.Name = "salesPersonText";
            this.salesPersonText.Size = new System.Drawing.Size(100, 20);
            this.salesPersonText.TabIndex = 19;
            // 
            // salesPersonLabel
            // 
            this.salesPersonLabel.AutoSize = true;
            this.salesPersonLabel.Location = new System.Drawing.Point(12, 282);
            this.salesPersonLabel.Name = "salesPersonLabel";
            this.salesPersonLabel.Size = new System.Drawing.Size(69, 13);
            this.salesPersonLabel.TabIndex = 18;
            this.salesPersonLabel.Text = "Sales Person";
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Location = new System.Drawing.Point(12, 243);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(82, 13);
            this.companyNameLabel.TabIndex = 17;
            this.companyNameLabel.Text = "Company Name";
            // 
            // companyNameText
            // 
            this.companyNameText.Location = new System.Drawing.Point(12, 259);
            this.companyNameText.Name = "companyNameText";
            this.companyNameText.Size = new System.Drawing.Size(100, 20);
            this.companyNameText.TabIndex = 16;
            // 
            // countryRegionText
            // 
            this.countryRegionText.Location = new System.Drawing.Point(12, 610);
            this.countryRegionText.Name = "countryRegionText";
            this.countryRegionText.Size = new System.Drawing.Size(100, 20);
            this.countryRegionText.TabIndex = 33;
            // 
            // countryRegionLabel
            // 
            this.countryRegionLabel.AutoSize = true;
            this.countryRegionLabel.Location = new System.Drawing.Point(12, 594);
            this.countryRegionLabel.Name = "countryRegionLabel";
            this.countryRegionLabel.Size = new System.Drawing.Size(80, 13);
            this.countryRegionLabel.TabIndex = 32;
            this.countryRegionLabel.Text = "Country Region";
            // 
            // stateProvinceText
            // 
            this.stateProvinceText.Location = new System.Drawing.Point(12, 571);
            this.stateProvinceText.Name = "stateProvinceText";
            this.stateProvinceText.Size = new System.Drawing.Size(100, 20);
            this.stateProvinceText.TabIndex = 31;
            // 
            // stateProvinceLabel
            // 
            this.stateProvinceLabel.AutoSize = true;
            this.stateProvinceLabel.Location = new System.Drawing.Point(12, 555);
            this.stateProvinceLabel.Name = "stateProvinceLabel";
            this.stateProvinceLabel.Size = new System.Drawing.Size(85, 13);
            this.stateProvinceLabel.TabIndex = 30;
            this.stateProvinceLabel.Text = "State / Province";
            // 
            // cityText
            // 
            this.cityText.Location = new System.Drawing.Point(12, 532);
            this.cityText.Name = "cityText";
            this.cityText.Size = new System.Drawing.Size(100, 20);
            this.cityText.TabIndex = 29;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(12, 516);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(24, 13);
            this.cityLabel.TabIndex = 28;
            this.cityLabel.Text = "City";
            // 
            // postalCodeLabel
            // 
            this.postalCodeLabel.AutoSize = true;
            this.postalCodeLabel.Location = new System.Drawing.Point(12, 633);
            this.postalCodeLabel.Name = "postalCodeLabel";
            this.postalCodeLabel.Size = new System.Drawing.Size(64, 13);
            this.postalCodeLabel.TabIndex = 34;
            this.postalCodeLabel.Text = "Postal Code";
            // 
            // postalCodeText
            // 
            this.postalCodeText.Location = new System.Drawing.Point(12, 649);
            this.postalCodeText.Name = "postalCodeText";
            this.postalCodeText.Size = new System.Drawing.Size(100, 20);
            this.postalCodeText.TabIndex = 35;
            // 
            // addressTypeText
            // 
            this.addressTypeText.Location = new System.Drawing.Point(12, 415);
            this.addressTypeText.Name = "addressTypeText";
            this.addressTypeText.Size = new System.Drawing.Size(100, 20);
            this.addressTypeText.TabIndex = 37;
            // 
            // addressTypeLabel
            // 
            this.addressTypeLabel.AutoSize = true;
            this.addressTypeLabel.Location = new System.Drawing.Point(12, 399);
            this.addressTypeLabel.Name = "addressTypeLabel";
            this.addressTypeLabel.Size = new System.Drawing.Size(69, 13);
            this.addressTypeLabel.TabIndex = 36;
            this.addressTypeLabel.Text = "AddressType";
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.Color.Plum;
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.helpButton.Location = new System.Drawing.Point(131, 9);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(221, 33);
            this.helpButton.TabIndex = 38;
            this.helpButton.Text = "Press for Help";
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.GreenYellow;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton.Location = new System.Drawing.Point(131, 48);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(104, 153);
            this.addButton.TabIndex = 39;
            this.addButton.Text = "Add New";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 684);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.addressTypeText);
            this.Controls.Add(this.addressTypeLabel);
            this.Controls.Add(this.postalCodeText);
            this.Controls.Add(this.postalCodeLabel);
            this.Controls.Add(this.countryRegionText);
            this.Controls.Add(this.countryRegionLabel);
            this.Controls.Add(this.stateProvinceText);
            this.Controls.Add(this.stateProvinceLabel);
            this.Controls.Add(this.cityText);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.adressLine2Text);
            this.Controls.Add(this.adressLine2Label);
            this.Controls.Add(this.adressLine1Text);
            this.Controls.Add(this.adressLine1Label);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.emailAdressText);
            this.Controls.Add(this.emailAdressLabel);
            this.Controls.Add(this.salesPersonText);
            this.Controls.Add(this.salesPersonLabel);
            this.Controls.Add(this.companyNameLabel);
            this.Controls.Add(this.companyNameText);
            this.Controls.Add(this.suffixText);
            this.Controls.Add(this.suffixLabel);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.middleNameText);
            this.Controls.Add(this.middleNameLabel);
            this.Controls.Add(this.grabInfo);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.fNameLabel);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.IDText);
            this.Controls.Add(this.CustomerGridView);
            this.Name = "Customer";
            this.Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CustomerGridView;
        private System.Windows.Forms.TextBox IDText;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.Label fNameLabel;
        private System.Windows.Forms.Button grabInfo;
        private System.Windows.Forms.TextBox middleNameText;
        private System.Windows.Forms.Label middleNameLabel;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox suffixText;
        private System.Windows.Forms.Label suffixLabel;
        private System.Windows.Forms.TextBox adressLine2Text;
        private System.Windows.Forms.Label adressLine2Label;
        private System.Windows.Forms.TextBox adressLine1Text;
        private System.Windows.Forms.Label adressLine1Label;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox emailAdressText;
        private System.Windows.Forms.Label emailAdressLabel;
        private System.Windows.Forms.TextBox salesPersonText;
        private System.Windows.Forms.Label salesPersonLabel;
        private System.Windows.Forms.Label companyNameLabel;
        private System.Windows.Forms.TextBox companyNameText;
        private System.Windows.Forms.TextBox countryRegionText;
        private System.Windows.Forms.Label countryRegionLabel;
        private System.Windows.Forms.TextBox stateProvinceText;
        private System.Windows.Forms.Label stateProvinceLabel;
        private System.Windows.Forms.TextBox cityText;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label postalCodeLabel;
        private System.Windows.Forms.TextBox postalCodeText;
        private System.Windows.Forms.TextBox addressTypeText;
        private System.Windows.Forms.Label addressTypeLabel;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button addButton;
    }
}