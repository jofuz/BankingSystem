namespace BankingSystem
{
    partial class SearchForm
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
            this.bank_dbDataSet = new BankingSystem.bank_dbDataSet();
            this.tblBankTableAdapter = new BankingSystem.bank_dbDataSetTableAdapters.tblBankTableAdapter();
            this.tblBankDataGridView = new System.Windows.Forms.DataGridView();
            this.accountCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOpenedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onlineBankingDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bICDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iBANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblBankBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tblBankBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblBankBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cboField = new System.Windows.Forms.ComboBox();
            this.tblBankBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.cboOperator = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tableAdapterManager = new BankingSystem.bank_dbDataSetTableAdapters.TableAdapterManager();
            this.testConnection = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bank_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBankDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBankBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBankBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBankBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBankBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // bank_dbDataSet
            // 
            this.bank_dbDataSet.DataSetName = "bank_dbDataSet";
            this.bank_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblBankTableAdapter
            // 
            this.tblBankTableAdapter.ClearBeforeFill = true;
            // 
            // tblBankDataGridView
            // 
            this.tblBankDataGridView.AllowUserToAddRows = false;
            this.tblBankDataGridView.AllowUserToDeleteRows = false;
            this.tblBankDataGridView.AutoGenerateColumns = false;
            this.tblBankDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblBankDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountCodeDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.dateOpenedDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn,
            this.onlineBankingDataGridViewCheckBoxColumn,
            this.bICDataGridViewTextBoxColumn,
            this.iBANDataGridViewTextBoxColumn,
            this.accountTypeDataGridViewTextBoxColumn});
            this.tblBankDataGridView.DataSource = this.tblBankBindingSource2;
            this.tblBankDataGridView.Location = new System.Drawing.Point(-1, 104);
            this.tblBankDataGridView.Name = "tblBankDataGridView";
            this.tblBankDataGridView.ReadOnly = true;
            this.tblBankDataGridView.Size = new System.Drawing.Size(843, 154);
            this.tblBankDataGridView.TabIndex = 1;
            // 
            // accountCodeDataGridViewTextBoxColumn
            // 
            this.accountCodeDataGridViewTextBoxColumn.DataPropertyName = "AccountCode";
            this.accountCodeDataGridViewTextBoxColumn.HeaderText = "AccountCode";
            this.accountCodeDataGridViewTextBoxColumn.Name = "accountCodeDataGridViewTextBoxColumn";
            this.accountCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOpenedDataGridViewTextBoxColumn
            // 
            this.dateOpenedDataGridViewTextBoxColumn.DataPropertyName = "DateOpened";
            this.dateOpenedDataGridViewTextBoxColumn.HeaderText = "DateOpened";
            this.dateOpenedDataGridViewTextBoxColumn.Name = "dateOpenedDataGridViewTextBoxColumn";
            this.dateOpenedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            this.balanceDataGridViewTextBoxColumn.HeaderText = "Balance";
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            this.balanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // onlineBankingDataGridViewCheckBoxColumn
            // 
            this.onlineBankingDataGridViewCheckBoxColumn.DataPropertyName = "OnlineBanking";
            this.onlineBankingDataGridViewCheckBoxColumn.HeaderText = "OnlineBanking";
            this.onlineBankingDataGridViewCheckBoxColumn.Name = "onlineBankingDataGridViewCheckBoxColumn";
            this.onlineBankingDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // bICDataGridViewTextBoxColumn
            // 
            this.bICDataGridViewTextBoxColumn.DataPropertyName = "BIC";
            this.bICDataGridViewTextBoxColumn.HeaderText = "BIC";
            this.bICDataGridViewTextBoxColumn.Name = "bICDataGridViewTextBoxColumn";
            this.bICDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iBANDataGridViewTextBoxColumn
            // 
            this.iBANDataGridViewTextBoxColumn.DataPropertyName = "IBAN";
            this.iBANDataGridViewTextBoxColumn.HeaderText = "IBAN";
            this.iBANDataGridViewTextBoxColumn.Name = "iBANDataGridViewTextBoxColumn";
            this.iBANDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountTypeDataGridViewTextBoxColumn
            // 
            this.accountTypeDataGridViewTextBoxColumn.DataPropertyName = "AccountType";
            this.accountTypeDataGridViewTextBoxColumn.HeaderText = "AccountType";
            this.accountTypeDataGridViewTextBoxColumn.Name = "accountTypeDataGridViewTextBoxColumn";
            this.accountTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblBankBindingSource2
            // 
            this.tblBankBindingSource2.DataMember = "tblBank";
            this.tblBankBindingSource2.DataSource = this.tblBankBindingSource;
            // 
            // tblBankBindingSource
            // 
            this.tblBankBindingSource.DataSource = this.bank_dbDataSet;
            this.tblBankBindingSource.Position = 0;
            // 
            // tblBankBindingSource1
            // 
            this.tblBankBindingSource1.DataMember = "tblBank";
            this.tblBankBindingSource1.DataSource = this.tblBankBindingSource;
            // 
            // cboField
            // 
            this.cboField.FormattingEnabled = true;
            this.cboField.Items.AddRange(new object[] {
            "Balance",
            "OnlineBanking",
            "AccountType"});
            this.cboField.Location = new System.Drawing.Point(8, 46);
            this.cboField.Name = "cboField";
            this.cboField.Size = new System.Drawing.Size(121, 21);
            this.cboField.TabIndex = 2;
            // 
            // tblBankBindingSource3
            // 
            this.tblBankBindingSource3.DataMember = "tblBank";
            this.tblBankBindingSource3.DataSource = this.tblBankBindingSource;
            // 
            // cboOperator
            // 
            this.cboOperator.FormattingEnabled = true;
            this.cboOperator.Items.AddRange(new object[] {
            "=",
            "<",
            ">",
            "<=",
            ">="});
            this.cboOperator.Location = new System.Drawing.Point(154, 46);
            this.cboOperator.Name = "cboOperator";
            this.cboOperator.Size = new System.Drawing.Size(65, 21);
            this.cboOperator.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Field";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Operator";
            // 
            // deValue
            // 
            this.deValue.Location = new System.Drawing.Point(246, 46);
            this.deValue.Name = "deValue";
            this.deValue.Size = new System.Drawing.Size(100, 20);
            this.deValue.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Value";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(371, 46);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 8;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(754, 46);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.tblBankTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BankingSystem.bank_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // testConnection
            // 
            this.testConnection.BackColor = System.Drawing.Color.Red;
            this.testConnection.Location = new System.Drawing.Point(532, 46);
            this.testConnection.Name = "testConnection";
            this.testConnection.Size = new System.Drawing.Size(75, 23);
            this.testConnection.TabIndex = 10;
            this.testConnection.Text = "Test Connection";
            this.testConnection.UseVisualStyleBackColor = false;
            this.testConnection.Click += new System.EventHandler(this.testConnection_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 254);
            this.Controls.Add(this.testConnection);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboOperator);
            this.Controls.Add(this.cboField);
            this.Controls.Add(this.tblBankDataGridView);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bank_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBankDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBankBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBankBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBankBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBankBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bank_dbDataSet bank_dbDataSet;
        private System.Windows.Forms.BindingSource tblBankBindingSource;
        private bank_dbDataSetTableAdapters.tblBankTableAdapter tblBankTableAdapter;
        private bank_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource tblBankBindingSource1;
        private System.Windows.Forms.DataGridView tblBankDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOpenedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn onlineBankingDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bICDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iBANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblBankBindingSource2;
        private System.Windows.Forms.ComboBox cboField;
        private System.Windows.Forms.BindingSource tblBankBindingSource3;
        private System.Windows.Forms.ComboBox cboOperator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox deValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button testConnection;
    }
}