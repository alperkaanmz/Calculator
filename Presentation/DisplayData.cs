using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp.Presentation
{
    public partial class secondForm : Form
    {
        private DatabaseManager dbManager;

        public secondForm()
        {
            InitializeComponent();
            // Database Connection
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" +
                "C:\\Users\\31766\\source\\repos\\Calculator\\CalculatorApp\\CalculatorDatabase.mdf;Integrated Security=True";
            dbManager = new DatabaseManager(connectionString);
        }

        private void secondForm_Load(object sender, EventArgs e)
        {
            LoadHistory();
            dataGridViewHistory.DefaultCellStyle.Font = new Font("Arial", 10);
            dataGridViewHistory.DefaultCellStyle.ForeColor = Color.White;
            dataGridViewHistory.DefaultCellStyle.BackColor = Color.Gray;
        }

        public void LoadHistory()
        {
            try
            {
                DataTable dataTable = dbManager.GetHistoryData();
                dataGridViewHistory.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearHistory_Click(object sender, EventArgs e)
        {
            try
            {
                dbManager.ClearHistory();
                // Tüm verileri temizledikten sonra DataGridView gğncellenir.
                LoadHistory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteLastEntry_Click(object sender, EventArgs e)
        {
            try
            {
                dbManager.DeleteLastEntry();
                // Son eklenen veriyi sildikten sonra DataGridView'i günceller.
                LoadHistory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}