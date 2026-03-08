namespace CarSystem.FormApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvManufacturers = new DataGridView();
            dgvModels = new DataGridView();
            txtName = new TextBox();
            txtCountry = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtModelName = new TextBox();
            txtYear = new TextBox();
            btnAddManufacturer = new Button();
            btnAddModel = new Button();
            btnDeleteManufacturer = new Button();
            btnDeleteModel = new Button();
            btnUpdateManufacturer = new Button();
            btnUpdateModel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvManufacturers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvModels).BeginInit();
            SuspendLayout();
            // 
            // dgvManufacturers
            // 
            dgvManufacturers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvManufacturers.Location = new Point(648, 19);
            dgvManufacturers.Name = "dgvManufacturers";
            dgvManufacturers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvManufacturers.Size = new Size(332, 161);
            dgvManufacturers.TabIndex = 0;
            dgvManufacturers.CellClick += dgvManufacturers_CellClick;
            // 
            // dgvModels
            // 
            dgvModels.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvModels.Location = new Point(648, 218);
            dgvModels.Name = "dgvModels";
            dgvModels.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvModels.Size = new Size(332, 158);
            dgvModels.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(188, 31);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(157, 47);
            txtName.TabIndex = 2;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(188, 108);
            txtCountry.Multiline = true;
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(157, 47);
            txtCountry.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(32, 108);
            label1.Name = "label1";
            label1.Size = new Size(138, 32);
            label1.TabIndex = 4;
            label1.Text = "txtCountry";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.Location = new Point(58, 34);
            label2.Name = "label2";
            label2.Size = new Size(112, 32);
            label2.TabIndex = 5;
            label2.Text = "txtName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.Location = new Point(76, 291);
            label3.Name = "label3";
            label3.Size = new Size(94, 32);
            label3.TabIndex = 6;
            label3.Text = "txtYear";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label4.Location = new Point(-3, 231);
            label4.Name = "label4";
            label4.Size = new Size(185, 32);
            label4.TabIndex = 7;
            label4.Text = "txtModelName";
            // 
            // txtModelName
            // 
            txtModelName.Location = new Point(188, 231);
            txtModelName.Multiline = true;
            txtModelName.Name = "txtModelName";
            txtModelName.Size = new Size(152, 43);
            txtModelName.TabIndex = 8;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(188, 291);
            txtYear.Multiline = true;
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(149, 40);
            txtYear.TabIndex = 9;
            // 
            // btnAddManufacturer
            // 
            btnAddManufacturer.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnAddManufacturer.Location = new Point(401, 19);
            btnAddManufacturer.Name = "btnAddManufacturer";
            btnAddManufacturer.Size = new Size(227, 46);
            btnAddManufacturer.TabIndex = 10;
            btnAddManufacturer.Text = "btnAddManufacturer";
            btnAddManufacturer.UseVisualStyleBackColor = true;
            btnAddManufacturer.Click += btnAddManufacturer_Click;
            // 
            // btnAddModel
            // 
            btnAddModel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnAddModel.Location = new Point(403, 218);
            btnAddModel.Name = "btnAddModel";
            btnAddModel.Size = new Size(226, 42);
            btnAddModel.TabIndex = 11;
            btnAddModel.Text = "btnAddModel";
            btnAddModel.UseVisualStyleBackColor = true;
            btnAddModel.Click += btnAddModel_Click;
            // 
            // btnDeleteManufacturer
            // 
            btnDeleteManufacturer.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnDeleteManufacturer.Location = new Point(402, 77);
            btnDeleteManufacturer.Name = "btnDeleteManufacturer";
            btnDeleteManufacturer.Size = new Size(226, 42);
            btnDeleteManufacturer.TabIndex = 12;
            btnDeleteManufacturer.Text = "btnDeleteManufacturer";
            btnDeleteManufacturer.UseVisualStyleBackColor = true;
            btnDeleteManufacturer.Click += btnDeleteManufacturer_Click;
            // 
            // btnDeleteModel
            // 
            btnDeleteModel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnDeleteModel.Location = new Point(403, 277);
            btnDeleteModel.Name = "btnDeleteModel";
            btnDeleteModel.Size = new Size(227, 40);
            btnDeleteModel.TabIndex = 13;
            btnDeleteModel.Text = "btnDeleteModel";
            btnDeleteModel.UseVisualStyleBackColor = true;
            btnDeleteModel.Click += btnDeleteModel_Click;
            // 
            // btnUpdateManufacturer
            // 
            btnUpdateManufacturer.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnUpdateManufacturer.Location = new Point(401, 128);
            btnUpdateManufacturer.Name = "btnUpdateManufacturer";
            btnUpdateManufacturer.Size = new Size(227, 41);
            btnUpdateManufacturer.TabIndex = 14;
            btnUpdateManufacturer.Text = "btnUpdateManufacturer";
            btnUpdateManufacturer.UseVisualStyleBackColor = true;
            btnUpdateManufacturer.Click += btnUpdateManufacturer_Click;
            // 
            // btnUpdateModel
            // 
            btnUpdateModel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnUpdateModel.Location = new Point(401, 327);
            btnUpdateModel.Name = "btnUpdateModel";
            btnUpdateModel.Size = new Size(227, 38);
            btnUpdateModel.TabIndex = 15;
            btnUpdateModel.Text = "btnUpdateModel";
            btnUpdateModel.UseVisualStyleBackColor = true;
            btnUpdateModel.Click += btnUpdateModel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1037, 467);
            Controls.Add(btnUpdateModel);
            Controls.Add(btnUpdateManufacturer);
            Controls.Add(btnDeleteModel);
            Controls.Add(btnDeleteManufacturer);
            Controls.Add(btnAddModel);
            Controls.Add(btnAddManufacturer);
            Controls.Add(txtYear);
            Controls.Add(txtModelName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCountry);
            Controls.Add(txtName);
            Controls.Add(dgvModels);
            Controls.Add(dgvManufacturers);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvManufacturers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvModels).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvManufacturers;
        private DataGridView dgvModels;
        private TextBox txtName;
        private TextBox txtCountry;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtModelName;
        private TextBox txtYear;
        private Button btnAddManufacturer;
        private Button btnAddModel;
        private Button btnDeleteManufacturer;
        private Button btnDeleteModel;
        private Button btnUpdateManufacturer;
        private Button btnUpdateModel;
    }
}
