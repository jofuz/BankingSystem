using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BankingSystem
{
    public partial class SearchForm : Form
    {
        OleDbConnection connection;

        string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=bank_db.mdb;";
        

        public SearchForm()
        {
            InitializeComponent();
        }

        private void tblBankBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblBankBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bank_dbDataSet);

        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bank_dbDataSet.tblBank' table. You can move, or remove it, as needed.
            this.tblBankTableAdapter.Fill(this.bank_dbDataSet.tblBank);
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string field = cboField.Text;
            string searchOp = cboOperator.Text;
            string searchVal = deValue.Text;
            string queryString;
            OleDbDataAdapter myAdapter;

            // check for blanks
            if (field != "" && searchOp != "" && searchVal != "")
            {
                switch (field) 
                {
                    case "Balance":
                        connection = new OleDbConnection(connectionString);
                        queryString = "SELECT * FROM tblBank WHERE " + field + searchOp + searchVal + ";";
                        myAdapter = new OleDbDataAdapter(queryString, connection);
                        break;
                    case "OnlineBanking":
                        connection = new OleDbConnection(connectionString);
                        switch (searchVal) 
                        { 
                            case "True":
                                queryString = "SELECT * FROM tblBank WHERE OnlineBanking ;";//+ field + searchOp + searchVal + ";"
                                myAdapter = new OleDbDataAdapter(queryString, connection);

                                break;
                            case "true":
                                queryString = "SELECT * FROM tblBank WHERE OnlineBanking ;";
                                myAdapter = new OleDbDataAdapter(queryString, connection);
                                break;
                            case "1":
                                queryString = "SELECT * FROM tblBank WHERE OnlineBanking ;";
                                myAdapter = new OleDbDataAdapter(queryString, connection);
                                break;
                            case "Yes":
                                queryString = "SELECT * FROM tblBank WHERE OnlineBanking ;";
                                myAdapter = new OleDbDataAdapter(queryString, connection);
                                break;
                            case "yes":
                                queryString = "SELECT * FROM tblBank WHERE OnlineBanking ;";
                                myAdapter = new OleDbDataAdapter(queryString, connection);
                                break;
                            case "False":
                                queryString = "SELECT * FROM tblBank WHERE not OnlineBanking ;";
                                myAdapter = new OleDbDataAdapter(queryString, connection);
                                break;
                            case "false":
                                queryString = "SELECT * FROM tblBank WHERE not OnlineBanking ;";
                                myAdapter = new OleDbDataAdapter(queryString, connection);
                                break;
                            case "0":
                                queryString = "SELECT * FROM tblBank WHERE not OnlineBanking ;";
                                myAdapter = new OleDbDataAdapter(queryString, connection);
                                break;
                            case "No":
                                queryString = "SELECT * FROM tblBank WHERE not OnlineBanking ;";
                                myAdapter = new OleDbDataAdapter(queryString, connection);
                                break;
                            case "no":
                                queryString = "SELECT * FROM tblBank WHERE not OnlineBanking ;";
                                myAdapter = new OleDbDataAdapter(queryString, connection);
                                break;
                            default :
                                queryString = "SELECT * FROM tblBank WHERE not OnlineBanking ;";
                                myAdapter = new OleDbDataAdapter(queryString, connection);
                                break;


                        }
                        break;
                    case "AccountType":
                        connection = new OleDbConnection(connectionString);
                        queryString = "SELECT * FROM tblBank WHERE AccountType LIKE '%" + searchVal + "%';";
                        myAdapter = new OleDbDataAdapter(queryString, connection);
                        break;
                    default:
                        connection = new OleDbConnection(connectionString);
                        queryString = "SELECT * FROM tblBank WHERE " + field + searchOp + searchVal + ";";
                        myAdapter = new OleDbDataAdapter(queryString, connection);
                        break;

                }


                DataTable dt = new DataTable();
                myAdapter.Fill(dt);
                tblBankDataGridView.DataSource = dt;
            }
            else 
            {
                MessageBox.Show("Fields cannot be blank");
            }
        }
        private void testConnection_Click(object sender, EventArgs e)
        {
            string testConnectionString;
            OleDbConnection cnn;
            testConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=bank_db.mdb; ";
            cnn = new OleDbConnection(testConnectionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open ! ");
                cnn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
 
    }
}
