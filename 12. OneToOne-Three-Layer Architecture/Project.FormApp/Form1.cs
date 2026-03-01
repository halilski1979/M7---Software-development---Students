using Project.Services;

namespace Project.FormApp
{
    public partial class Form1 : Form
    {

        // Инициализираме услугата
        private readonly EmployeeService service = new EmployeeService();


        public Form1()
        {
            InitializeComponent();
            RefreshGrid(); // Зареждаме данните при стартиране
        }

        // Помощен метод за опресняване на таблицата
        private void RefreshGrid()
        {
            var employees = service.GetAll();

            // Форматираме данните за таблицата, за да виждаме и картата
            dgvEmployees.DataSource = employees.Select(e => new {
                e.Id,
                e.FirstName,
                e.LastName,
                CardNumber = e.Card?.CardNumber ?? "No Card"
            }).ToList();
        }

        // CREATE
        private void btnCreate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
            service.Create(txtFirstName.Text, txtLastName.Text, txtCardNumber.Text);
            RefreshGrid();
            ClearInputs();
        }

        // UPDATE (Редактира избрания ред в таблицата)
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
            if (dgvEmployees.SelectedRows.Count > 0)
            {
                int id = (int)dgvEmployees.SelectedRows[0].Cells["Id"].Value;
                service.Update(id, txtFirstName.Text, txtLastName.Text, txtCardNumber.Text);
                RefreshGrid();
                ClearInputs();
            }
        }

        // DELETE
        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
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

        private void ClearInputs()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtCardNumber.Clear();
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

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
