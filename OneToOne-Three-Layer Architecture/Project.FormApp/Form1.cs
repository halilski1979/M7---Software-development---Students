using Project.Services;

namespace Project.FormApp
{
    public partial class Form1 : Form
    {

        public EmployeeService service = new EmployeeService();

        private void RefreshGrid()
        {
            var employees = service.GetAll();
            dgvEmployees.DataSource = employees.Select(x => new
            {
                x.Id,
                x.FirstName,
                x.LastName,
                txtCardNumber = x.Card.CardNumber
            }).ToList();
        }

        private void ClearInputs()
        {
            txtFirstName.Text = " ";
            txtLastName = null;
            txtCardNumber.Clear();
        }

        // CREATE
        private void btnCreate_Click(object sender, EventArgs e)
        {
            service.Create(txtFirstName.Text, txtLastName.Text, int.Parse(txtCardNumber.Text));
            RefreshGrid();
            ClearInputs();
        }



        // UPDATE 
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count > 0)
            {
                int id = (int)dgvEmployees.SelectedRows[0].Cells["Id"].Value;
                service.Update(id, txtFirstName.Text, txtLastName.Text, int.Parse(txtCardNumber.Text));
                RefreshGrid();
                ClearInputs();
            }
        }

        // DELETE
        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dgvEmployees.SelectedRows.Count > 0)
            {
                int id = (int)dgvEmployees.SelectedRows[0].Cells["Id"].Value;
                service.Delete(id);
                RefreshGrid();
            }
        }

        // REFRESH
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

       

        // Когато кликнете на ред, данните отиват в текстовите полета за лесна редакция
        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEmployees.Rows[e.RowIndex];
                txtFirstName.Text = row.Cells["FirstName"].Value.ToString();
                txtLastName.Text = row.Cells["LastName"].Value.ToString();
                txtCardNumber.Text = row.Cells["CardNumber"].Value.ToString();
            }
        }




        public Form1()
        {
            InitializeComponent();
            RefreshGrid();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {

        }
    }
}
