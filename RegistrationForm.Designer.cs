namespace Duong_4
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.registrantInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.dobMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.dobLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.registrationInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.pricePerClassLabel = new System.Windows.Forms.Label();
            this.numberClassesLabel = new System.Windows.Forms.Label();
            this.maxRegistrationLabel = new System.Windows.Forms.Label();
            this.classesListBox = new System.Windows.Forms.ListBox();
            this.animationPriceLabel = new System.Windows.Forms.Label();
            this.liveActionPricelabel = new System.Windows.Forms.Label();
            this.animationRadioButton = new System.Windows.Forms.RadioButton();
            this.liveActionRadioButton = new System.Windows.Forms.RadioButton();
            this.cashRadioButton = new System.Windows.Forms.RadioButton();
            this.checkRadioButton = new System.Windows.Forms.RadioButton();
            this.paymentLabel = new System.Windows.Forms.Label();
            this.emailCheckBox = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTipSave = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipClear = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipExit = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipAbout = new System.Windows.Forms.ToolTip(this.components);
            this.dateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.registrantInfoGroupBox.SuspendLayout();
            this.registrationInfoGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Mistral", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hopkins Film School";
            // 
            // registrantInfoGroupBox
            // 
            this.registrantInfoGroupBox.Controls.Add(this.statusComboBox);
            this.registrantInfoGroupBox.Controls.Add(this.statusLabel);
            this.registrantInfoGroupBox.Controls.Add(this.dobMaskedTextBox);
            this.registrantInfoGroupBox.Controls.Add(this.dobLabel);
            this.registrantInfoGroupBox.Controls.Add(this.emailTextBox);
            this.registrantInfoGroupBox.Controls.Add(this.emailLabel);
            this.registrantInfoGroupBox.Controls.Add(this.lastNameTextBox);
            this.registrantInfoGroupBox.Controls.Add(this.lastNameLabel);
            this.registrantInfoGroupBox.Controls.Add(this.firstNameLabel);
            this.registrantInfoGroupBox.Controls.Add(this.firstNameTextBox);
            this.registrantInfoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrantInfoGroupBox.Location = new System.Drawing.Point(13, 218);
            this.registrantInfoGroupBox.Name = "registrantInfoGroupBox";
            this.registrantInfoGroupBox.Size = new System.Drawing.Size(759, 178);
            this.registrantInfoGroupBox.TabIndex = 3;
            this.registrantInfoGroupBox.TabStop = false;
            this.registrantInfoGroupBox.Text = "Registrant Information";
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(231, 143);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(175, 26);
            this.statusComboBox.TabIndex = 10;
            this.statusComboBox.SelectedIndexChanged += new System.EventHandler(this.statusComboBox_SelectedIndexChanged);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(44, 146);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(162, 18);
            this.statusLabel.TabIndex = 9;
            this.statusLabel.Text = "Status of the Registrant";
            this.statusLabel.Click += new System.EventHandler(this.statusLabel_Click);
            // 
            // dobMaskedTextBox
            // 
            this.dobMaskedTextBox.Location = new System.Drawing.Point(231, 113);
            this.dobMaskedTextBox.Mask = "00/00/0000";
            this.dobMaskedTextBox.Name = "dobMaskedTextBox";
            this.dobMaskedTextBox.Size = new System.Drawing.Size(100, 24);
            this.dobMaskedTextBox.TabIndex = 8;
            this.dobMaskedTextBox.ValidatingType = typeof(System.DateTime);
            this.dobMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.dobMaskedTextBox_MaskInputRejected);
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Location = new System.Drawing.Point(44, 116);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(90, 18);
            this.dobLabel.TabIndex = 6;
            this.dobLabel.Text = "Date of Birth";
            this.dobLabel.Click += new System.EventHandler(this.dobLabel_Click);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(231, 83);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(239, 24);
            this.emailTextBox.TabIndex = 5;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(44, 86);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(103, 18);
            this.emailLabel.TabIndex = 4;
            this.emailLabel.Text = "Email Address";
            this.emailLabel.Click += new System.EventHandler(this.emailLabel_Click);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(231, 53);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(150, 24);
            this.lastNameTextBox.TabIndex = 3;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.lastNameTextBox_TextChanged);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(44, 56);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(80, 18);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name";
            this.lastNameLabel.Click += new System.EventHandler(this.lastNameLabel_Click);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(44, 26);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(81, 18);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First Name";
            this.firstNameLabel.Click += new System.EventHandler(this.firstNameLabel_Click);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(231, 23);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(150, 24);
            this.firstNameTextBox.TabIndex = 0;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.firstNameTextBox_TextChanged);
            // 
            // registrationInfoGroupBox
            // 
            this.registrationInfoGroupBox.Controls.Add(this.totalPriceLabel);
            this.registrationInfoGroupBox.Controls.Add(this.pricePerClassLabel);
            this.registrationInfoGroupBox.Controls.Add(this.numberClassesLabel);
            this.registrationInfoGroupBox.Controls.Add(this.maxRegistrationLabel);
            this.registrationInfoGroupBox.Controls.Add(this.classesListBox);
            this.registrationInfoGroupBox.Controls.Add(this.animationPriceLabel);
            this.registrationInfoGroupBox.Controls.Add(this.liveActionPricelabel);
            this.registrationInfoGroupBox.Controls.Add(this.animationRadioButton);
            this.registrationInfoGroupBox.Controls.Add(this.liveActionRadioButton);
            this.registrationInfoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationInfoGroupBox.Location = new System.Drawing.Point(13, 402);
            this.registrationInfoGroupBox.Name = "registrationInfoGroupBox";
            this.registrationInfoGroupBox.Size = new System.Drawing.Size(759, 271);
            this.registrationInfoGroupBox.TabIndex = 4;
            this.registrationInfoGroupBox.TabStop = false;
            this.registrationInfoGroupBox.Text = "Registration Information ";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Location = new System.Drawing.Point(555, 223);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(0, 18);
            this.totalPriceLabel.TabIndex = 8;
            // 
            // pricePerClassLabel
            // 
            this.pricePerClassLabel.AutoSize = true;
            this.pricePerClassLabel.Location = new System.Drawing.Point(268, 223);
            this.pricePerClassLabel.Name = "pricePerClassLabel";
            this.pricePerClassLabel.Size = new System.Drawing.Size(0, 18);
            this.pricePerClassLabel.TabIndex = 7;
            // 
            // numberClassesLabel
            // 
            this.numberClassesLabel.AutoSize = true;
            this.numberClassesLabel.Location = new System.Drawing.Point(41, 223);
            this.numberClassesLabel.Name = "numberClassesLabel";
            this.numberClassesLabel.Size = new System.Drawing.Size(0, 18);
            this.numberClassesLabel.TabIndex = 6;
            // 
            // maxRegistrationLabel
            // 
            this.maxRegistrationLabel.AutoSize = true;
            this.maxRegistrationLabel.Location = new System.Drawing.Point(206, 61);
            this.maxRegistrationLabel.Name = "maxRegistrationLabel";
            this.maxRegistrationLabel.Size = new System.Drawing.Size(0, 18);
            this.maxRegistrationLabel.TabIndex = 5;
            // 
            // classesListBox
            // 
            this.classesListBox.FormattingEnabled = true;
            this.classesListBox.ItemHeight = 18;
            this.classesListBox.Location = new System.Drawing.Point(231, 90);
            this.classesListBox.Name = "classesListBox";
            this.classesListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.classesListBox.Size = new System.Drawing.Size(243, 130);
            this.classesListBox.Sorted = true;
            this.classesListBox.TabIndex = 4;
            this.classesListBox.SelectedIndexChanged += new System.EventHandler(this.classesListBox_SelectedIndexChanged);
            // 
            // animationPriceLabel
            // 
            this.animationPriceLabel.AutoSize = true;
            this.animationPriceLabel.Location = new System.Drawing.Point(601, 35);
            this.animationPriceLabel.Name = "animationPriceLabel";
            this.animationPriceLabel.Size = new System.Drawing.Size(0, 18);
            this.animationPriceLabel.TabIndex = 3;
            // 
            // liveActionPricelabel
            // 
            this.liveActionPricelabel.AutoSize = true;
            this.liveActionPricelabel.Location = new System.Drawing.Point(153, 35);
            this.liveActionPricelabel.Name = "liveActionPricelabel";
            this.liveActionPricelabel.Size = new System.Drawing.Size(0, 18);
            this.liveActionPricelabel.TabIndex = 2;
            // 
            // animationRadioButton
            // 
            this.animationRadioButton.AutoSize = true;
            this.animationRadioButton.Location = new System.Drawing.Point(501, 33);
            this.animationRadioButton.Name = "animationRadioButton";
            this.animationRadioButton.Size = new System.Drawing.Size(94, 22);
            this.animationRadioButton.TabIndex = 1;
            this.animationRadioButton.Text = "Animation";
            this.animationRadioButton.UseVisualStyleBackColor = true;
            this.animationRadioButton.CheckedChanged += new System.EventHandler(this.checkChange);
            // 
            // liveActionRadioButton
            // 
            this.liveActionRadioButton.AutoSize = true;
            this.liveActionRadioButton.Checked = true;
            this.liveActionRadioButton.Location = new System.Drawing.Point(47, 33);
            this.liveActionRadioButton.Name = "liveActionRadioButton";
            this.liveActionRadioButton.Size = new System.Drawing.Size(100, 22);
            this.liveActionRadioButton.TabIndex = 0;
            this.liveActionRadioButton.TabStop = true;
            this.liveActionRadioButton.Text = "Live Action";
            this.liveActionRadioButton.UseVisualStyleBackColor = true;
            this.liveActionRadioButton.CheckedChanged += new System.EventHandler(this.checkChange);
            // 
            // cashRadioButton
            // 
            this.cashRadioButton.AutoSize = true;
            this.cashRadioButton.Checked = true;
            this.cashRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashRadioButton.Location = new System.Drawing.Point(284, 677);
            this.cashRadioButton.Name = "cashRadioButton";
            this.cashRadioButton.Size = new System.Drawing.Size(64, 22);
            this.cashRadioButton.TabIndex = 5;
            this.cashRadioButton.TabStop = true;
            this.cashRadioButton.Text = "Cash";
            this.cashRadioButton.UseVisualStyleBackColor = true;
            // 
            // checkRadioButton
            // 
            this.checkRadioButton.AutoSize = true;
            this.checkRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkRadioButton.Location = new System.Drawing.Point(496, 677);
            this.checkRadioButton.Name = "checkRadioButton";
            this.checkRadioButton.Size = new System.Drawing.Size(72, 22);
            this.checkRadioButton.TabIndex = 6;
            this.checkRadioButton.Text = "Check";
            this.checkRadioButton.UseVisualStyleBackColor = true;
            // 
            // paymentLabel
            // 
            this.paymentLabel.AutoSize = true;
            this.paymentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentLabel.Location = new System.Drawing.Point(57, 679);
            this.paymentLabel.Name = "paymentLabel";
            this.paymentLabel.Size = new System.Drawing.Size(101, 18);
            this.paymentLabel.TabIndex = 7;
            this.paymentLabel.Text = "Payment type ";
            // 
            // emailCheckBox
            // 
            this.emailCheckBox.AutoSize = true;
            this.emailCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailCheckBox.Location = new System.Drawing.Point(253, 705);
            this.emailCheckBox.Name = "emailCheckBox";
            this.emailCheckBox.Size = new System.Drawing.Size(196, 22);
            this.emailCheckBox.TabIndex = 8;
            this.emailCheckBox.Text = "Email Receipt Requested";
            this.emailCheckBox.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(783, 30);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.ToolTipText = "This will display entire form content into a popup messagebox and will save entir" +
    "e content into a external file.";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.clearToolStripMenuItem.Text = "&Clear";
            this.clearToolStripMenuItem.ToolTipText = "This will clear the whole form.";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.ToolTipText = "This will exit you out of the form.";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.ToolTipText = "Details about this project.";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // dateMaskedTextBox
            // 
            this.dateMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateMaskedTextBox.Location = new System.Drawing.Point(244, 188);
            this.dateMaskedTextBox.Mask = "00/00/0000";
            this.dateMaskedTextBox.Name = "dateMaskedTextBox";
            this.dateMaskedTextBox.Size = new System.Drawing.Size(100, 24);
            this.dateMaskedTextBox.TabIndex = 10;
            this.dateMaskedTextBox.ValidatingType = typeof(System.DateTime);
            this.dateMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.dateMaskedTextBox_MaskInputRejected);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(57, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 136);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 742);
            this.Controls.Add(this.dateMaskedTextBox);
            this.Controls.Add(this.emailCheckBox);
            this.Controls.Add(this.paymentLabel);
            this.Controls.Add(this.checkRadioButton);
            this.Controls.Add(this.cashRadioButton);
            this.Controls.Add(this.registrationInfoGroupBox);
            this.Controls.Add(this.registrantInfoGroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hopkins Film School";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.registrantInfoGroupBox.ResumeLayout(false);
            this.registrantInfoGroupBox.PerformLayout();
            this.registrationInfoGroupBox.ResumeLayout(false);
            this.registrationInfoGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox registrantInfoGroupBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.MaskedTextBox dobMaskedTextBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.GroupBox registrationInfoGroupBox;
        private System.Windows.Forms.RadioButton animationRadioButton;
        private System.Windows.Forms.RadioButton liveActionRadioButton;
        private System.Windows.Forms.Label liveActionPricelabel;
        private System.Windows.Forms.Label animationPriceLabel;
        private System.Windows.Forms.ListBox classesListBox;
        private System.Windows.Forms.Label maxRegistrationLabel;
        private System.Windows.Forms.Label numberClassesLabel;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Label pricePerClassLabel;
        private System.Windows.Forms.RadioButton cashRadioButton;
        private System.Windows.Forms.RadioButton checkRadioButton;
        private System.Windows.Forms.Label paymentLabel;
        private System.Windows.Forms.CheckBox emailCheckBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTipSave;
        private System.Windows.Forms.ToolTip toolTipClear;
        private System.Windows.Forms.ToolTip toolTipExit;
        private System.Windows.Forms.ToolTip toolTipAbout;
        private System.Windows.Forms.MaskedTextBox dateMaskedTextBox;
    }
}

