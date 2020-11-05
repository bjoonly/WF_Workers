namespace ItemsControls
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.WorkersListBox = new System.Windows.Forms.ListBox();
            this.PositionComboBox = new System.Windows.Forms.ComboBox();
            this.CityComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddressComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.HouseTextBox = new System.Windows.Forms.TextBox();
            this.SalaryNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NewPositionButton = new System.Windows.Forms.Button();
            this.NewCItyButton = new System.Windows.Forms.Button();
            this.NewAddressButton = new System.Windows.Forms.Button();
            this.AddWorkerButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.deleteWorkerButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // WorkersListBox
            // 
            this.WorkersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WorkersListBox.FormattingEnabled = true;
            this.WorkersListBox.Location = new System.Drawing.Point(344, 26);
            this.WorkersListBox.Name = "WorkersListBox";
            this.WorkersListBox.Size = new System.Drawing.Size(288, 199);
            this.WorkersListBox.TabIndex = 0;
            this.WorkersListBox.SelectedIndexChanged += new System.EventHandler(this.WorkersListBox_SelectedIndexChanged);
            // 
            // PositionComboBox
            // 
            this.PositionComboBox.FormattingEnabled = true;
            this.PositionComboBox.Location = new System.Drawing.Point(86, 155);
            this.PositionComboBox.Name = "PositionComboBox";
            this.PositionComboBox.Size = new System.Drawing.Size(120, 21);
            this.PositionComboBox.TabIndex = 1;
            // 
            // CityComboBox
            // 
            this.CityComboBox.FormattingEnabled = true;
            this.CityComboBox.Location = new System.Drawing.Point(86, 198);
            this.CityComboBox.Name = "CityComboBox";
            this.CityComboBox.Size = new System.Drawing.Size(120, 21);
            this.CityComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Position";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "City";
            // 
            // AddressComboBox
            // 
            this.AddressComboBox.FormattingEnabled = true;
            this.AddressComboBox.Location = new System.Drawing.Point(86, 241);
            this.AddressComboBox.Name = "AddressComboBox";
            this.AddressComboBox.Size = new System.Drawing.Size(120, 21);
            this.AddressComboBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Address";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(86, 26);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(155, 20);
            this.FirstNameTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "First name:";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(86, 69);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(155, 20);
            this.LastNameTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Last name:";
            // 
            // HouseTextBox
            // 
            this.HouseTextBox.Location = new System.Drawing.Point(86, 284);
            this.HouseTextBox.Name = "HouseTextBox";
            this.HouseTextBox.Size = new System.Drawing.Size(155, 20);
            this.HouseTextBox.TabIndex = 11;
            // 
            // SalaryNumericUpDown
            // 
            this.SalaryNumericUpDown.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.SalaryNumericUpDown.Location = new System.Drawing.Point(86, 112);
            this.SalaryNumericUpDown.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.SalaryNumericUpDown.Name = "SalaryNumericUpDown";
            this.SalaryNumericUpDown.Size = new System.Drawing.Size(155, 20);
            this.SalaryNumericUpDown.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "House";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Salary";
            // 
            // NewPositionButton
            // 
            this.NewPositionButton.Location = new System.Drawing.Point(212, 155);
            this.NewPositionButton.Name = "NewPositionButton";
            this.NewPositionButton.Size = new System.Drawing.Size(29, 23);
            this.NewPositionButton.TabIndex = 17;
            this.NewPositionButton.Text = "+";
            this.NewPositionButton.UseVisualStyleBackColor = true;
            this.NewPositionButton.Click += new System.EventHandler(this.NewPositionButton_Click);
            // 
            // NewCItyButton
            // 
            this.NewCItyButton.Location = new System.Drawing.Point(212, 195);
            this.NewCItyButton.Name = "NewCItyButton";
            this.NewCItyButton.Size = new System.Drawing.Size(29, 23);
            this.NewCItyButton.TabIndex = 20;
            this.NewCItyButton.Text = "+";
            this.NewCItyButton.UseVisualStyleBackColor = true;
            this.NewCItyButton.Click += new System.EventHandler(this.NewCItyButton_Click);
            // 
            // NewAddressButton
            // 
            this.NewAddressButton.Location = new System.Drawing.Point(212, 239);
            this.NewAddressButton.Name = "NewAddressButton";
            this.NewAddressButton.Size = new System.Drawing.Size(31, 23);
            this.NewAddressButton.TabIndex = 23;
            this.NewAddressButton.Text = "+";
            this.NewAddressButton.UseVisualStyleBackColor = true;
            this.NewAddressButton.Click += new System.EventHandler(this.NewAddressButton_Click);
            // 
            // AddWorkerButton
            // 
            this.AddWorkerButton.Location = new System.Drawing.Point(344, 234);
            this.AddWorkerButton.Name = "AddWorkerButton";
            this.AddWorkerButton.Size = new System.Drawing.Size(60, 32);
            this.AddWorkerButton.TabIndex = 25;
            this.AddWorkerButton.Text = "Add";
            this.AddWorkerButton.UseVisualStyleBackColor = true;
            this.AddWorkerButton.Click += new System.EventHandler(this.AddWorkerButton1_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(501, 272);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(131, 32);
            this.SaveButton.TabIndex = 26;
            this.SaveButton.Text = "Save workers";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(344, 272);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(131, 32);
            this.LoadButton.TabIndex = 27;
            this.LoadButton.Text = "Load workers";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // deleteWorkerButton
            // 
            this.deleteWorkerButton.Location = new System.Drawing.Point(415, 234);
            this.deleteWorkerButton.Name = "deleteWorkerButton";
            this.deleteWorkerButton.Size = new System.Drawing.Size(60, 32);
            this.deleteWorkerButton.TabIndex = 28;
            this.deleteWorkerButton.Text = "Delete";
            this.deleteWorkerButton.UseVisualStyleBackColor = true;
            this.deleteWorkerButton.Click += new System.EventHandler(this.deleteWorkerButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(501, 234);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(60, 32);
            this.editButton.TabIndex = 29;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(572, 234);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(60, 32);
            this.clearButton.TabIndex = 30;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 327);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteWorkerButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AddWorkerButton);
            this.Controls.Add(this.NewAddressButton);
            this.Controls.Add(this.NewCItyButton);
            this.Controls.Add(this.NewPositionButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SalaryNumericUpDown);
            this.Controls.Add(this.HouseTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddressComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CityComboBox);
            this.Controls.Add(this.PositionComboBox);
            this.Controls.Add(this.WorkersListBox);
            this.Name = "Form1";
            this.Text = "Workers";
            ((System.ComponentModel.ISupportInitialize)(this.SalaryNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox WorkersListBox;
        private System.Windows.Forms.ComboBox PositionComboBox;
        private System.Windows.Forms.ComboBox CityComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox AddressComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox HouseTextBox;
        private System.Windows.Forms.NumericUpDown SalaryNumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button NewPositionButton;
        private System.Windows.Forms.Button NewCItyButton;
        private System.Windows.Forms.Button NewAddressButton;
        private System.Windows.Forms.Button AddWorkerButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button deleteWorkerButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button clearButton;
    }
}

