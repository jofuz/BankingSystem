namespace BankingSystem
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label accountCodeLabel;
            System.Windows.Forms.Label customerNameLabel;
            System.Windows.Forms.Label dateOpenedLabel;
            System.Windows.Forms.Label balanceLabel;
            System.Windows.Forms.Label onlineBankingLabel;
            System.Windows.Forms.Label bICLabel;
            System.Windows.Forms.Label iBANLabel;
            System.Windows.Forms.Label accountTypeLabel;
            this.tblBankBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bank_dbDataSet = new BankingSystem.bank_dbDataSet();
            this.accountCodeTextBox = new System.Windows.Forms.TextBox();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.dateOpenedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.onlineBankingCheckBox = new System.Windows.Forms.CheckBox();
            this.bICTextBox = new System.Windows.Forms.TextBox();
            this.iBANTextBox = new System.Windows.Forms.TextBox();
            this.accountTypeTextBox = new System.Windows.Forms.TextBox();
            this.firstButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.lastButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.tblBankTableAdapter = new BankingSystem.bank_dbDataSetTableAdapters.tblBankTableAdapter();
            this.tableAdapterManager = new BankingSystem.bank_dbDataSetTableAdapters.TableAdapterManager();
            this.exitButton = new System.Windows.Forms.Button();
            accountCodeLabel = new System.Windows.Forms.Label();
            customerNameLabel = new System.Windows.Forms.Label();
            dateOpenedLabel = new System.Windows.Forms.Label();
            balanceLabel = new System.Windows.Forms.Label();
            onlineBankingLabel = new System.Windows.Forms.Label();
            bICLabel = new System.Windows.Forms.Label();
            iBANLabel = new System.Windows.Forms.Label();
            accountTypeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblBankBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // accountCodeLabel
            // 
            accountCodeLabel.AutoSize = true;
            accountCodeLabel.Location = new System.Drawing.Point(21, 117);
            accountCodeLabel.Name = "accountCodeLabel";
            accountCodeLabel.Size = new System.Drawing.Size(82, 13);
            accountCodeLabel.TabIndex = 1;
            accountCodeLabel.Text = "Account Code:";
            // 
            // customerNameLabel
            // 
            customerNameLabel.AutoSize = true;
            customerNameLabel.Location = new System.Drawing.Point(21, 143);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new System.Drawing.Size(91, 13);
            customerNameLabel.TabIndex = 3;
            customerNameLabel.Text = "Customer Name:";
            // 
            // dateOpenedLabel
            // 
            dateOpenedLabel.AutoSize = true;
            dateOpenedLabel.Location = new System.Drawing.Point(21, 170);
            dateOpenedLabel.Name = "dateOpenedLabel";
            dateOpenedLabel.Size = new System.Drawing.Size(79, 13);
            dateOpenedLabel.TabIndex = 5;
            dateOpenedLabel.Text = "Date Opened:";
            // 
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.Location = new System.Drawing.Point(21, 195);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new System.Drawing.Size(50, 13);
            balanceLabel.TabIndex = 7;
            balanceLabel.Text = "Balance:";
            // 
            // onlineBankingLabel
            // 
            onlineBankingLabel.AutoSize = true;
            onlineBankingLabel.Location = new System.Drawing.Point(21, 224);
            onlineBankingLabel.Name = "onlineBankingLabel";
            onlineBankingLabel.Size = new System.Drawing.Size(91, 13);
            onlineBankingLabel.TabIndex = 9;
            onlineBankingLabel.Text = "Online Banking:";
            // 
            // bICLabel
            // 
            bICLabel.AutoSize = true;
            bICLabel.Location = new System.Drawing.Point(21, 250);
            bICLabel.Name = "bICLabel";
            bICLabel.Size = new System.Drawing.Size(27, 13);
            bICLabel.TabIndex = 11;
            bICLabel.Text = "BIC:";
            // 
            // iBANLabel
            // 
            iBANLabel.AutoSize = true;
            iBANLabel.Location = new System.Drawing.Point(21, 276);
            iBANLabel.Name = "iBANLabel";
            iBANLabel.Size = new System.Drawing.Size(35, 13);
            iBANLabel.TabIndex = 13;
            iBANLabel.Text = "IBAN:";
            // 
            // accountTypeLabel
            // 
            accountTypeLabel.AutoSize = true;
            accountTypeLabel.Location = new System.Drawing.Point(21, 302);
            accountTypeLabel.Name = "accountTypeLabel";
            accountTypeLabel.Size = new System.Drawing.Size(78, 13);
            accountTypeLabel.TabIndex = 15;
            accountTypeLabel.Text = "Account Type:";
            // 
            // tblBankBindingSource
            // 
            this.tblBankBindingSource.DataMember = "tblBank";
            this.tblBankBindingSource.DataSource = this.bank_dbDataSet;
            // 
            // bank_dbDataSet
            // 
            this.bank_dbDataSet.DataSetName = "bank_dbDataSet";
            this.bank_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountCodeTextBox
            // 
            this.accountCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblBankBindingSource, "AccountCode", true));
            this.accountCodeTextBox.Location = new System.Drawing.Point(113, 113);
            this.accountCodeTextBox.Name = "accountCodeTextBox";
            this.accountCodeTextBox.Size = new System.Drawing.Size(199, 22);
            this.accountCodeTextBox.TabIndex = 2;
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblBankBindingSource, "CustomerName", true));
            this.customerNameTextBox.Location = new System.Drawing.Point(113, 139);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(199, 22);
            this.customerNameTextBox.TabIndex = 4;
            // 
            // dateOpenedDateTimePicker
            // 
            this.dateOpenedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblBankBindingSource, "DateOpened", true));
            this.dateOpenedDateTimePicker.Location = new System.Drawing.Point(113, 165);
            this.dateOpenedDateTimePicker.Name = "dateOpenedDateTimePicker";
            this.dateOpenedDateTimePicker.Size = new System.Drawing.Size(199, 22);
            this.dateOpenedDateTimePicker.TabIndex = 6;
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblBankBindingSource, "Balance", true));
            this.balanceTextBox.Location = new System.Drawing.Point(113, 191);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.Size = new System.Drawing.Size(199, 22);
            this.balanceTextBox.TabIndex = 8;
            // 
            // onlineBankingCheckBox
            // 
            this.onlineBankingCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tblBankBindingSource, "OnlineBanking", true));
            this.onlineBankingCheckBox.Location = new System.Drawing.Point(113, 222);
            this.onlineBankingCheckBox.Name = "onlineBankingCheckBox";
            this.onlineBankingCheckBox.Size = new System.Drawing.Size(201, 18);
            this.onlineBankingCheckBox.TabIndex = 10;
            this.onlineBankingCheckBox.UseVisualStyleBackColor = true;
            // 
            // bICTextBox
            // 
            this.bICTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblBankBindingSource, "BIC", true));
            this.bICTextBox.Location = new System.Drawing.Point(113, 248);
            this.bICTextBox.Name = "bICTextBox";
            this.bICTextBox.Size = new System.Drawing.Size(199, 22);
            this.bICTextBox.TabIndex = 12;
            // 
            // iBANTextBox
            // 
            this.iBANTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblBankBindingSource, "IBAN", true));
            this.iBANTextBox.Location = new System.Drawing.Point(113, 274);
            this.iBANTextBox.Name = "iBANTextBox";
            this.iBANTextBox.Size = new System.Drawing.Size(199, 22);
            this.iBANTextBox.TabIndex = 14;
            // 
            // accountTypeTextBox
            // 
            this.accountTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblBankBindingSource, "AccountType", true));
            this.accountTypeTextBox.Location = new System.Drawing.Point(113, 300);
            this.accountTypeTextBox.Name = "accountTypeTextBox";
            this.accountTypeTextBox.Size = new System.Drawing.Size(199, 22);
            this.accountTypeTextBox.TabIndex = 16;
            // 
            // firstButton
            // 
            this.firstButton.Location = new System.Drawing.Point(383, 113);
            this.firstButton.Name = "firstButton";
            this.firstButton.Size = new System.Drawing.Size(75, 23);
            this.firstButton.TabIndex = 17;
            this.firstButton.Text = "<< First";
            this.firstButton.UseVisualStyleBackColor = true;
            this.firstButton.Click += new System.EventHandler(this.firstButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(383, 149);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(75, 23);
            this.previousButton.TabIndex = 18;
            this.previousButton.Text = "< Previous";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(480, 149);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 19;
            this.nextButton.Text = "Next >";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // lastButton
            // 
            this.lastButton.Location = new System.Drawing.Point(480, 113);
            this.lastButton.Name = "lastButton";
            this.lastButton.Size = new System.Drawing.Size(75, 23);
            this.lastButton.TabIndex = 20;
            this.lastButton.Text = "Last >>";
            this.lastButton.UseVisualStyleBackColor = true;
            this.lastButton.Click += new System.EventHandler(this.lastButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(373, 299);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 22;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(480, 299);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 23;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(24, 371);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 24;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(25, 50);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 25;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // tblBankTableAdapter
            // 
            this.tblBankTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblBankTableAdapter = this.tblBankTableAdapter;
            this.tableAdapterManager.UpdateOrder = BankingSystem.bank_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(480, 371);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 26;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 406);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.lastButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.firstButton);
            this.Controls.Add(accountCodeLabel);
            this.Controls.Add(this.accountCodeTextBox);
            this.Controls.Add(customerNameLabel);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(dateOpenedLabel);
            this.Controls.Add(this.dateOpenedDateTimePicker);
            this.Controls.Add(balanceLabel);
            this.Controls.Add(this.balanceTextBox);
            this.Controls.Add(onlineBankingLabel);
            this.Controls.Add(this.onlineBankingCheckBox);
            this.Controls.Add(bICLabel);
            this.Controls.Add(this.bICTextBox);
            this.Controls.Add(iBANLabel);
            this.Controls.Add(this.iBANTextBox);
            this.Controls.Add(accountTypeLabel);
            this.Controls.Add(this.accountTypeTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.Name = "Form1";
            this.Text = "Banking System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblBankBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_dbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bank_dbDataSet bank_dbDataSet;
        private System.Windows.Forms.BindingSource tblBankBindingSource;
        private bank_dbDataSetTableAdapters.tblBankTableAdapter tblBankTableAdapter;
        private bank_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox accountCodeTextBox;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.DateTimePicker dateOpenedDateTimePicker;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.CheckBox onlineBankingCheckBox;
        private System.Windows.Forms.TextBox bICTextBox;
        private System.Windows.Forms.TextBox iBANTextBox;
        private System.Windows.Forms.TextBox accountTypeTextBox;
        private System.Windows.Forms.Button firstButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button lastButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button exitButton;
    }
}

