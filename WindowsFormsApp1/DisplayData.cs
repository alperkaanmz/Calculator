using Business;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System;

namespace CalculatorForms
{
    public partial class secondForm : Form
    {
        private OperationManager operationManager;

        public secondForm(OperationManager operationManager)
        {
            InitializeComponent();
            this.operationManager = operationManager;
        }

        private void secondForm_Load(object sender, EventArgs e)
        {

            DataTable dataTable = operationManager.LoadHistory(); // Business katmanındaki LoadHistory metodu ile verileri alıyoruz
            dataGridViewHistory.DataSource = dataTable;
            dataGridViewHistory.DefaultCellStyle.Font = new Font("Arial", 10);
            dataGridViewHistory.DefaultCellStyle.ForeColor = Color.White;
            dataGridViewHistory.DefaultCellStyle.BackColor = Color.Gray;
        }

        public void LoadHistory_Click()
        {
            // Business katmanındaki LoadHistory metodu ile verileri alıyoruz.
            DataTable dataTable = operationManager.LoadHistory();
            dataGridViewHistory.DataSource = dataTable;

        }

        private void clearHistory_Click(object sender, EventArgs e)
        {
            operationManager.ClearHistory();
            LoadHistory_Click();

        }

        private void deleteLastEntry_Click(object sender, EventArgs e)
        {
            operationManager.DeleteLastEntry();
            LoadHistory_Click();

        }
    }
}
