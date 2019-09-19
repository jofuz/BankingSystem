using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bank_dbDataSet.tblBank' table. You can move, or remove it, as needed.
            this.tblBankTableAdapter.Fill(this.bank_dbDataSet.tblBank);

        }

        private void firstButton_Click(object sender, EventArgs e)
        {
            tblBankBindingSource.MoveFirst();
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            tblBankBindingSource.MovePrevious();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            tblBankBindingSource.MoveNext();

        }

        private void lastButton_Click(object sender, EventArgs e)
        {
            tblBankBindingSource.MoveLast();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.tblBankBindingSource.EndEdit();
                this.tblBankTableAdapter.Update(this.bank_dbDataSet.tblBank);
                MessageBox.Show("Update successful");
            }
            catch (System.Exception)
            {
                MessageBox.Show("Update failed");
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            tblBankBindingSource.AddNew();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            this.tblBankBindingSource.RemoveCurrent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchForm SearchForm = new SearchForm();
            SearchForm.Show();
        }

    }
}
