namespace CarSystem.FormApp

{
    using CarSystem.FormApp;
    using CarSystem.Services;
    public partial class Form1 : Form
    {

        public CarService service = new CarService();


        private void RefreshManufacturers()
        {           
            dgvManufacturers.DataSource = service.GetAll()
                .Select(m => new { m.Id, m.Name, m.Country }).ToList();
        }


        public Form1()
        {
            InitializeComponent();
            RefreshManufacturers();
        }

        // Помощен метод за изчистване на полетата
        private void ClearInputs()
        {
            txtName.Clear();
            txtCountry.Clear();
            txtModelName.Clear();
            txtYear.Clear();
        }

        private void btnUpdateManufacturer_Click(object sender, EventArgs e)
        {
            if (dgvManufacturers.SelectedRows.Count > 0)
            {
                // Вземаме ID-то на избрания производител
                int id = (int)dgvManufacturers.SelectedRows[0].Cells["Id"].Value;                
                service.UpdateManufacturer(id, txtName.Text);

                MessageBox.Show("Manufacturer updated!");
                RefreshManufacturers();
                ClearInputs();
            }
        }

        // Когато изберем производител, показваме неговите модели в долната таблица
        private void dgvManufacturers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Провека дали е кликнато на валиден ред (а не на заглавието)
            if (e.RowIndex >= 0)
            {
                //Вземаме ID-то от първата колона на избрания ред
                int manufacturerId = (int)dgvManufacturers.Rows[e.RowIndex].Cells["Id"].Value;            
                var manufacturer = service.GetAll().FirstOrDefault(m => m.Id == manufacturerId);               
                if (manufacturer != null)
                {
                    dgvModels.DataSource = manufacturer.Models
                        .Select(mo => new { mo.Id, mo.Name, mo.Year })
                        .ToList();
                }
            }
        }



        private void btnAddManufacturer_Click(object sender, EventArgs e)
        {
            service.CreateManufacturer(txtName.Text, txtCountry.Text);
            RefreshManufacturers();
            txtName.Text = string.Empty;
            txtCountry.Text = string.Empty;
        }

        private void btnAddModel_Click(object sender, EventArgs e)
        {
            if (dgvManufacturers.SelectedRows.Count > 0)
            {
                int mId = (int)dgvManufacturers.SelectedRows[0].Cells["Id"].Value;
                service.AddModel(mId, txtModelName.Text, int.Parse(txtYear.Text));
                RefreshManufacturers(); 
                MessageBox.Show("Model added!");
            }
            txtModelName.Text = "";
            txtYear.Text = string.Empty;
        }

        private void btnDeleteManufacturer_Click(object sender, EventArgs e)
        {
            if (dgvManufacturers.SelectedRows.Count > 0)
            {
                int id = (int)dgvManufacturers.SelectedRows[0].Cells["Id"].Value;
                service.DeleteManufacturer(id);
                RefreshManufacturers();
                dgvModels.DataSource = null;
            }
        }


        // UPDATE Model
        private void btnUpdateModel_Click(object sender, EventArgs e)
        {
            if (dgvModels.SelectedRows.Count > 0)
            {
                //Вземаме ID-то на избрания модел от долната таблица
                int modelId = (int)dgvModels.SelectedRows[0].Cells["Id"].Value;              
                service.UpdateModel(modelId, txtModelName.Text, int.Parse(txtYear.Text));

                MessageBox.Show("Model updated successfully!");

                //Опресняваме дисплея, като "излъжем" горната таблица, че е кликната пак
                dgvManufacturers_CellClick(null, new DataGridViewCellEventArgs(0, dgvManufacturers.CurrentRow.Index));
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Please select a model from the list first!");
            }
        }

        // DELETE Model
        private void btnDeleteModel_Click(object sender, EventArgs e)
        {
            if (dgvModels.SelectedRows.Count > 0)
            {
                //Вземаме ID-то на модела
                int id = (int)dgvModels.SelectedRows[0].Cells["Id"].Value;                
                service.DeleteModel(id);
                MessageBox.Show("Model deleted!");               
                dgvManufacturers_CellClick(null, new DataGridViewCellEventArgs(0, dgvManufacturers.CurrentRow.Index));
            }
            else
            {
                MessageBox.Show("Please select a model to delete!");
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
